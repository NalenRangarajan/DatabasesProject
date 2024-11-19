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

		public Game(int gID, int pID, string n, DateTime rd)
		{
			GameID = gID;
			PublisherID = pID;
			Name = n;
			ReleaseDate = rd;
		}
	}
}
