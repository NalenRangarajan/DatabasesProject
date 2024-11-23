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

		public Game CreateGame(string name, DateTime releaseDate, string developerName, string publisherName, int genreID)
		{
			if (string.IsNullOrWhiteSpace(name))
				throw new ArgumentException("The parameter cannot be null or empty.", nameof(name));

			if (releaseDate == default)
				throw new ArgumentException("The parameter cannot be null or empty.", nameof(releaseDate));

			if (string.IsNullOrWhiteSpace(publisherName))
				throw new ArgumentException("The parameter cannot be null or empty.", nameof(publisherName));

			if (string.IsNullOrWhiteSpace(developerName))
				throw new ArgumentException("The parameter cannot be null or empty.", nameof(developerName));

			if (genreID == 0)
				throw new ArgumentException("The parameter cannot be null or empty.", nameof(genreID));

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
						command.Parameters.AddWithValue("GenreID", genreID);

						var p = command.Parameters.Add("GameID", SqlDbType.Int);
						p.Direction = ParameterDirection.Output;

						var x = command.Parameters.Add("PublisherID", SqlDbType.Int);
						x.Direction = ParameterDirection.Output;

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

		public void AddGameDeveloper(int gameID, string developerName)
		{
			if (gameID == 0)
				throw new ArgumentException("The parameter cannot be null or empty.", nameof(gameID));

			if (string.IsNullOrWhiteSpace(developerName))
				throw new ArgumentException("The parameter cannot be null or empty.", nameof(developerName));

			using (var transaction = new TransactionScope())
			{
				using (var connection = new SqlConnection(connectionString))
				{
					using (var command = new SqlCommand("GameTrack.CreateGameDeveloper", connection))
					{
						command.CommandType = CommandType.StoredProcedure;

						command.Parameters.AddWithValue("GameID", gameID);
						command.Parameters.AddWithValue("DeveloperName", developerName);

						connection.Open();
					}
				}
			}
		}

		public void AddGameGenre(int gameID, string genreName)
		{
			if (gameID == 0)
				throw new ArgumentException("The parameter cannot be null or empty.", nameof(gameID));

			if (string.IsNullOrWhiteSpace(genreName))
				throw new ArgumentException("The parameter cannot be null or empty.", nameof(genreName));

			using (var transaction = new TransactionScope())
			{
				using (var connection = new SqlConnection(connectionString))
				{
					using (var command = new SqlCommand("GameTrack.CreateGameGenre", connection))
					{
						command.CommandType = CommandType.StoredProcedure;

						command.Parameters.AddWithValue("GameID", gameID);
						command.Parameters.AddWithValue("GenreName", genreName);

						connection.Open();
					}
				}
			}
		}

		public void AddGameProfile(int gameID, string username)
		{
			if (gameID == 0)
				throw new ArgumentException("The parameter cannot be null or empty.", nameof(gameID));

			if (string.IsNullOrWhiteSpace(username))
				throw new ArgumentException("The parameter cannot be null or empty.", nameof(username));

			using (var transaction = new TransactionScope())
			{
				using (var connection = new SqlConnection(connectionString))
				{
					using (var command = new SqlCommand("GameTrack.CreateGameProfile", connection))
					{
						command.CommandType = CommandType.StoredProcedure;

						command.Parameters.AddWithValue("GameID", gameID);
						command.Parameters.AddWithValue("Username", username);

						connection.Open();
						command.ExecuteNonQuery();
					}
				}

				transaction.Complete();
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

		public IReadOnlyList<Game> GetAllGames()
		{
			using (var connection = new SqlConnection(connectionString))
			{
				using (var command = new SqlCommand("GameTrack.GetAllGames", connection))
				{
					command.CommandType = CommandType.StoredProcedure;

					connection.Open();

					using (SqlDataReader reader = command.ExecuteReader())
					{
						return TranslateGames(reader);
					}
				}
			}
		}

		public IReadOnlyList<Game> SearchGamesByName(string partName, DateTime start, DateTime end, int min, int max, string genres)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				using (var command = new SqlCommand("GameTrack.SearchingGames", connection))
				{
					command.CommandType = CommandType.StoredProcedure;

					command.Parameters.AddWithValue("PartialGameName", partName);
					command.Parameters.AddWithValue("StartDate", start);
					command.Parameters.AddWithValue("EndDate", end);
					command.Parameters.AddWithValue("MinScore", min);
					command.Parameters.AddWithValue("MaxScore", max);
					command.Parameters.AddWithValue("Genres", genres);

					connection.Open();

					using (SqlDataReader reader = command.ExecuteReader())
					{
						return TranslateGames(reader);
					}
				}
			}
		}

		public IReadOnlyList<Game> SearchGamesByDeveloper(string partName, DateTime start, DateTime end, int min, int max, string genres)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				using (var command = new SqlCommand("GameTrack.SearchingDevelopers" +
					"", connection))
				{
					command.CommandType = CommandType.StoredProcedure;

					command.Parameters.AddWithValue("PartialDeveloperName", partName);
					command.Parameters.AddWithValue("StartDate", start);
					command.Parameters.AddWithValue("EndDate", end);
					command.Parameters.AddWithValue("MinScore", min);
					command.Parameters.AddWithValue("MaxScore", max);
					command.Parameters.AddWithValue("Genres", genres);

					connection.Open();

					using (SqlDataReader reader = command.ExecuteReader())
					{
						return TranslateGames(reader);
					}
				}
			}
		}

		public IReadOnlyList<Game> SearchGamesByPublisher(string partName, DateTime start, DateTime end, int min, int max, string genres)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				using (var command = new SqlCommand("GameTrack.SearchingPublishers", connection))
				{
					command.CommandType = CommandType.StoredProcedure;

					command.Parameters.AddWithValue("PartialPublisherName", partName);
					command.Parameters.AddWithValue("StartDate", start);
					command.Parameters.AddWithValue("EndDate", end);
					command.Parameters.AddWithValue("MinScore", min);
					command.Parameters.AddWithValue("MaxScore", max);
					command.Parameters.AddWithValue("Genres", genres);

					connection.Open();

					using (SqlDataReader reader = command.ExecuteReader())
					{
						return TranslateGames(reader);
					}
				}
			}
		}

		public IReadOnlyList<Game> GetAllGamesWithAverageScore()
		{
			using (var connection = new SqlConnection(connectionString))
			{
				using (var command = new SqlCommand("GameTrack.GetGamesAndAverageScore", connection))
				{
					command.CommandType = CommandType.StoredProcedure;

					connection.Open();

					using (SqlDataReader reader = command.ExecuteReader())
					{
						return TranslateGamesWithAverageScore(reader);
					}
				}
			}
		}

		public IReadOnlyList<Game> GetAllGamesWithReviewCount()
		{
			using (var connection = new SqlConnection(connectionString))
			{
				using (var command = new SqlCommand("GameTrack.GetGamesAndReviewCount", connection))
				{
					command.CommandType = CommandType.StoredProcedure;

					connection.Open();

					using (SqlDataReader reader = command.ExecuteReader())
					{
						return TranslateGamesWithReviewCount(reader);
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

		private IReadOnlyList<Game> TranslateGamesWithAverageScore(SqlDataReader reader)
		{
			List<Game> games = new List<Game>();

			int gameIDOrdinal = reader.GetOrdinal("GameID");
			int publisherIDOrdinal = reader.GetOrdinal("PublisherID");
			int nameOrdinal = reader.GetOrdinal("Name");
			int releaseDateOrdinal = reader.GetOrdinal("ReleaseDate");
			int averageScoreOrdinal = reader.GetOrdinal("AverageReviewScore");

			while (reader.Read())
			{
				games.Add(new Game(reader.GetInt32(gameIDOrdinal), reader.GetInt32(publisherIDOrdinal),
				reader.GetString(nameOrdinal), reader.GetDateTime(releaseDateOrdinal)) { AverageScore = reader.GetDouble(averageScoreOrdinal) });
			}

			return games;
		}

		private IReadOnlyList<Game> TranslateGamesWithReviewCount(SqlDataReader reader)
		{
			List<Game> games = new List<Game>();

			int gameIDOrdinal = reader.GetOrdinal("GameID");
			int publisherIDOrdinal = reader.GetOrdinal("PublisherID");
			int nameOrdinal = reader.GetOrdinal("Name");
			int releaseDateOrdinal = reader.GetOrdinal("ReleaseDate");
			int reviewCountOrdinal = reader.GetOrdinal("ReviewCount");

			while (reader.Read())
			{
				games.Add(new Game(reader.GetInt32(gameIDOrdinal), reader.GetInt32(publisherIDOrdinal),
				reader.GetString(nameOrdinal), reader.GetDateTime(releaseDateOrdinal)) { ReviewCount = reader.GetInt32(reviewCountOrdinal) });
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

		public IReadOnlyList<(Game, decimal)> GetGamesAndAverageScore() ///////WIPPP
		{
            var results = new List<(Game, decimal)>();

            using (var connection = new SqlConnection(connectionString))
			{
				using (var command = new SqlCommand("GameTrack.GetGamesAndAverageScores", connection))
				{
					
                    connection.Open();

                    command.CommandType = CommandType.StoredProcedure;
                    var p = command.Parameters.Add("AverageScore", SqlDbType.Decimal);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<(Game, decimal)> list = new();
                        list.Add(TranslateGameDecimal(reader, command));

                        return list;
                    }
					
                }
			}
		}

        public IReadOnlyList<(Game, decimal)> GetGamesAndReviewCount() ///////WIPPP
        {

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("GameTrack.GetGamesAndAverageScores", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
						List<(Game, decimal)> list = new();
						list.Add(TranslateGameDecimal(reader, command));



						return list;
                    }
                }
            }
        }

        private (Game,decimal) TranslateGameDecimal(SqlDataReader reader, SqlCommand command)
        {
            int gameIDOrdinal = reader.GetOrdinal("GameID");
            int publisherIDOrdinal = reader.GetOrdinal("PublisherID");
            int nameOrdinal = reader.GetOrdinal("Name");
            int releaseDateOrdinal = reader.GetOrdinal("ReleaseDate");

            if (!reader.Read())
            {
				throw new EndOfStreamException(" AYE you at the end");
            }

            int score = (int)command.Parameters["AverageScore"].Value;
            return (new Game(reader.GetInt32(gameIDOrdinal), reader.GetInt32(publisherIDOrdinal),
                reader.GetString(nameOrdinal), reader.GetDateTime(releaseDateOrdinal)), score);
        }
    }
}
