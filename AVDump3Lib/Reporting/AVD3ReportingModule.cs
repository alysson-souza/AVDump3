using AVDump3Lib.Modules;
using AVDump3Lib.Reporting.Core;
using AVDump3Lib.Reporting.Reports;
using System.Collections.Generic;

namespace AVDump3Lib.Reporting {
	public interface IAVD3ReportingModule : IAVD3Module {
		IReadOnlyCollection<IReportFactory> ReportFactories { get; }
		void AddReportFactory(ReportFactory reportFactory);
	}
	public class AVD3ReportingModule : IAVD3ReportingModule {
		private List<IReportFactory> reportFactories;

		public IReadOnlyCollection<IReportFactory> ReportFactories { get; }


		public AVD3ReportingModule() {
			reportFactories = new List<IReportFactory> {
				new ReportFactory("AVD3Report", fileMetaInfo => new AVD3Report(fileMetaInfo)),
				//new ReportFactory("AniDBReport", fileMetaInfo => new AniDBReport(fileMetaInfo))
			};

			ReportFactories = reportFactories.AsReadOnly();
		}

		public void AddReportFactory(ReportFactory reportFactory) { reportFactories.Add(reportFactory); }

		public void Initialize(IReadOnlyCollection<IAVD3Module> modules) { }
		public ModuleInitResult Initialized() => new ModuleInitResult(false);
	}
}
