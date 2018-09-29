using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Style;


namespace Symphony_Parser_GUI_
{
    public partial class Barcode_Generator : Form
    {
        public Barcode_Generator()
        {
            InitializeComponent();
        }

        private void reportLocation_Button_Click(object sender, EventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();

            dialog.DefaultExt = ".txt";
            dialog.Filter = "Text files (*.txt) |*.txt";

            Nullable<bool> result = dialog.ShowDialog();

            if(result == true)
            {
                string fileName = dialog.FileName;
                reportLocation_TextBox.Text = fileName;
            }
        }

        private void outputLocation_Button_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string folderPath = fbd.SelectedPath + @"\";
                    outputLocation_TextBox.Text = fbd.SelectedPath + @"\";
                }
            }   
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            classErrorLabel.Text = " ";
            fileDirectoryErrorLabel.Text = " ";
            outputDirectoryErrorLabel.Text = " ";

            if (string.IsNullOrWhiteSpace(class_TextBox.Text) || string.IsNullOrWhiteSpace(reportLocation_TextBox.Text) || string.IsNullOrWhiteSpace(outputLocation_TextBox.Text))
            {
                if (string.IsNullOrWhiteSpace(class_TextBox.Text))
                {
                    classErrorLabel.ForeColor = Color.Red;
                    if (string.IsNullOrWhiteSpace(classErrorLabel.Text))
                    {
                        classErrorLabel.Text = "* Do not leave class name empty!";
                        classErrorLabel.Refresh();
                    }
                }

                if (string.IsNullOrWhiteSpace(reportLocation_TextBox.Text))
                {
                    fileDirectoryErrorLabel.ForeColor = Color.Red;
                    if (string.IsNullOrWhiteSpace(fileDirectoryErrorLabel.Text))
                    {
                        fileDirectoryErrorLabel.Text = "* Do not leave file location empty!";
                        fileDirectoryErrorLabel.Refresh();
                    }
                }

                if (string.IsNullOrWhiteSpace(outputLocation_TextBox.Text))
                {
                    outputDirectoryErrorLabel.ForeColor = Color.Red;
                    if (string.IsNullOrWhiteSpace(outputDirectoryErrorLabel.Text))
                    {
                        outputDirectoryErrorLabel.Text = "* Do not leave output location empty!";
                        outputDirectoryErrorLabel.Refresh();
                    }
                }
                System.Windows.MessageBox.Show("Please don't leave any fields empty!");
                    return;
            }

            string className = class_TextBox.Text;
            string filePath = reportLocation_TextBox.Text;
            string outputString = outputLocation_TextBox.Text;
            string outputDirectory = outputString + className + " - " + DateTime.Now.ToString("dddd, dd MMMM yyyy") + ".xlsx";
            FileInfo outputFilePath = new FileInfo(outputDirectory);

            statusOutput_Label.Text = "Preparing Sheet";
            statusOutput_Label.Refresh();

            Start(filePath, outputFilePath, outputDirectory, className, outputDirectoryErrorLabel, fileDirectoryErrorLabel, classErrorLabel, statusOutput_Label, studentOnFileResult_Label);

            System.Windows.MessageBox.Show("Barcode Report has been generated.");

            statusOutput_Label.Text = "Waiting to continue";
            statusOutput_Label.Refresh();

            
        }

        static void Start(string filePath, FileInfo outputFilePath, string outputDirectory, string className, 
                            Label outputDirectoryErrorLabel, Label fileDirectoryErrorLabel, Label classErrorLabel, Label statusOutputLabel, Label studentLabelCounter)
        {
            ReadReport(filePath, outputFilePath, outputDirectory, className, outputDirectoryErrorLabel, fileDirectoryErrorLabel, classErrorLabel, statusOutputLabel, studentLabelCounter);
        }

        public static void ReadReport(string reportPath, FileInfo outputDirectory, string outputString, string className, 
                                        Label outputDirectoryErrorLabel, Label fileDirectoryErrorLabel, Label classErrorLabel, Label statusOutputLabel, Label studentLabelCounter)
        {
            List<string> usersList = new List<string>();

            try
            {
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
                                statusOutputLabel.Text = data;
                            }
                        }
                    }
                    statusOutputLabel.Text = "Data has been read!";
                    statusOutputLabel.Refresh();
                }
                FileExists(outputDirectory, outputString, statusOutputLabel);
                WriteToFile(outputDirectory, usersList, className, statusOutputLabel, studentLabelCounter);
            }

            catch
            {
                return;
            }
        }
        
        public static void WriteToFile(FileInfo outputDirectory, List<string> usersList, string className, Label statusOutputLabel, Label studentLabelCounter)
        {
            using (ExcelPackage excel = new ExcelPackage(outputDirectory))
            {
                statusOutputLabel.Text = "File is being created.";
                statusOutputLabel.Refresh();
                var ws = excel.Workbook.Worksheets.Add("Barcode Report");
                statusOutputLabel.Text = "Users are being written to file.";
                statusOutputLabel.Refresh();

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

                foreach (string data in usersList)
                {
                    if (rowCounter == 4)
                    {
                        Row = Row - 3;
                        rowCounter = 1;
                        Column++;
                        colCounter++;
                    }

                    if (colCounter == 4)
                    {
                        colCounter = 1;
                        Column = 1;
                        Row = Row + 4;
                    }

                    ws.Row(idRow).Style.Font.Size = 30;
                    ws.Row(idRow).Style.Font.Name = "Free 3 of 9 Extended";
                    ws.Cells[Row, Column].Value = data;
                    Row++;
                    rowCounter++;
                    idRow = idRow + 4;
                    statusOutputLabel.Text = data;
                    statusOutputLabel.Refresh();
                }
                Whitespace();

                studentLabelCounter.Text = (usersList.Count / 3).ToString();
                studentLabelCounter.Refresh();

                fitPageBreakToPage(ws, usersList, statusOutputLabel);
                AddPageHeaders(ws, className, statusOutputLabel);
                WorkSheetProperties(ws, statusOutputLabel);

                excel.SaveAs(outputDirectory);
            }
        }

        static void fitPageBreakToPage(ExcelWorksheet ws, List<string> userList, Label statusOutputLabel)
        {
            //Remove all Page Breaks
            for (int i = 1; i <= userList.Count + userList.Count / 3; i++)
            {
                ws.Row(i).PageBreak = false;
                ws.Column(i).PageBreak = false;
            }

            //Header to Content Gap
            ws.InsertRow(1, 1);

            //Create a page break at the end of every page
            //Delete the Blank row (i) as it creates an empty row
            //WARNING: If anything is resized then you'll likely have to update these values to fit everything again
            for (int i = 36; i <= userList.Count + userList.Count / 3; i += 36)
            {
                ws.Row(i).PageBreak = true;   
            }

            ws.Column(3).PageBreak = true;
        }

        static void AddPageHeaders(ExcelWorksheet ws, string className, Label statusOutputLabel)
        {
           ws.HeaderFooter.AlignWithMargins = true;
           ws.HeaderFooter.EvenHeader.CenteredText = "&28&\"Arial,Regular Bold\"" + className + " - Barcodes";
           ws.HeaderFooter.OddHeader.CenteredText = "&28&\"Arial,Regular Bold\"" + className + " - Barcodes";
        }

        static void WorkSheetProperties(ExcelWorksheet ws, Label statusOutputLabel)
        {
            ws.View.PageLayoutView = true;
            ws.PrinterSettings.PaperSize = ePaperSize.A4;
            ws.PrinterSettings.FitToPage = false;

            //Wide Margins
            ws.PrinterSettings.LeftMargin = 1m;
            ws.PrinterSettings.RightMargin = 1m;
            ws.PrinterSettings.TopMargin = 1m;
            ws.PrinterSettings.BottomMargin = 1m;
            ws.PrinterSettings.HeaderMargin = .65m;
            ws.PrinterSettings.FooterMargin = .65m;
        }

        public static void FileExists(FileInfo outputDirectory, string outputString, Label statusOutputLabel)
        {
            
            if (outputDirectory.Exists)
            {
                try
                {
                    File.Delete(outputString);
                }

                catch
                {
                    System.Windows.MessageBox.Show("Please close down the excel sheet before trying to generate more barcodes.");
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

        public void Symphony_Barcode_Generator_Load(object sender, EventArgs e)
        {
          
        }

        private bool mouseDown;
        private Point lastLocation;

        private void Symphony_Barcode_Generator_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Symphony_Barcode_Generator_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X,
                                          (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void Symphony_Barcode_Generator_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}



