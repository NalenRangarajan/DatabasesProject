using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTracking.Models
{
	public class Person
	{
		public int PersonID { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public Person(int pID, string f, string l)
		{
			PersonID = pID;
			FirstName = f;
			LastName = l;
		}
	}
}
