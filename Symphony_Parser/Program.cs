using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Test
{

    public static void Main()
    {
        Console.WriteLine("What would you like to name your barcode report? " +
                        "Preferably the name of the class this report is for.");

        string className = Console.ReadLine();

        Console.WriteLine("Where is the file located? Drag the file into this screen then hit enter when finished.");
        string filePath = Console.ReadLine();

        Console.WriteLine("Where would you like the barcode report to be saved to?");
        string outputString = Console.ReadLine();

        string outputDirectory = outputString + className + " - " + DateTime.Now.ToString("dddd, dd MMMM yyyy") + ".xlsx";

        FileInfo outputFilePath = new FileInfo(outputDirectory);

        ReadReport(filePath, outputFilePath, outputDirectory, className);

        Console.WriteLine("Your barcode report is now ready and available in:");
        Console.WriteLine(outputDirectory);
        Whitespace();
        Console.WriteLine("Press any key to end the program.");
        Whitespace();

    }

    public static void ReadReport(string reportPath, FileInfo outputDirectory, string outputString, string className)
    {
        List<string> usersList = new List<string>();

        using (StreamReader sr = new StreamReader(reportPath))
        {
            string[] allLine = File.ReadAllLines(reportPath);

            foreach (string unsplitUser in allLine)
            {
                if (unsplitUser.Contains("|"))
                {
                    string[] splitUser = unsplitUser.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string data in splitUser)
                    {
                        string cleanedString = System.Text.RegularExpressions.Regex.Replace(data, @"\s{2,}", "");
                        usersList.Add(cleanedString);
                        Console.WriteLine(data);
                    }
                }
            }
            Console.WriteLine("Data has been read!");
        }
        FileExists(outputDirectory, outputString);
        WriteToFile(outputDirectory, usersList, className);

    }

    public static void WriteToFile(FileInfo outputDirectory, List<string> usersList, string className)
    {
        using (ExcelPackage excel = new ExcelPackage(outputDirectory))
        {
            Console.WriteLine("File is being created.");
            var ws = excel.Workbook.Worksheets.Add("Barcode Report");
            Console.WriteLine("Users are being written to file.");

            //Page Formatting
            ws.Column(1).Width = 26.50;
            ws.Column(2).Width = 26.50;
            ws.Column(3).Width = 26.50;
            ws.Cells["A:Z"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

            //Function for Automatically writing data to an excel file
            int idRow = 1; //Row in which the user ID is contained
            int rowCounter = 1; //Keeps track of how many times the row has been incremented
            int colCounter = 1; ////Keeps track of how many times the column has been incremented
            int Column = 1; //Current Column
            int Row = 1; //Current Row
           
            foreach(string data in usersList)
            {
                if (rowCounter == 4)
                {
                    Row = Row - 3; 
                    rowCounter = 1; 
                    Column++;
                    colCounter++;
                }
                
                if(colCounter == 4)
                {
                    colCounter = 1;
                    Column = 1;
                    Row = Row+4;
                }

                ws.Row(idRow).Style.Font.Size = 30;
                ws.Row(idRow).Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells[Row, Column].Value = data;
                Row++;
                rowCounter++;
                idRow = idRow + 4;
            }
            Whitespace();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0} user(s) written to file.",usersList.Count/3);
            Console.ForegroundColor = ConsoleColor.White;

            HeaderContentGap(ws, usersList);
            fitPageBreakToPage(ws, usersList);
            AddPageHeaders(ws, className);
            WorkSheetProperties(ws);

            excel.SaveAs(outputDirectory);
        }
    }

    static void fitPageBreakToPage(ExcelWorksheet ws, List<string> userList)
    {
        //Remove all Page Breaks
        for (int i = 1; i <= userList.Count + userList.Count / 3; i++)
        {
            ws.Row(i).PageBreak = false;
            ws.Column(i).PageBreak = false;
        }

        //Create a page break at the end of every page
        //Delete the Blank row (i) as it creates an empty row
        //WARNING: If anything is resized then you'll likely have to update these values to fit everything again
        for (int i = 40; i <= userList.Count + userList.Count / 3; i += 40 )
        {
            ws.Row(i).PageBreak = true;
            ws.DeleteRow(i);
        }

        ws.Column(3).PageBreak = true;
    }

    static void AddPageHeaders(ExcelWorksheet ws, string className)
    {
        ws.HeaderFooter.AlignWithMargins = true;
        ws.HeaderFooter.EvenHeader.CenteredText = "&28&\"Arial,Regular Bold\"" + className + " - Barcodes";
        ws.HeaderFooter.OddHeader.CenteredText = "&28&\"Arial,Regular Bold\"" + className + " - Barcodes";
    }

    static void HeaderContentGap(ExcelWorksheet ws, List<string> userList)
    {
        for (int i = 1; i <= userList.Count + userList.Count / 3; i+=40)
        {
            ws.InsertRow(i, 1);
        }
    }

    static void WorkSheetProperties(ExcelWorksheet ws)
    {
        ws.View.PageLayoutView = true;
    }

    public static void FileExists(FileInfo outputDirectory, string outputString)
    {
        if (outputDirectory.Exists)
        {
            try
            {
                File.Delete(outputString);
            }

            catch(Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Please close the the Worksheet before trying to run this program.");
                Whitespace();
                Console.WriteLine("Press any key to exit!");
                Console.Read();
                Environment.Exit(1);
            }
        }
    }

    public static void Whitespace()
    {
        Console.WriteLine();
    }

    public static void ClearScreen()
    {
        Console.Clear();
    }
}

