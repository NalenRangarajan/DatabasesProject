using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTracking.Models
{
	public class Developer
	{
		public int DeveloperID { get; set; }

		public string Name { get; set; }

		public string Website { get; set; }

		public DateTime FoundedDate { get; set; }

		public string Location { get; set; }

		public int TeamCount { get; set; }

		public Developer(int dID, string n, string w, DateTime fd, string l, int tc)
		{
			DeveloperID = dID;
			Name = n;
			Website = w;
			FoundedDate = fd;
			Location = l;
			TeamCount = tc;
		}
	}
}
