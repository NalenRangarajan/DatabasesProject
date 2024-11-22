using GameTracking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTracking
{
	public interface IGameRepository
	{
		Game CreateGame(string name, DateTime releaseDate, string developername, string publisherName);

		Game FetchGame(int gameID);

		IReadOnlyList<Game> GetGamesForProfile(string username);

		IReadOnlyList<Game> GetAllGames();

		IReadOnlyList<Game> SearchGamesByPublisher(string partName, DateTime start, DateTime end, int min, int max, string genres);

		IReadOnlyList<Game> SearchGamesByName(string partName, DateTime start, DateTime end, int min, int max, string genres);

		IReadOnlyList<Game> SearchGamesByDeveloper(string partName, DateTime start, DateTime end, int min, int max, string genres);

		void AddGameDeveloper(int gameID, string developerName);

		void AddGameGenre(int gameID, string genreName);
	}
}
