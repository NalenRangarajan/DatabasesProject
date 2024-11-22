using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using GameTracking.Models;
using System.Data;
using System.Transactions;

namespace GameTracking
{
	public class SqlGameRepository : IGameRepository
	{
		public readonly string connectionString;

		public SqlGameRepository(string c)
		{
			connectionString = c;
		}

		public Game CreateGame(string name, DateTime releaseDate, string developerName, string publisherName)
		{
			if (string.IsNullOrWhiteSpace(name))
				throw new ArgumentException("The parameter cannot be null or empty.", nameof(name));

			if (releaseDate == default)
				throw new ArgumentException("The parameter cannot be null or empty.", nameof(releaseDate));

			if (string.IsNullOrWhiteSpace(publisherName))
				throw new ArgumentException("The parameter cannot be null or empty.", nameof(publisherName));

			if (string.IsNullOrWhiteSpace(developerName))
				throw new ArgumentException("The parameter cannot be null or empty.", nameof(developerName));

			using (var transaction = new TransactionScope())
			{
				using (var connection = new SqlConnection(connectionString))
				{
					using (var command = new SqlCommand("GameTrack.CreateGame", connection))
					{
						command.CommandType = CommandType.StoredProcedure;

						command.Parameters.AddWithValue("Name", name);
						command.Parameters.AddWithValue("ReleaseDate", releaseDate);
						command.Parameters.AddWithValue("DeveloperName", developerName);
						command.Parameters.AddWithValue("PublisherName", publisherName);

						var p = command.Parameters.Add("GameID", SqlDbType.Int);
						p.Direction = ParameterDirection.Output;

						connection.Open();

						command.ExecuteNonQuery();

						transaction.Complete();

						int gameID = (int)command.Parameters["GameID"].Value;

						int publisherID = (int)command.Parameters["PublisherID"].Value;

						return new Game(gameID, publisherID, name, releaseDate);
					}
				}
			}
		}

		public Game FetchGame(int gameID)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				using (var command = new SqlCommand("GameTrack.FetchGame", connection))
				{
					command.CommandType = CommandType.StoredProcedure;

					command.Parameters.AddWithValue("GameID", gameID);

					connection.Open();

					using (SqlDataReader reader = command.ExecuteReader())
					{
						Game? game = TranslateGame(reader);

						if (game == null)
						{
							throw new RecordNotFoundException(gameID.ToString());
						}

						return game;
					}
				}
			}
		}

		public IReadOnlyList<Game> GetGamesForProfile(string username)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				using (var command = new SqlCommand("GameTrack.GetGamesForProfile", connection))
				{
					command.CommandType = CommandType.StoredProcedure;

					command.Parameters.AddWithValue("Username", username);

					connection.Open();

					using (SqlDataReader reader = command.ExecuteReader())
					{
						return TranslateGames(reader);
					}
				}
			}
		}

		private IReadOnlyList<Game> TranslateGames(SqlDataReader reader)
		{
			List<Game> games = new List<Game>();

			int gameIDOrdinal = reader.GetOrdinal("GameID");
			int publisherIDOrdinal = reader.GetOrdinal("PublisherID");
			int nameOrdinal = reader.GetOrdinal("Name");
			int releaseDateOrdinal = reader.GetOrdinal("ReleaseDate");

			while (reader.Read())
			{
				games.Add(new Game(reader.GetInt32(gameIDOrdinal), reader.GetInt32(publisherIDOrdinal),
				reader.GetString(nameOrdinal), reader.GetDateTime(releaseDateOrdinal)));
			}

			return games;
		}

		private Game? TranslateGame(SqlDataReader reader)
		{
			int gameIDOrdinal = reader.GetOrdinal("GameID");
			int publisherIDOrdinal = reader.GetOrdinal("PublisherID");
			int nameOrdinal = reader.GetOrdinal("Name");
			int releaseDateOrdinal = reader.GetOrdinal("ReleaseDate");

			if (!reader.Read())
			{
				return null;
			}

			return new Game(reader.GetInt32(gameIDOrdinal), reader.GetInt32(publisherIDOrdinal), 
				reader.GetString(nameOrdinal), reader.GetDateTime(releaseDateOrdinal));
		}
	}
}
