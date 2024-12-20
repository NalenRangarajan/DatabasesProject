﻿using System;
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

		public decimal Score { get; set; }

		public string? Body { get; set; }

		public DateTime ReviewDate { get; set; }

		public Review(int rID, int gID, decimal s, string? b, DateTime rd)
		{
			ReviewID = rID;
			GameID = gID;
			Score = s;
			Body = b;
			ReviewDate = rd;
		}
	}
}
