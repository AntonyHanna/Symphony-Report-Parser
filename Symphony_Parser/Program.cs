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

        ReadReport(filePath, outputFilePath, outputDirectory);

        Console.WriteLine("Your barcode report is now ready and available in:");
        Console.WriteLine(outputDirectory);
        Whitespace();
        Console.WriteLine("Press any key to end the program.");
        Whitespace();

        Console.Read();
    }

    public static void ReadReport(string reportPath, FileInfo outputDirectory, string outputString)
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

        WriteToFile(outputDirectory, usersList, outputString);
    }

    public static void WriteToFile(FileInfo outputDirectory, List<string> usersList, string outputString)
    {
        FileExists(outputDirectory, outputString);
        using (ExcelPackage excel = new ExcelPackage(outputDirectory))
        {
            Console.WriteLine("File is being created.");
            var ws = excel.Workbook.Worksheets.Add("Barcode Report");
            Console.WriteLine("Users are being written to file.");

            //Page Formatting
            ws.Column(1).Width = 30.00;
            ws.Column(2).Width = 30.00;
            ws.Column(3).Width = 30.00;
            ws.Cells["A1:Z150"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;


            //Write Data to Excel function here
            
            int rowCounter = 1;
            int colCounter = 1;
            int Column = 1;
            int Row = 1;
           
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

                ws.Cells[Row, Column].Value = data;
                Row++;
                rowCounter++;
                
            }

            catch
            {
                Console.WriteLine("{0} entry(s) written!",usersList.Count);
            }

            excel.SaveAs(outputDirectory);
            Console.WriteLine("File has been saved to the specified directory.");
        }
    }

    public static void FileExists(FileInfo outputDirectory, string outputString)
    {
        if (outputDirectory.Exists)
        {
            File.Delete(outputString);
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

