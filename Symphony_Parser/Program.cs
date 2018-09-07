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


            try
            {
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
                ws.Cells["C42"].Value = usersList[72];
                ws.Cells["C43"].Value = usersList[73];
                ws.Cells["C44"].Value = usersList[74];

                //---------------------------------------

                ws.Cells["A47"].Style.Font.Size = 30;
                ws.Cells["A47"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["A47"].Value = usersList[75];
                ws.Cells["A48"].Value = usersList[76];
                ws.Cells["A49"].Value = usersList[77];

                ws.Cells["B47"].Style.Font.Size = 30;
                ws.Cells["B47"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["B47"].Value = usersList[78];
                ws.Cells["B48"].Value = usersList[79];
                ws.Cells["B49"].Value = usersList[80];

                ws.Cells["C47"].Style.Font.Size = 30;
                ws.Cells["C47"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["C47"].Value = usersList[81];
                ws.Cells["C48"].Value = usersList[82];
                ws.Cells["C49"].Value = usersList[83];

                //---------------------------------------

                ws.Cells["A52"].Style.Font.Size = 30;
                ws.Cells["A52"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["A52"].Value = usersList[84];
                ws.Cells["A53"].Value = usersList[85];
                ws.Cells["A54"].Value = usersList[86];

                ws.Cells["B52"].Style.Font.Size = 30;
                ws.Cells["B52"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["B52"].Value = usersList[87];
                ws.Cells["B53"].Value = usersList[88];
                ws.Cells["B54"].Value = usersList[89];

                ws.Cells["C52"].Style.Font.Size = 30;
                ws.Cells["C52"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["C52"].Value = usersList[90];
                ws.Cells["C53"].Value = usersList[91];
                ws.Cells["C54"].Value = usersList[92];

                //---------------------------------------

                ws.Cells["A57"].Style.Font.Size = 30;
                ws.Cells["A57"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["A57"].Value = usersList[93];
                ws.Cells["A58"].Value = usersList[94];
                ws.Cells["A59"].Value = usersList[95];

                ws.Cells["B57"].Style.Font.Size = 30;
                ws.Cells["B57"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["B57"].Value = usersList[96];
                ws.Cells["B58"].Value = usersList[97];
                ws.Cells["B59"].Value = usersList[98];

                ws.Cells["C57"].Style.Font.Size = 30;
                ws.Cells["C57"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["C57"].Value = usersList[99];
                ws.Cells["C58"].Value = usersList[100];
                ws.Cells["C59"].Value = usersList[101];

                //---------------------------------------

                ws.Cells["A62"].Style.Font.Size = 30;
                ws.Cells["A62"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["A62"].Value = usersList[102];
                ws.Cells["A63"].Value = usersList[103];
                ws.Cells["A64"].Value = usersList[104];

                ws.Cells["B62"].Style.Font.Size = 30;
                ws.Cells["B62"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["B62"].Value = usersList[105];
                ws.Cells["B63"].Value = usersList[106];
                ws.Cells["B64"].Value = usersList[107];

                ws.Cells["C62"].Style.Font.Size = 30;
                ws.Cells["C62"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["C62"].Value = usersList[108];
                ws.Cells["C63"].Value = usersList[109];
                ws.Cells["C64"].Value = usersList[110];

                //---------------------------------------

                ws.Cells["A62"].Style.Font.Size = 30;
                ws.Cells["A62"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["A62"].Value = usersList[111];
                ws.Cells["A63"].Value = usersList[112];
                ws.Cells["A64"].Value = usersList[113];

                ws.Cells["B62"].Style.Font.Size = 30;
                ws.Cells["B62"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["B62"].Value = usersList[114];
                ws.Cells["B63"].Value = usersList[115];
                ws.Cells["B64"].Value = usersList[116];

                ws.Cells["C62"].Style.Font.Size = 30;
                ws.Cells["C62"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["C62"].Value = usersList[117];
                ws.Cells["C63"].Value = usersList[118];
                ws.Cells["C64"].Value = usersList[119];

                //---------------------------------------

                ws.Cells["A67"].Style.Font.Size = 30;
                ws.Cells["A67"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["A67"].Value = usersList[120];
                ws.Cells["A68"].Value = usersList[121];
                ws.Cells["A69"].Value = usersList[122];

                ws.Cells["B67"].Style.Font.Size = 30;
                ws.Cells["B67"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["B67"].Value = usersList[123];
                ws.Cells["B68"].Value = usersList[124];
                ws.Cells["B69"].Value = usersList[125];

                ws.Cells["C67"].Style.Font.Size = 30;
                ws.Cells["C67"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["C67"].Value = usersList[126];
                ws.Cells["C68"].Value = usersList[127];
                ws.Cells["C69"].Value = usersList[128];

                //---------------------------------------

                ws.Cells["A70"].Style.Font.Size = 30;
                ws.Cells["A70"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["A70"].Value = usersList[129];
                ws.Cells["A71"].Value = usersList[130];
                ws.Cells["A72"].Value = usersList[131];

                ws.Cells["B70"].Style.Font.Size = 30;
                ws.Cells["B70"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["B70"].Value = usersList[132];
                ws.Cells["B71"].Value = usersList[133];
                ws.Cells["B72"].Value = usersList[134];

                ws.Cells["C70"].Style.Font.Size = 30;
                ws.Cells["C70"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["C70"].Value = usersList[135];
                ws.Cells["C71"].Value = usersList[136];
                ws.Cells["C72"].Value = usersList[137];

                //---------------------------------------

                ws.Cells["A75"].Style.Font.Size = 30;
                ws.Cells["A75"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["A75"].Value = usersList[138];
                ws.Cells["A76"].Value = usersList[139];
                ws.Cells["A77"].Value = usersList[140];

                ws.Cells["B75"].Style.Font.Size = 30;
                ws.Cells["B75"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["B75"].Value = usersList[141];
                ws.Cells["B76"].Value = usersList[142];
                ws.Cells["B77"].Value = usersList[143];

                ws.Cells["C75"].Style.Font.Size = 30;
                ws.Cells["C75"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["C75"].Value = usersList[144];
                ws.Cells["C76"].Value = usersList[145];
                ws.Cells["C77"].Value = usersList[146];

                //---------------------------------------

                ws.Cells["A80"].Style.Font.Size = 30;
                ws.Cells["A80"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["A80"].Value = usersList[147];
                ws.Cells["A81"].Value = usersList[148];
                ws.Cells["A82"].Value = usersList[149];

                ws.Cells["B80"].Style.Font.Size = 30;
                ws.Cells["B80"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["B80"].Value = usersList[150];
                ws.Cells["B81"].Value = usersList[151];
                ws.Cells["B82"].Value = usersList[152];

                ws.Cells["C80"].Style.Font.Size = 30;
                ws.Cells["C80"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["C80"].Value = usersList[153];
                ws.Cells["C81"].Value = usersList[154];
                ws.Cells["C82"].Value = usersList[155];

                //---------------------------------------

                ws.Cells["A85"].Style.Font.Size = 30;
                ws.Cells["A85"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["A85"].Value = usersList[156];
                ws.Cells["A86"].Value = usersList[157];
                ws.Cells["A87"].Value = usersList[158];

                ws.Cells["B85"].Style.Font.Size = 30;
                ws.Cells["B85"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["B85"].Value = usersList[159];
                ws.Cells["B86"].Value = usersList[160];
                ws.Cells["B87"].Value = usersList[161];

                ws.Cells["C85"].Style.Font.Size = 30;
                ws.Cells["C85"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["C85"].Value = usersList[162];
                ws.Cells["C86"].Value = usersList[163];
                ws.Cells["C87"].Value = usersList[164];

                //---------------------------------------

                ws.Cells["A90"].Style.Font.Size = 30;
                ws.Cells["A90"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["A90"].Value = usersList[165];
                ws.Cells["A91"].Value = usersList[166];
                ws.Cells["A92"].Value = usersList[167];

                ws.Cells["B90"].Style.Font.Size = 30;
                ws.Cells["B90"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["B90"].Value = usersList[168];
                ws.Cells["B91"].Value = usersList[169];
                ws.Cells["B92"].Value = usersList[170];

                ws.Cells["C90"].Style.Font.Size = 30;
                ws.Cells["C90"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["C90"].Value = usersList[171];
                ws.Cells["C91"].Value = usersList[172];
                ws.Cells["C92"].Value = usersList[173];

                //---------------------------------------

                ws.Cells["A90"].Style.Font.Size = 30;
                ws.Cells["A90"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["A90"].Value = usersList[165];
                ws.Cells["A91"].Value = usersList[166];
                ws.Cells["A92"].Value = usersList[167];

                ws.Cells["B90"].Style.Font.Size = 30;
                ws.Cells["B90"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["B90"].Value = usersList[168];
                ws.Cells["B91"].Value = usersList[169];
                ws.Cells["B92"].Value = usersList[170];

                ws.Cells["C90"].Style.Font.Size = 30;
                ws.Cells["C90"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["C90"].Value = usersList[171];
                ws.Cells["C91"].Value = usersList[172];
                ws.Cells["C92"].Value = usersList[173];

                //---------------------------------------

                ws.Cells["A95"].Style.Font.Size = 30;
                ws.Cells["A95"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["A95"].Value = usersList[174];
                ws.Cells["A96"].Value = usersList[175];
                ws.Cells["A97"].Value = usersList[176];

                ws.Cells["B95"].Style.Font.Size = 30;
                ws.Cells["B95"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["B95"].Value = usersList[177];
                ws.Cells["B96"].Value = usersList[178];
                ws.Cells["B97"].Value = usersList[179];

                ws.Cells["C95"].Style.Font.Size = 30;
                ws.Cells["C95"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["C95"].Value = usersList[180];
                ws.Cells["C96"].Value = usersList[181];
                ws.Cells["C97"].Value = usersList[182];

                //---------------------------------------

                ws.Cells["A100"].Style.Font.Size = 30;
                ws.Cells["A100"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["A100"].Value = usersList[183];
                ws.Cells["A101"].Value = usersList[184];
                ws.Cells["A102"].Value = usersList[185];

                ws.Cells["B100"].Style.Font.Size = 30;
                ws.Cells["B100"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["B100"].Value = usersList[186];
                ws.Cells["B101"].Value = usersList[187];
                ws.Cells["B102"].Value = usersList[188];

                ws.Cells["C100"].Style.Font.Size = 30;
                ws.Cells["C100"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["C100"].Value = usersList[189];
                ws.Cells["C101"].Value = usersList[190];
                ws.Cells["C102"].Value = usersList[191];

                //---------------------------------------

                ws.Cells["A105"].Style.Font.Size = 30;
                ws.Cells["A105"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["A105"].Value = usersList[192];
                ws.Cells["A106"].Value = usersList[193];
                ws.Cells["A107"].Value = usersList[194];

                ws.Cells["B105"].Style.Font.Size = 30;
                ws.Cells["B105"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["B105"].Value = usersList[195];
                ws.Cells["B106"].Value = usersList[196];
                ws.Cells["B107"].Value = usersList[197];

                ws.Cells["C105"].Style.Font.Size = 30;
                ws.Cells["C105"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["C105"].Value = usersList[198];
                ws.Cells["C106"].Value = usersList[199];
                ws.Cells["C107"].Value = usersList[200];

                //---------------------------------------

                ws.Cells["A110"].Style.Font.Size = 30;
                ws.Cells["A110"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["A110"].Value = usersList[201];
                ws.Cells["A111"].Value = usersList[202];
                ws.Cells["A112"].Value = usersList[203];

                ws.Cells["B110"].Style.Font.Size = 30;
                ws.Cells["B110"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["B110"].Value = usersList[204];
                ws.Cells["B111"].Value = usersList[205];
                ws.Cells["B112"].Value = usersList[206];

                ws.Cells["C110"].Style.Font.Size = 30;
                ws.Cells["C110"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["C110"].Value = usersList[207];
                ws.Cells["C111"].Value = usersList[208];
                ws.Cells["C112"].Value = usersList[209];

                //---------------------------------------

                ws.Cells["A115"].Style.Font.Size = 30;
                ws.Cells["A115"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["A115"].Value = usersList[210];
                ws.Cells["A116"].Value = usersList[211];
                ws.Cells["A117"].Value = usersList[212];

                ws.Cells["B115"].Style.Font.Size = 30;
                ws.Cells["B115"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["B115"].Value = usersList[213];
                ws.Cells["B116"].Value = usersList[214];
                ws.Cells["B117"].Value = usersList[215];

                ws.Cells["C115"].Style.Font.Size = 30;
                ws.Cells["C115"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["C115"].Value = usersList[216];
                ws.Cells["C116"].Value = usersList[217];
                ws.Cells["C117"].Value = usersList[218];

                //---------------------------------------

                ws.Cells["A120"].Style.Font.Size = 30;
                ws.Cells["A120"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["A120"].Value = usersList[219];
                ws.Cells["A121"].Value = usersList[220];
                ws.Cells["A122"].Value = usersList[221];

                ws.Cells["B120"].Style.Font.Size = 30;
                ws.Cells["B120"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["B120"].Value = usersList[222];
                ws.Cells["B121"].Value = usersList[223];
                ws.Cells["B122"].Value = usersList[224];

                ws.Cells["C120"].Style.Font.Size = 30;
                ws.Cells["C120"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["C120"].Value = usersList[225];
                ws.Cells["C121"].Value = usersList[226];
                ws.Cells["C122"].Value = usersList[227];

                //---------------------------------------

                ws.Cells["A123"].Style.Font.Size = 30;
                ws.Cells["A123"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["A123"].Value = usersList[228];
                ws.Cells["A124"].Value = usersList[229];
                ws.Cells["A125"].Value = usersList[230];

                ws.Cells["B123"].Style.Font.Size = 30;
                ws.Cells["B123"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["B123"].Value = usersList[231];
                ws.Cells["B124"].Value = usersList[232];
                ws.Cells["B125"].Value = usersList[233];

                ws.Cells["C123"].Style.Font.Size = 30;
                ws.Cells["C123"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["C123"].Value = usersList[234];
                ws.Cells["C124"].Value = usersList[235];
                ws.Cells["C125"].Value = usersList[236];

                //---------------------------------------

                ws.Cells["A128"].Style.Font.Size = 30;
                ws.Cells["A128"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["A128"].Value = usersList[237];
                ws.Cells["A129"].Value = usersList[238];
                ws.Cells["A130"].Value = usersList[239];

                ws.Cells["B128"].Style.Font.Size = 30;
                ws.Cells["B128"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["B128"].Value = usersList[240];
                ws.Cells["B129"].Value = usersList[241];
                ws.Cells["B130"].Value = usersList[242];

                ws.Cells["C128"].Style.Font.Size = 30;
                ws.Cells["C128"].Style.Font.Name = "Free 3 of 9 Extended";
                ws.Cells["C128"].Value = usersList[243];
                ws.Cells["C129"].Value = usersList[244];
                ws.Cells["C130"].Value = usersList[245];

                //---------------------------------------


            }

            catch
            {
                Console.WriteLine("{0} entry(s) written!",usersList.Count);
            }

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

