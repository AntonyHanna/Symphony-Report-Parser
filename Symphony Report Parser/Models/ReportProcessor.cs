using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace SymphonyReportParser.Models
{
	public class ReportProcessor
	{
		/// <summary>
		/// The location to save the sheet, should not contain a file name
		/// </summary>
		public FileInfo SaveLocation { get; }
		public FileInfo ReportLocation { get; }
		public string FileName 
		{
			get
			{
				DateTime curTime = DateTime.Now;
				return $"{curTime.Day}.{curTime.Month}.{curTime.Year} " +
				$"{curTime.Hour}{curTime.Minute}{curTime.Second} " +
				$"Barcode Report.xlsx";
			}
		}

		private ExcelPackage _excelPackage;
		private ExcelWorksheet _worksheet;

		public ReportProcessor(string reportLocation, string saveLocation)
		{
			this._excelPackage = new ExcelPackage();
			this._worksheet = this._excelPackage.Workbook.Worksheets.Add("Users");
			this.ReportLocation = new FileInfo(reportLocation);
			this.SaveLocation = new FileInfo(saveLocation);

			PageFormatting();
		}
		public static string[] RemoveIrrelevantLines(string[] report)
		{
			List<string> relevantLines = new List<string>();

			foreach(string str in report)
			{
				if (str.Contains('|'))
					relevantLines.Add(str);
			}

			return relevantLines.ToArray();
		}
		private void PageFormatting()
		{
			// Text Allignment
			_worksheet.Cells["A:Z"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

			// Headers
			_worksheet.HeaderFooter.AlignWithMargins = true;
			_worksheet.HeaderFooter.EvenHeader.CenteredText = "&28&\"Arial,Regular Bold\" Class X";
			_worksheet.HeaderFooter.OddHeader.CenteredText = "&28&\"Arial,Regular Bold\" Class X";

			// Worksheet Properties
			_worksheet.View.PageLayoutView = true;
			_worksheet.Column(4).PageBreak = true;

			// Column Width
			for (int i = 1; i < 4; i++)
				_worksheet.Column(i).Width = 26.5;
		}
		public void WriteUsersToFile(List<User> users)
		{
			// Sheets do not have a zero based index
			int row = 1;
			int column = 1;

			foreach(User user in users)
			{
				// Styling for the ID / Barcode
				_worksheet.Cells[row, column].Style.Font.Size = 30;
				_worksheet.Cells[row, column].Style.Font.Name = "Free 3 of 9 Extended";

				// One unit of data
				_worksheet.Cells[row, column].Value = user.Id;
				_worksheet.Cells[row + 1, column].Value = user.FullName;
				_worksheet.Cells[row + 2, column].Value = user.UserName;

				column++;

				if(column == 4)
				{
					column = 1;
					row += 4;
				}
			}

			PostWriteFormatting();
			_excelPackage.SaveAs(new FileInfo(this.SaveLocation + this.FileName));
				
		}
		public string[] ReadReport()
		{
			string[] allLines = default;
			try
			{
				allLines = File.ReadAllLines(this.ReportLocation.FullName);
			}
			catch { throw new FileNotFoundException(); }
			return allLines;
		}
		private void PostWriteFormatting()
		{
			for (int i = 1; i < User.Users.Count * 4; i++)
			{
				// Add an initial empty row
				if(i == 1)
					_worksheet.InsertRow(i, 1);

				// Ends the page one row after the last entry
				if (i % 33 == 0)
				{
					_worksheet.InsertRow(i, 1);
					_worksheet.Row(i).PageBreak = true;
				}
			}
		}
	}
}