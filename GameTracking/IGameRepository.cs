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
	}
}
