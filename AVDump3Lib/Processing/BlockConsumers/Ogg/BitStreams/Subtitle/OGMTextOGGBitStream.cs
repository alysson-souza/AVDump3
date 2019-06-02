using System;
using System.Runtime.InteropServices;

namespace AVDump3Lib.Processing.BlockConsumers.Ogg.BitStreams {
	public class OGMTextOGGBitStream : SubtitleOGGBitStream, IOGMStream, IVorbisComment {
		public override string CodecName { get { return "OGMText"; } }
		public override string CodecVersion { get; protected set; }
		public string ActualCodecName { get; private set; }

		public OGMTextOGGBitStream(ReadOnlySpan<byte> header)
			: base(false) {
			var codecInfo = MemoryMarshal.Read<OGMTextHeader>(header.Slice(1, 0x38));
			ActualCodecName = new string(codecInfo.SubType);
		}

		[StructLayout(LayoutKind.Sequential, Size = 52)]
		public struct OGMTextHeader {
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
			public char[] StreamType;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
			public char[] SubType;
			public int Size;
			public long TimeUnit;
			public long SamplesPerUnit;
			public int DefaultLength;
			public int BufferSize;
			public short BitsPerSample;
			public long Unused;
		}

		public override void ProcessPage(ref OggPage page) {
			base.ProcessPage(ref page);
			commentParser.ParsePage(ref page);
		}

		private VorbisCommentParser commentParser = new VorbisCommentParser();
		public Comments Comments {
			get {
				try {
					return commentParser.RetrieveComments();
				} catch(Exception) {
					return null; //TODO: Log warning
				}
			}
		}
	}
}
