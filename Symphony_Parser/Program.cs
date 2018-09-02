using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.IO;

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

        ReadReport(className, filePath, outputFilePath, outputDirectory);

        Console.WriteLine("Your barcode report is now ready and available in {0}", outputDirectory);
        Console.WriteLine("Press any key to end the program.");
        Whitespace();

        Console.Read();
    }

    public static void ReadReport(string className, string reportPath, FileInfo outputDirectory, string outputString)
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
                        string cleanedString = System.Text.RegularExpressions.Regex.Replace(data, @"\s{2,}", " ");
                        usersList.Add(cleanedString);
                        Console.WriteLine(data);
                    }
                }
            }
            Console.WriteLine("Data has been read!");

        }

        writeToFile(outputDirectory, usersList, outputString);
    }

    public static void writeToFile(FileInfo outputDirectory, List<string> usersList, string outputString)
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

            //---------------------------------------

            ws.Cells["A2"].Style.Font.Size = 30;
            ws.Cells["A2"].Style.Font.Name = "Free 3 of 9 Extended";
            ws.Cells["A2"].Value = usersList[0];
            ws.Cells["A3"].Value = usersList[1];
            ws.Cells["A4"].Value = usersList[3];

            ws.Cells["B2"].Style.Font.Size = 30;
            ws.Cells["B2"].Style.Font.Name = "Free 3 of 9 Extended";
            ws.Cells["B2"].Value = usersList[3];
            ws.Cells["B3"].Value = usersList[4];
            ws.Cells["B4"].Value = usersList[5];

            ws.Cells["C2"].Style.Font.Size = 30;
            ws.Cells["C2"].Style.Font.Name = "Free 3 of 9 Extended";
            ws.Cells["C2"].Value = usersList[6];
            ws.Cells["C3"].Value = usersList[7];
            ws.Cells["C4"].Value = usersList[8];

            //-----------------------------------------

            ws.Cells["A7"].Style.Font.Size = 30;
            ws.Cells["A7"].Style.Font.Name = "Free 3 of 9 Extended";
            ws.Cells["A7"].Value = usersList[9];
            ws.Cells["A8"].Value = usersList[10];
            ws.Cells["A9"].Value = usersList[11];

            ws.Cells["B7"].Style.Font.Size = 30;
            ws.Cells["B7"].Style.Font.Name = "Free 3 of 9 Extended";
            ws.Cells["B7"].Value = usersList[12];
            ws.Cells["B8"].Value = usersList[13];
            ws.Cells["B9"].Value = usersList[14];

            ws.Cells["C7"].Style.Font.Size = 30;
            ws.Cells["C7"].Style.Font.Name = "Free 3 of 9 Extended";
            ws.Cells["C7"].Value = usersList[9];
            ws.Cells["C8"].Value = usersList[10];
            ws.Cells["C9"].Value = usersList[11];

            //-----------------------------------------

            ws.Cells["A12"].Style.Font.Size = 30;
            ws.Cells["A12"].Style.Font.Name = "Free 3 of 9 Extended";
            ws.Cells["A12"].Value = usersList[12];
            ws.Cells["A13"].Value = usersList[13];
            ws.Cells["A14"].Value = usersList[14];

            ws.Cells["B12"].Style.Font.Size = 30;
            ws.Cells["B12"].Style.Font.Name = "Free 3 of 9 Extended";
            ws.Cells["B12"].Value = usersList[15];
            ws.Cells["B13"].Value = usersList[16];
            ws.Cells["B14"].Value = usersList[17];

            ws.Cells["C12"].Style.Font.Size = 30;
            ws.Cells["C12"].Style.Font.Name = "Free 3 of 9 Extended";
            ws.Cells["C12"].Value = usersList[18];
            ws.Cells["C13"].Value = usersList[19];
            ws.Cells["C14"].Value = usersList[20];

            // --------------------------------------


            ws.Cells["A17"].Style.Font.Size = 30;
            ws.Cells["A17"].Style.Font.Name = "Free 3 of 9 Extended";
            ws.Cells["A17"].Value = usersList[21];
            ws.Cells["A18"].Value = usersList[22];
            ws.Cells["A19"].Value = usersList[23];

            ws.Cells["B17"].Style.Font.Size = 30;
            ws.Cells["B17"].Style.Font.Name = "Free 3 of 9 Extended";
            ws.Cells["B17"].Value = usersList[24];
            ws.Cells["B18"].Value = usersList[25];
            ws.Cells["B19"].Value = usersList[26];

            ws.Cells["C17"].Style.Font.Size = 30;
            ws.Cells["C17"].Style.Font.Name = "Free 3 of 9 Extended";
            ws.Cells["C17"].Value = usersList[27];
            ws.Cells["C18"].Value = usersList[28];
            ws.Cells["C19"].Value = usersList[29];

            //---------------------------------------

            ws.Cells["A22"].Style.Font.Size = 30;
            ws.Cells["A22"].Style.Font.Name = "Free 3 of 9 Extended";
            ws.Cells["A22"].Value = usersList[30];
            ws.Cells["A23"].Value = usersList[31];
            ws.Cells["A24"].Value = usersList[32];

            ws.Cells["B22"].Style.Font.Size = 30;
            ws.Cells["B22"].Style.Font.Name = "Free 3 of 9 Extended";
            ws.Cells["B22"].Value = usersList[33];
            ws.Cells["B23"].Value = usersList[34];
            ws.Cells["B24"].Value = usersList[35];

            ws.Cells["C22"].Style.Font.Size = 30;
            ws.Cells["C22"].Style.Font.Name = "Free 3 of 9 Extended";
            ws.Cells["C22"].Value = usersList[36];
            ws.Cells["C23"].Value = usersList[37];
            ws.Cells["C24"].Value = usersList[38];

            //---------------------------------------

            ws.Cells["A25"].Style.Font.Size = 30;
            ws.Cells["A25"].Style.Font.Name = "Free 3 of 9 Extended";
            ws.Cells["A25"].Value = usersList[39];
            ws.Cells["A26"].Value = usersList[40];
            ws.Cells["A27"].Value = usersList[41];

            ws.Cells["B25"].Style.Font.Size = 30;
            ws.Cells["B25"].Style.Font.Name = "Free 3 of 9 Extended";
            ws.Cells["B25"].Value = usersList[42];
            ws.Cells["B26"].Value = usersList[43];
            ws.Cells["B27"].Value = usersList[44];

            ws.Cells["C25"].Style.Font.Size = 30;
            ws.Cells["C25"].Style.Font.Name = "Free 3 of 9 Extended";
            ws.Cells["C25"].Value = usersList[45];
            ws.Cells["C26"].Value = usersList[46];
            ws.Cells["C27"].Value = usersList[47];

            //---------------------------------------

            ws.Cells["A30"].Style.Font.Size = 30;
            ws.Cells["A30"].Style.Font.Name = "Free 3 of 9 Extended";
            ws.Cells["A30"].Value = usersList[48];
            ws.Cells["A31"].Value = usersList[49];
            ws.Cells["A32"].Value = usersList[50];

            ws.Cells["B30"].Style.Font.Size = 30;
            ws.Cells["B30"].Style.Font.Name = "Free 3 of 9 Extended";
            ws.Cells["B30"].Value = usersList[51];
            ws.Cells["B31"].Value = usersList[52];
            ws.Cells["B32"].Value = usersList[53];

            ws.Cells["C30"].Style.Font.Size = 30;
            ws.Cells["C30"].Style.Font.Name = "Free 3 of 9 Extended";
            ws.Cells["C30"].Value = usersList[54];
            ws.Cells["C31"].Value = usersList[55];
            ws.Cells["C32"].Value = usersList[56];

            //---------------------------------------





            excel.Save();
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

