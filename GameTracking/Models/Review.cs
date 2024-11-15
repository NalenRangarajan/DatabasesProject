using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTracking.Models
{
	public class Review
	{
		public int ReviewID { get; set; }

		public int GameID { get; set; }

		public int CriticID { get; set; }

		public int Score { get; set; }

		public string? Title { get; set; }

		public string? Body { get; set; }

		public DateTime ReviewDate { get; set; }

		public Review(int rID, int gID, int cID, int s, string t, string b, DateTime rd)
		{
			ReviewID = rID;
			GameID = gID;
			CriticID = cID;
			Score = s;
			Title = t;
			Body = b;
			ReviewDate = rd;
		}
	}
}
