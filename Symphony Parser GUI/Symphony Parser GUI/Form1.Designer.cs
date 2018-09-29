namespace Symphony_Parser_GUI_
{
    partial class Barcode_Generator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Barcode_Generator));
            this.title_Label = new System.Windows.Forms.Label();
            this.reportLocation_TextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.reportLocation_Label = new System.Windows.Forms.Label();
            this.reportLocation_Button = new System.Windows.Forms.Button();
            this.outputLocation_Button = new System.Windows.Forms.Button();
            this.outputLocation_Label = new System.Windows.Forms.Label();
            this.outputLocation_TextBox = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.class_Label = new System.Windows.Forms.Label();
            this.class_TextBox = new System.Windows.Forms.TextBox();
            this.outputDirectoryErrorLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.settings_Button = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.exit_Button = new System.Windows.Forms.PictureBox();
            this.fileDirectoryErrorLabel = new System.Windows.Forms.Label();
            this.classErrorLabel = new System.Windows.Forms.Label();
            this.status_Label = new System.Windows.Forms.Label();
            this.statusOutput_Label = new System.Windows.Forms.Label();
            this.studentsOnFile_Label = new System.Windows.Forms.Label();
            this.studentOnFileResult_Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settings_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_Button)).BeginInit();
            this.SuspendLayout();
            // 
            // title_Label
            // 
            this.title_Label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_Label.ForeColor = System.Drawing.Color.Gray;
            this.title_Label.Location = new System.Drawing.Point(8, 9);
            this.title_Label.Name = "title_Label";
            this.title_Label.Size = new System.Drawing.Size(237, 21);
            this.title_Label.TabIndex = 0;
            this.title_Label.Text = "Symphony Barcode Generator";
            // 
            // reportLocation_TextBox
            // 
            this.reportLocation_TextBox.Location = new System.Drawing.Point(12, 143);
            this.reportLocation_TextBox.Name = "reportLocation_TextBox";
            this.reportLocation_TextBox.Size = new System.Drawing.Size(211, 20);
            this.reportLocation_TextBox.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // reportLocation_Label
            // 
            this.reportLocation_Label.AutoSize = true;
            this.reportLocation_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportLocation_Label.Location = new System.Drawing.Point(12, 124);
            this.reportLocation_Label.Name = "reportLocation_Label";
            this.reportLocation_Label.Size = new System.Drawing.Size(98, 13);
            this.reportLocation_Label.TabIndex = 4;
            this.reportLocation_Label.Text = "Report Location";
            // 
            // reportLocation_Button
            // 
            this.reportLocation_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportLocation_Button.Location = new System.Drawing.Point(229, 141);
            this.reportLocation_Button.Name = "reportLocation_Button";
            this.reportLocation_Button.Size = new System.Drawing.Size(75, 23);
            this.reportLocation_Button.TabIndex = 5;
            this.reportLocation_Button.Text = "Browse";
            this.reportLocation_Button.UseVisualStyleBackColor = true;
            this.reportLocation_Button.Click += new System.EventHandler(this.reportLocation_Button_Click);
            // 
            // outputLocation_Button
            // 
            this.outputLocation_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outputLocation_Button.Location = new System.Drawing.Point(229, 213);
            this.outputLocation_Button.Name = "outputLocation_Button";
            this.outputLocation_Button.Size = new System.Drawing.Size(75, 23);
            this.outputLocation_Button.TabIndex = 8;
            this.outputLocation_Button.Text = "Browse";
            this.outputLocation_Button.UseVisualStyleBackColor = true;
            this.outputLocation_Button.Click += new System.EventHandler(this.outputLocation_Button_Click);
            // 
            // outputLocation_Label
            // 
            this.outputLocation_Label.AutoSize = true;
            this.outputLocation_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLocation_Label.Location = new System.Drawing.Point(12, 196);
            this.outputLocation_Label.Name = "outputLocation_Label";
            this.outputLocation_Label.Size = new System.Drawing.Size(98, 13);
            this.outputLocation_Label.TabIndex = 7;
            this.outputLocation_Label.Text = "Output Location";
            // 
            // outputLocation_TextBox
            // 
            this.outputLocation_TextBox.Location = new System.Drawing.Point(12, 215);
            this.outputLocation_TextBox.Name = "outputLocation_TextBox";
            this.outputLocation_TextBox.Size = new System.Drawing.Size(211, 20);
            this.outputLocation_TextBox.TabIndex = 6;
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
            // class_Label
            // 
            this.class_Label.AutoSize = true;
            this.class_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_Label.Location = new System.Drawing.Point(12, 56);
            this.class_Label.Name = "class_Label";
            this.class_Label.Size = new System.Drawing.Size(37, 13);
            this.class_Label.TabIndex = 11;
            this.class_Label.Text = "Class";
            // 
            // class_TextBox
            // 
            this.class_TextBox.Location = new System.Drawing.Point(12, 75);
            this.class_TextBox.Name = "class_TextBox";
            this.class_TextBox.Size = new System.Drawing.Size(120, 20);
            this.class_TextBox.TabIndex = 10;
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
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.settings_Button);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.exit_Button);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(373, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(55, 412);
            this.panel2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(7, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 1);
            this.label1.TabIndex = 24;
            // 
            // settings_Button
            // 
            this.settings_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settings_Button.Image = ((System.Drawing.Image)(resources.GetObject("settings_Button.Image")));
            this.settings_Button.Location = new System.Drawing.Point(18, 60);
            this.settings_Button.Name = "settings_Button";
            this.settings_Button.Size = new System.Drawing.Size(19, 18);
            this.settings_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.settings_Button.TabIndex = 23;
            this.settings_Button.TabStop = false;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(7, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 1);
            this.label3.TabIndex = 22;
            // 
            // exit_Button
            // 
            this.exit_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_Button.Image = ((System.Drawing.Image)(resources.GetObject("exit_Button.Image")));
            this.exit_Button.Location = new System.Drawing.Point(11, 7);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(34, 34);
            this.exit_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exit_Button.TabIndex = 21;
            this.exit_Button.TabStop = false;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
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
            // status_Label
            // 
            this.status_Label.AutoSize = true;
            this.status_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_Label.Location = new System.Drawing.Point(12, 308);
            this.status_Label.Name = "status_Label";
            this.status_Label.Size = new System.Drawing.Size(51, 13);
            this.status_Label.TabIndex = 17;
            this.status_Label.Text = "Status: ";
            // 
            // statusOutput_Label
            // 
            this.statusOutput_Label.AutoSize = true;
            this.statusOutput_Label.Location = new System.Drawing.Point(57, 308);
            this.statusOutput_Label.Name = "statusOutput_Label";
            this.statusOutput_Label.Size = new System.Drawing.Size(84, 13);
            this.statusOutput_Label.TabIndex = 18;
            this.statusOutput_Label.Text = "Waiting to begin";
            // 
            // studentsOnFile_Label
            // 
            this.studentsOnFile_Label.AutoSize = true;
            this.studentsOnFile_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsOnFile_Label.Location = new System.Drawing.Point(12, 264);
            this.studentsOnFile_Label.Name = "studentsOnFile_Label";
            this.studentsOnFile_Label.Size = new System.Drawing.Size(107, 13);
            this.studentsOnFile_Label.TabIndex = 19;
            this.studentsOnFile_Label.Text = "Students on File: ";
            // 
            // studentOnFileResult_Label
            // 
            this.studentOnFileResult_Label.AutoSize = true;
            this.studentOnFileResult_Label.Location = new System.Drawing.Point(109, 264);
            this.studentOnFileResult_Label.Name = "studentOnFileResult_Label";
            this.studentOnFileResult_Label.Size = new System.Drawing.Size(10, 13);
            this.studentOnFileResult_Label.TabIndex = 20;
            this.studentOnFileResult_Label.Text = " ";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            // 
            // Barcode_Generator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(428, 412);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.title_Label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.studentOnFileResult_Label);
            this.Controls.Add(this.studentsOnFile_Label);
            this.Controls.Add(this.statusOutput_Label);
            this.Controls.Add(this.status_Label);
            this.Controls.Add(this.classErrorLabel);
            this.Controls.Add(this.fileDirectoryErrorLabel);
            this.Controls.Add(this.outputDirectoryErrorLabel);
            this.Controls.Add(this.class_Label);
            this.Controls.Add(this.class_TextBox);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.outputLocation_Button);
            this.Controls.Add(this.outputLocation_Label);
            this.Controls.Add(this.outputLocation_TextBox);
            this.Controls.Add(this.reportLocation_Button);
            this.Controls.Add(this.reportLocation_Label);
            this.Controls.Add(this.reportLocation_TextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Barcode_Generator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkFlows Barcode Generator";
            this.Load += new System.EventHandler(this.Symphony_Barcode_Generator_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Symphony_Barcode_Generator_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Symphony_Barcode_Generator_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Symphony_Barcode_Generator_MouseUp);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.settings_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_Button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label title_Label;
        private System.Windows.Forms.TextBox reportLocation_TextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label reportLocation_Label;
        private System.Windows.Forms.Button reportLocation_Button;
        private System.Windows.Forms.Button outputLocation_Button;
        private System.Windows.Forms.Label outputLocation_Label;
        private System.Windows.Forms.TextBox outputLocation_TextBox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label class_Label;
        private System.Windows.Forms.TextBox class_TextBox;

        private System.Windows.Forms.Label outputDirectoryErrorLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label fileDirectoryErrorLabel;
        private System.Windows.Forms.Label classErrorLabel;
        private System.Windows.Forms.Label status_Label;
        private System.Windows.Forms.Label statusOutput_Label;
        private System.Windows.Forms.Label studentsOnFile_Label;
        private System.Windows.Forms.Label studentOnFileResult_Label;
        private System.Windows.Forms.PictureBox exit_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox settings_Button;
        private System.Windows.Forms.Label label1;
    }
}

