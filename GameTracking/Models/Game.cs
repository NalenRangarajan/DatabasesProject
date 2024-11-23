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

		public double AverageScore { get; init; }

		public int ReviewCount { get; init; }

		public Game(int gID, int pID, string n, DateTime rd)
		{
			GameID = gID;
			PublisherID = pID;
			Name = n;
			ReleaseDate = rd;
		}

		public override bool Equals(object? obj)
		{
			Game other = (Game)obj!;
			return this.GameID == other.GameID;
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
	}
}
