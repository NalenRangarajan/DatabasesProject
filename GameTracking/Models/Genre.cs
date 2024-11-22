using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTracking.Models
{
	public class Genre
	{
		public int GenreID { get; set; }

		public string Name { get; set; }

		public Genre(int gID, string n)
		{
			GenreID = gID;
			Name = n;
		}

		public override string ToString()
		{
			return Name;
		}
	}
}
