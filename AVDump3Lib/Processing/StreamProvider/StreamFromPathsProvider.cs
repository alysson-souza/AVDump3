using AVDump3Lib.Misc;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading;

namespace AVDump3Lib.Processing.StreamProvider {
    public class PathPartitions {
        public int ConcurrentCount { get; private set; }
        public ReadOnlyCollection<PathPartition> Partitions { get; private set; }

        public PathPartitions(int concurrentCount, IEnumerable<PathPartition> partitions) {
            ConcurrentCount = concurrentCount;
            Partitions = Array.AsReadOnly(partitions.ToArray());
        }
    }

	public class PathPartition {
		public string Path { get; }
		public int ConcurrentCount { get; }

		public PathPartition(string path, int concurrentCount) {
			Path = path;
			ConcurrentCount = concurrentCount;
		}
	}

	public sealed class StreamFromPathsProvider : IStreamProvider, IDisposable {
		private List<LocalConcurrency> localConcurrencyPartitions;
		private SemaphoreSlim globalConcurrency = new SemaphoreSlim(1);

		public int TotalFileCount { get; private set; }
		public long TotalBytes { get; private set; }

		public StreamFromPathsProvider(PathPartitions pathPartitions,
			IEnumerable<string> paths, bool includeSubFolders, Func<string, bool> accept, Action<Exception> onError
		) {

			globalConcurrency = new SemaphoreSlim(pathPartitions.ConcurrentCount);

			localConcurrencyPartitions = pathPartitions.Partitions.Select(pp =>
				new LocalConcurrency {
					Path = pp.Path,
					Limit = new SemaphoreSlim(pp.ConcurrentCount)
				}
			).ToList();
			localConcurrencyPartitions.Add(new LocalConcurrency { Path = "", Limit = new SemaphoreSlim(1) });
			//localConcurrencyPartitions.Sort((a, b) => b.Path.Length.CompareTo(a.Path.Length));

			FileTraversal.Traverse(paths, includeSubFolders, filePath => {
				if(!accept(filePath)) return;
				var fileInfo = new FileInfo(filePath);
				//if(fileInfo.Length < 1 << 30) return;

				TotalBytes += fileInfo.Length;
				localConcurrencyPartitions.First(ldKey => filePath.StartsWith(ldKey.Path)).Files.Enqueue(filePath);
				TotalFileCount++;
			}, onError);
		}

		public IEnumerable<ProvidedStream> GetConsumingEnumerable(CancellationToken ct) {
			while(localConcurrencyPartitions.Sum(ldPathLimit => ldPathLimit.Files.Count) != 0) {
				globalConcurrency.Wait(ct);
				var localLimits = localConcurrencyPartitions.Where(ll => ll.Files.Count != 0).ToArray();
				var i = WaitHandle.WaitAny(localLimits.Select(ll => ll.Limit.AvailableWaitHandle).ToArray());
				localLimits[i].Limit.Wait();

				yield return new ProvidedStreamFromPath(this, localLimits[i].Files.Dequeue()); //TODO error handling (e.g. file not found)
			}
		}

		private void Release(string filePath) {
			localConcurrencyPartitions.First(ldKey => filePath.StartsWith(ldKey.Path)).Limit.Release();
			globalConcurrency.Release();
		}

		public void Dispose() {
			globalConcurrency.Dispose();
			foreach(var localConcurrencyPartition in localConcurrencyPartitions) {
				localConcurrencyPartition.Limit.Dispose();
			}

		}

		private class LocalConcurrency {
			public string Path;
			public SemaphoreSlim Limit;
			public Queue<string> Files = new Queue<string>();
		}

		private class ProvidedStreamFromPath : ProvidedStream {
			private StreamFromPathsProvider provider;
			private string filePath;

			public ProvidedStreamFromPath(StreamFromPathsProvider provider, string filePath) : base(filePath, File.OpenRead(filePath)) {
				this.provider = provider;
				this.filePath = filePath;
			}

			public override void Dispose() {
				provider.Release(filePath);
				Stream.Dispose();
			}
		}
	}
}