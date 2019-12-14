using Microsoft.Win32;
using SymphonyReportParser.Models;
using System;
using System.Windows;
using System.Windows.Controls;

namespace SymphonyReportParser
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			this.GenerateButton.IsEnabled = false;
		}
		private void BrowseButton_Click(object sender, RoutedEventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog
			{
				Title = "Open Report",
				Filter = "txt files (*.txt) | *.txt"
			};

			if ((bool)dialog.ShowDialog())
				this.ReportLocation.Text = dialog.FileName;
		}
		private void GenerateButton_Click(object sender, RoutedEventArgs e)
		{
			ReportProcessor processor = new ReportProcessor(this.ReportLocation.Text, Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\");

			string[] reportContent = processor.ReadReport();

			reportContent = ReportProcessor.RemoveIrrelevantLines(reportContent);
			User.ParseUsersFromReport(reportContent);

			processor.WriteUsersToFile(User.Users);

			this.savedPrompt.Text = $"Saved in: {processor.SaveLocation}{processor.FileName}";
		}

		private void ReportLocation_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (string.IsNullOrEmpty(this.ReportLocation.Text))
				this.GenerateButton.IsEnabled = false;
			else
				this.GenerateButton.IsEnabled = true;
		}
	}
}
