using GameTracking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTracking
{
	public interface IDeveloperRepository
	{
		Developer FetchDeveloper(int developerID);

		Developer GetDeveloperByName(string name);

		Developer GetDeveloperByEmail(string email);

		IReadOnlyList<Developer> GetDevelopersForGame(int gameID);

		IReadOnlyList<Developer> GetAllDevelopersWithAverageScore();

		IReadOnlyList<Developer> GetAllDevelopersWithNumGames();
	}
}
