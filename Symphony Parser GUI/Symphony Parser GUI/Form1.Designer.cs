namespace Symphony_Parser_GUI_
{
    partial class Symphony_Barcode_Generator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.fileDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ReportDirectoryLabel = new System.Windows.Forms.Label();
            this.reportDirectoryBrowseButton = new System.Windows.Forms.Button();
            this.outputDirectoryBrowse = new System.Windows.Forms.Button();
            this.outputDirectoryLabel = new System.Windows.Forms.Label();
            this.outputDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.classTextBox = new System.Windows.Forms.TextBox();
            this.outputDirectoryErrorLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fileDirectoryErrorLabel = new System.Windows.Forms.Label();
            this.classErrorLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusOutputLabel = new System.Windows.Forms.Label();
            this.studentsLabel = new System.Windows.Forms.Label();
            this.studentLabelCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Symphony Barcode Generator";
            // 
            // fileDirectoryTextBox
            // 
            this.fileDirectoryTextBox.Location = new System.Drawing.Point(12, 143);
            this.fileDirectoryTextBox.Name = "fileDirectoryTextBox";
            this.fileDirectoryTextBox.Size = new System.Drawing.Size(211, 20);
            this.fileDirectoryTextBox.TabIndex = 1;
            this.fileDirectoryTextBox.TextChanged += new System.EventHandler(this.fileDirectoryTextBox_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ReportDirectoryLabel
            // 
            this.ReportDirectoryLabel.AutoSize = true;
            this.ReportDirectoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportDirectoryLabel.Location = new System.Drawing.Point(12, 124);
            this.ReportDirectoryLabel.Name = "ReportDirectoryLabel";
            this.ReportDirectoryLabel.Size = new System.Drawing.Size(98, 13);
            this.ReportDirectoryLabel.TabIndex = 4;
            this.ReportDirectoryLabel.Text = "Report Location";
            // 
            // reportDirectoryBrowseButton
            // 
            this.reportDirectoryBrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportDirectoryBrowseButton.Location = new System.Drawing.Point(229, 141);
            this.reportDirectoryBrowseButton.Name = "reportDirectoryBrowseButton";
            this.reportDirectoryBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.reportDirectoryBrowseButton.TabIndex = 5;
            this.reportDirectoryBrowseButton.Text = "Browse";
            this.reportDirectoryBrowseButton.UseVisualStyleBackColor = true;
            this.reportDirectoryBrowseButton.Click += new System.EventHandler(this.reportDirectoryBrowseButton_Click);
            // 
            // outputDirectoryBrowse
            // 
            this.outputDirectoryBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outputDirectoryBrowse.Location = new System.Drawing.Point(229, 213);
            this.outputDirectoryBrowse.Name = "outputDirectoryBrowse";
            this.outputDirectoryBrowse.Size = new System.Drawing.Size(75, 23);
            this.outputDirectoryBrowse.TabIndex = 8;
            this.outputDirectoryBrowse.Text = "Browse";
            this.outputDirectoryBrowse.UseVisualStyleBackColor = true;
            this.outputDirectoryBrowse.Click += new System.EventHandler(this.outputDirectoryBrowse_Click);
            // 
            // outputDirectoryLabel
            // 
            this.outputDirectoryLabel.AutoSize = true;
            this.outputDirectoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputDirectoryLabel.Location = new System.Drawing.Point(12, 196);
            this.outputDirectoryLabel.Name = "outputDirectoryLabel";
            this.outputDirectoryLabel.Size = new System.Drawing.Size(98, 13);
            this.outputDirectoryLabel.TabIndex = 7;
            this.outputDirectoryLabel.Text = "Output Location";
            // 
            // outputDirectoryTextBox
            // 
            this.outputDirectoryTextBox.Location = new System.Drawing.Point(12, 215);
            this.outputDirectoryTextBox.Name = "outputDirectoryTextBox";
            this.outputDirectoryTextBox.Size = new System.Drawing.Size(211, 20);
            this.outputDirectoryTextBox.TabIndex = 6;
            this.outputDirectoryTextBox.TextChanged += new System.EventHandler(this.outputDirectoryTextBox_TextChanged);
            // 
            // generateButton
            // 
            this.generateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateButton.Location = new System.Drawing.Point(12, 368);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(129, 23);
            this.generateButton.TabIndex = 9;
            this.generateButton.Text = "Generate Barcodes";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeLabel.Location = new System.Drawing.Point(12, 56);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(37, 13);
            this.gradeLabel.TabIndex = 11;
            this.gradeLabel.Text = "Class";
            // 
            // classTextBox
            // 
            this.classTextBox.Location = new System.Drawing.Point(12, 75);
            this.classTextBox.Name = "classTextBox";
            this.classTextBox.Size = new System.Drawing.Size(120, 20);
            this.classTextBox.TabIndex = 10;
            // 
            // outputDirectoryErrorLabel
            // 
            this.outputDirectoryErrorLabel.AutoSize = true;
            this.outputDirectoryErrorLabel.Location = new System.Drawing.Point(12, 238);
            this.outputDirectoryErrorLabel.Name = "outputDirectoryErrorLabel";
            this.outputDirectoryErrorLabel.Size = new System.Drawing.Size(10, 13);
            this.outputDirectoryErrorLabel.TabIndex = 13;
            this.outputDirectoryErrorLabel.Text = " ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(373, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(55, 412);
            this.panel2.TabIndex = 14;
            // 
            // fileDirectoryErrorLabel
            // 
            this.fileDirectoryErrorLabel.AutoSize = true;
            this.fileDirectoryErrorLabel.Location = new System.Drawing.Point(12, 166);
            this.fileDirectoryErrorLabel.Name = "fileDirectoryErrorLabel";
            this.fileDirectoryErrorLabel.Size = new System.Drawing.Size(10, 13);
            this.fileDirectoryErrorLabel.TabIndex = 15;
            this.fileDirectoryErrorLabel.Text = " ";
            // 
            // classErrorLabel
            // 
            this.classErrorLabel.AutoSize = true;
            this.classErrorLabel.Location = new System.Drawing.Point(12, 98);
            this.classErrorLabel.Name = "classErrorLabel";
            this.classErrorLabel.Size = new System.Drawing.Size(10, 13);
            this.classErrorLabel.TabIndex = 16;
            this.classErrorLabel.Text = " ";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(12, 308);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(51, 13);
            this.statusLabel.TabIndex = 17;
            this.statusLabel.Text = "Status: ";
            // 
            // statusOutputLabel
            // 
            this.statusOutputLabel.AutoSize = true;
            this.statusOutputLabel.Location = new System.Drawing.Point(57, 308);
            this.statusOutputLabel.Name = "statusOutputLabel";
            this.statusOutputLabel.Size = new System.Drawing.Size(84, 13);
            this.statusOutputLabel.TabIndex = 18;
            this.statusOutputLabel.Text = "Waiting to begin";
            // 
            // studentsLabel
            // 
            this.studentsLabel.AutoSize = true;
            this.studentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsLabel.Location = new System.Drawing.Point(12, 264);
            this.studentsLabel.Name = "studentsLabel";
            this.studentsLabel.Size = new System.Drawing.Size(107, 13);
            this.studentsLabel.TabIndex = 19;
            this.studentsLabel.Text = "Students on File: ";
            // 
            // studentLabelCounter
            // 
            this.studentLabelCounter.AutoSize = true;
            this.studentLabelCounter.Location = new System.Drawing.Point(109, 264);
            this.studentLabelCounter.Name = "studentLabelCounter";
            this.studentLabelCounter.Size = new System.Drawing.Size(10, 13);
            this.studentLabelCounter.TabIndex = 20;
            this.studentLabelCounter.Text = " ";
            // 
            // Symphony_Barcode_Generator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(428, 412);
            this.Controls.Add(this.studentLabelCounter);
            this.Controls.Add(this.studentsLabel);
            this.Controls.Add(this.statusOutputLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.classErrorLabel);
            this.Controls.Add(this.fileDirectoryErrorLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.outputDirectoryErrorLabel);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.classTextBox);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.outputDirectoryBrowse);
            this.Controls.Add(this.outputDirectoryLabel);
            this.Controls.Add(this.outputDirectoryTextBox);
            this.Controls.Add(this.reportDirectoryBrowseButton);
            this.Controls.Add(this.ReportDirectoryLabel);
            this.Controls.Add(this.fileDirectoryTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Symphony_Barcode_Generator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Workflows Barcode Generator";
            this.Load += new System.EventHandler(this.Symphony_Barcode_Generator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fileDirectoryTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label ReportDirectoryLabel;
        private System.Windows.Forms.Button reportDirectoryBrowseButton;
        private System.Windows.Forms.Button outputDirectoryBrowse;
        private System.Windows.Forms.Label outputDirectoryLabel;
        private System.Windows.Forms.TextBox outputDirectoryTextBox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.TextBox classTextBox;

        private System.Windows.Forms.Label outputDirectoryErrorLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label fileDirectoryErrorLabel;
        private System.Windows.Forms.Label classErrorLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label statusOutputLabel;
        private System.Windows.Forms.Label studentsLabel;
        private System.Windows.Forms.Label studentLabelCounter;
    }
}

