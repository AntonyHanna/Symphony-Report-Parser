using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SymphonyReportParser.Models
{
	public class User
	{
		public static List<User> Users = new List<User>();

		public string Id { get; }
		public string FullName { get; }
		public string UserName { get; set; }

		public User(string id, string fullName, string userName)
		{
			this.Id = id;
			this.FullName = fullName;
			this.UserName = userName;
		}
		public static void ParseUsersFromReport(string[] report)
		{
			foreach (string reportEntry in report)
			{
				// Only lines containing '|' are proper entries
				if (!reportEntry.Contains('|'))
					return;

				string[] data = reportEntry.Split('|', StringSplitOptions.RemoveEmptyEntries);

				for (int i = 0; i < data.Count(); i++)
				{
					// Remove trailing whitespace
					data[i] = Regex.Replace(data[i], @"[^A-z] {1,}", "");
				}

				Users.Add(new User(data[0], data[1], data[2]));
			}
		}
	}
}
