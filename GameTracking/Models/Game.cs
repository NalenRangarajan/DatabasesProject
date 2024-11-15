using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTracking.Models
{
	public class Game
	{
		public int GameID { get; set; }

		public int PublisherID { get; set; }

		public string Name { get; set; }

		public DateTime ReleaseDate { get; set; }

		public string Genre { get; set; }

		public string Platform { get; set; }

		public Game(int gID, int pID, string n, DateTime rd, string g, string p)
		{
			GameID = gID;
			PublisherID = pID;
			Name = n;
			ReleaseDate = rd;
			Genre = g;
			Platform = p;
		}
	}
}
