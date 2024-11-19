using GameTracking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTracking
{
	public interface IProfileRepository
	{
		Profile CreateProfile(string username, string hashedPassword);

		Profile FetchProfile(int profileID);

		Profile GetProfile(string username);
	}
}
