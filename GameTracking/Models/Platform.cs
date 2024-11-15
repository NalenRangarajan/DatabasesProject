using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTracking.Models
{
	public class Platform
	{
		public int PlatformID { get; set; }

		public string Name { get; set; }

		public Platform(int pID, string n)
		{
			PlatformID = pID;
			Name = n;
		}
	}
}
