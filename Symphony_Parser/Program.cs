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

        ReadReport(filePath, outputFilePath, outputDirectory);

        Console.WriteLine("Your barcode report is now ready and available in {0}", outputDirectory);
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

            ws.Cells["A27"].Style.Font.Size = 30;
            ws.Cells["A27"].Style.Font.Name = "Free 3 of 9 Extended";
            ws.Cells["A27"].Value = usersList[39];
            ws.Cells["A28"].Value = usersList[40];
            ws.Cells["A29"].Value = usersList[41];

            ws.Cells["B27"].Style.Font.Size = 30;
            ws.Cells["B27"].Style.Font.Name = "Free 3 of 9 Extended";
            ws.Cells["B27"].Value = usersList[42];
            ws.Cells["B28"].Value = usersList[43];
            ws.Cells["B29"].Value = usersList[44];

            ws.Cells["C27"].Style.Font.Size = 30;
            ws.Cells["C27"].Style.Font.Name = "Free 3 of 9 Extended";
            ws.Cells["C27"].Value = usersList[45];
            ws.Cells["C28"].Value = usersList[46];
            ws.Cells["C29"].Value = usersList[47];

            //---------------------------------------

            ws.Cells["A32"].Style.Font.Size = 30;
            ws.Cells["A32"].Style.Font.Name = "Free 3 of 9 Extended";
            ws.Cells["A32"].Value = usersList[48];
            ws.Cells["A33"].Value = usersList[49];
            ws.Cells["A34"].Value = usersList[50];

            ws.Cells["B32"].Style.Font.Size = 30;
            ws.Cells["B32"].Style.Font.Name = "Free 3 of 9 Extended";
            ws.Cells["B32"].Value = usersList[51];
            ws.Cells["B33"].Value = usersList[52];
            ws.Cells["B34"].Value = usersList[53];

            ws.Cells["C32"].Style.Font.Size = 30;
            ws.Cells["C32"].Style.Font.Name = "Free 3 of 9 Extended";
            ws.Cells["C32"].Value = usersList[54];
            ws.Cells["C33"].Value = usersList[55];
            ws.Cells["C34"].Value = usersList[56];

            //---------------------------------------

            ws.Cells["A37"].Style.Font.Size = 30;
            ws.Cells["A37"].Style.Font.Name = "Free 3 of 9 Extended";
            ws.Cells["A37"].Value = usersList[57];
            ws.Cells["A38"].Value = usersList[58];
            ws.Cells["A39"].Value = usersList[59];

            ws.Cells["B37"].Style.Font.Size = 30;
            ws.Cells["B37"].Style.Font.Name = "Free 3 of 9 Extended";
            ws.Cells["B37"].Value = usersList[60];
            ws.Cells["B38"].Value = usersList[61];
            ws.Cells["B39"].Value = usersList[62];

            ws.Cells["C37"].Style.Font.Size = 30;
            ws.Cells["C37"].Style.Font.Name = "Free 3 of 9 Extended";
            ws.Cells["C37"].Value = usersList[63];
            ws.Cells["C38"].Value = usersList[64];
            ws.Cells["C39"].Value = usersList[65];

            //---------------------------------------
            ws.Cells["A42"].Style.Font.Size = 30;
            ws.Cells["A42"].Style.Font.Name = "Free 3 of 9 Extended";
            ws.Cells["A42"].Value = usersList[66];
            ws.Cells["A43"].Value = usersList[67];
            ws.Cells["A44"].Value = usersList[68];

            ws.Cells["B42"].Style.Font.Size = 30;
            ws.Cells["B42"].Style.Font.Name = "Free 3 of 9 Extended";
            ws.Cells["B42"].Value = usersList[69];
            ws.Cells["B43"].Value = usersList[70];
            ws.Cells["B44"].Value = usersList[71];

            ws.Cells["C42"].Style.Font.Size = 30;
            ws.Cells["C42"].Style.Font.Name = "Free 3 of 9 Extended";
            ws.Cells["C42"].Value = usersList[71];
            ws.Cells["C43"].Value = usersList[72];
            ws.Cells["C44"].Value = usersList[73];

            //---------------------------------------

            ws.Cells["A47"].Style.Font.Size = 30;
            ws.Cells["A47"].Style.Font.Name = "Free 3 of 9 Extended";
            ws.Cells["A47"].Value = usersList[74];
            ws.Cells["A48"].Value = usersList[75];
            ws.Cells["A49"].Value = usersList[76];

            ws.Cells["B47"].Style.Font.Size = 30;
            ws.Cells["B47"].Style.Font.Name = "Free 3 of 9 Extended";
            ws.Cells["B47"].Value = usersList[77];
            ws.Cells["B48"].Value = usersList[78];
            ws.Cells["B49"].Value = usersList[79];

            ws.Cells["C47"].Style.Font.Size = 30;
            ws.Cells["C47"].Style.Font.Name = "Free 3 of 9 Extended";
            ws.Cells["C47"].Value = usersList[80];
            ws.Cells["C48"].Value = usersList[81];
            ws.Cells["C49"].Value = usersList[82];

            //---------------------------------------

            ws.Cells["A52"].Style.Font.Size = 30;
            ws.Cells["A52"].Style.Font.Name = "Free 3 of 9 Extended";
            ws.Cells["A52"].Value = usersList[83];
            ws.Cells["A53"].Value = usersList[84];
            ws.Cells["A54"].Value = usersList[85];

            ws.Cells["B52"].Style.Font.Size = 30;
            ws.Cells["B52"].Style.Font.Name = "Free 3 of 9 Extended";
            ws.Cells["B52"].Value = usersList[86];
            ws.Cells["B53"].Value = usersList[87];
            ws.Cells["B54"].Value = usersList[88];

            ws.Cells["C52"].Style.Font.Size = 30;
            ws.Cells["C52"].Style.Font.Name = "Free 3 of 9 Extended";
            ws.Cells["C52"].Value = usersList[89];
            ws.Cells["C53"].Value = usersList[90];
            ws.Cells["C54"].Value = usersList[91];

            //---------------------------------------

            ws.Cells["A57"].Style.Font.Size = 30;
            ws.Cells["A57"].Style.Font.Name = "Free 3 of 9 Extended";
            ws.Cells["A57"].Value = usersList[92];
            ws.Cells["A58"].Value = usersList[93];
            ws.Cells["A59"].Value = usersList[94];

            ws.Cells["B57"].Style.Font.Size = 30;
            ws.Cells["B57"].Style.Font.Name = "Free 3 of 9 Extended";
            ws.Cells["B57"].Value = usersList[95];
            ws.Cells["B58"].Value = usersList[96];
            ws.Cells["B59"].Value = usersList[97];

            ws.Cells["C57"].Style.Font.Size = 30;
            ws.Cells["C57"].Style.Font.Name = "Free 3 of 9 Extended";
            ws.Cells["C57"].Value = usersList[98];
            ws.Cells["C58"].Value = usersList[99];
            ws.Cells["C59"].Value = usersList[100];

            //---------------------------------------

            ws.Cells["A62"].Style.Font.Size = 30;
            ws.Cells["A62"].Style.Font.Name = "Free 3 of 9 Extended";
            ws.Cells["A62"].Value = usersList[101];
            ws.Cells["A63"].Value = usersList[102];
            ws.Cells["A64"].Value = usersList[103];

            ws.Cells["B62"].Style.Font.Size = 30;
            ws.Cells["B62"].Style.Font.Name = "Free 3 of 9 Extended";
            ws.Cells["B62"].Value = usersList[104];
            ws.Cells["B63"].Value = usersList[105];
            ws.Cells["B64"].Value = usersList[106];

            ws.Cells["C62"].Style.Font.Size = 30;
            ws.Cells["C62"].Style.Font.Name = "Free 3 of 9 Extended";
            ws.Cells["C62"].Value = usersList[107];
            ws.Cells["C63"].Value = usersList[108];
            ws.Cells["C64"].Value = usersList[109];

            //---------------------------------------



            //---------------------------------------



            //---------------------------------------



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

