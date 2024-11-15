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

		public string Password { get; set; }

		public DateTime CreatedOn { get; set; }

		public Profile(int pID, string u, string p, DateTime co)
		{
			ProfileID = pID;
			Username = u;
			Password = p;
			CreatedOn = co;
		}
	}
}
