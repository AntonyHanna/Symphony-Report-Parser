namespace Symphony_Parser_GUI_
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.fileDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitButton = new System.Windows.Forms.Button();
            this.ReportDirectoryLabel = new System.Windows.Forms.Label();
            this.reportDirectoryBrowseButton = new System.Windows.Forms.Button();
            this.outputDirectoryBrowse = new System.Windows.Forms.Button();
            this.outputDirectoryLabel = new System.Windows.Forms.Label();
            this.outputDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.gradeTextBox = new System.Windows.Forms.TextBox();
            this.outputDirectoryErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 479);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(146, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Symphony Barcode Generator";
            // 
            // fileDirectoryTextBox
            // 
            this.fileDirectoryTextBox.Location = new System.Drawing.Point(124, 146);
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
            // exitButton
            // 
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(341, 444);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ReportDirectoryLabel
            // 
            this.ReportDirectoryLabel.AutoSize = true;
            this.ReportDirectoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportDirectoryLabel.Location = new System.Drawing.Point(124, 127);
            this.ReportDirectoryLabel.Name = "ReportDirectoryLabel";
            this.ReportDirectoryLabel.Size = new System.Drawing.Size(98, 13);
            this.ReportDirectoryLabel.TabIndex = 4;
            this.ReportDirectoryLabel.Text = "Report Location";
            // 
            // reportDirectoryBrowseButton
            // 
            this.reportDirectoryBrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportDirectoryBrowseButton.Location = new System.Drawing.Point(341, 144);
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
            this.outputDirectoryBrowse.Location = new System.Drawing.Point(341, 216);
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
            this.outputDirectoryLabel.Location = new System.Drawing.Point(124, 199);
            this.outputDirectoryLabel.Name = "outputDirectoryLabel";
            this.outputDirectoryLabel.Size = new System.Drawing.Size(98, 13);
            this.outputDirectoryLabel.TabIndex = 7;
            this.outputDirectoryLabel.Text = "Output Location";
            // 
            // outputDirectoryTextBox
            // 
            this.outputDirectoryTextBox.Location = new System.Drawing.Point(124, 218);
            this.outputDirectoryTextBox.Name = "outputDirectoryTextBox";
            this.outputDirectoryTextBox.Size = new System.Drawing.Size(211, 20);
            this.outputDirectoryTextBox.TabIndex = 6;
            this.outputDirectoryTextBox.TextChanged += new System.EventHandler(this.outputDirectoryTextBox_TextChanged);
            // 
            // generateButton
            // 
            this.generateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateButton.Location = new System.Drawing.Point(116, 444);
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
            this.gradeLabel.Location = new System.Drawing.Point(124, 56);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(37, 13);
            this.gradeLabel.TabIndex = 11;
            this.gradeLabel.Text = "Class";
            // 
            // gradeTextBox
            // 
            this.gradeTextBox.Location = new System.Drawing.Point(124, 75);
            this.gradeTextBox.Name = "gradeTextBox";
            this.gradeTextBox.Size = new System.Drawing.Size(120, 20);
            this.gradeTextBox.TabIndex = 10;
            // 
            // outputDirectoryErrorLabel
            // 
            this.outputDirectoryErrorLabel.AutoSize = true;
            this.outputDirectoryErrorLabel.Location = new System.Drawing.Point(124, 241);
            this.outputDirectoryErrorLabel.Name = "outputDirectoryErrorLabel";
            this.outputDirectoryErrorLabel.Size = new System.Drawing.Size(10, 13);
            this.outputDirectoryErrorLabel.TabIndex = 13;
            this.outputDirectoryErrorLabel.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(428, 479);
            this.Controls.Add(this.outputDirectoryErrorLabel);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.gradeTextBox);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.outputDirectoryBrowse);
            this.Controls.Add(this.outputDirectoryLabel);
            this.Controls.Add(this.outputDirectoryTextBox);
            this.Controls.Add(this.reportDirectoryBrowseButton);
            this.Controls.Add(this.ReportDirectoryLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.fileDirectoryTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fileDirectoryTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label ReportDirectoryLabel;
        private System.Windows.Forms.Button reportDirectoryBrowseButton;
        private System.Windows.Forms.Button outputDirectoryBrowse;
        private System.Windows.Forms.Label outputDirectoryLabel;
        private System.Windows.Forms.TextBox outputDirectoryTextBox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.TextBox gradeTextBox;

        private System.Windows.Forms.Label outputDirectoryErrorLabel;
    }
}

