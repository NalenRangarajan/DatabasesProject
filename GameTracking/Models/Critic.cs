using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTracking.Models
{
	public class Critic
	{
		public int CriticID { get; set; }

		public string Website { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public Critic (int cID, string w, string f, string l)
		{
			CriticID = cID;
			Website = w;
			FirstName = f;
			LastName = l;
		}
	}
}
