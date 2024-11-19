using GameTracking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTracking
{
	public interface IPlatformRepository
	{
		Platform FetchPlatform(int platformID);

		Platform GetPlatform(string name);
	}
}
