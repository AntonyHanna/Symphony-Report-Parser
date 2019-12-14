using Microsoft.VisualStudio.TestTools.UnitTesting;
using SymphonyReportParser.Models;
using System.IO;

namespace SymphonyReportParserTests
{
	[TestClass]
	public class ReportProcessorTests
	{
		[TestMethod]
		public void ReadReport_InvalidPath_ThrowFileNotFoundException()
		{
			ReportProcessor processor = new ReportProcessor("ok" ,"fakefile.sjd");

			Assert.ThrowsException<FileNotFoundException>(() => { processor.ReadReport(); });
		}
	}
}
