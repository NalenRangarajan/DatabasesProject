using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTracking.Models
{
	public class Profile
	{
		public int ProfileID { get; set; }

		public string Username { get; set; }

		public string HashedPassword { get; set; }

		public Profile(int pID, string u, string p)
		{
			ProfileID = pID;
			Username = u;
			HashedPassword = p;
		}
	}
}
