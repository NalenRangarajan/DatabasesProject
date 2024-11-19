using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTracking.Models
{
	public class Publisher
	{
		public int PublisherID { get; set; }

		public string Name { get; set; }

		public DateTime? FoundedDate { get; set; }

		public string? Location { get; set; }

		public string? Website { get; set; }	

		public int? EmployeeCount { get; set; }

		public Publisher(int pID, string n, DateTime fd, string l, string w, int ec)
		{
			PublisherID = pID;
			Name = n;
			FoundedDate = fd;
			Location = l;
			Website = w;
			EmployeeCount = ec;
		}
	}
}
