using GameTracking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTracking
{
	public interface IGenreRepository
	{
		Genre FetchGenre(int genreID);

		Genre GetGenre(string name);

		IReadOnlyList<Genre> GetGenresForGame(int gameID);
	}
}
