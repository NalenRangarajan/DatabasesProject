using GameTracking.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace GameTracking
{
	public class SqlDeveloperRepository : IDeveloperRepository
	{
		public readonly string connectionString;

		public SqlDeveloperRepository(string c)
		{
			connectionString = c;
		}

		public Developer FetchDeveloper(int developerID)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				using (var command = new SqlCommand("GameTrack.FetchDeveloper", connection))
				{
					command.CommandType = CommandType.StoredProcedure;

					command.Parameters.AddWithValue("DeveloperID", developerID);

					connection.Open();

					using (SqlDataReader reader = command.ExecuteReader())
					{
						Developer? developer = TranslateDeveloper(reader);

						if (developer == null)
						{
							throw new RecordNotFoundException(developerID.ToString());
						}

						return developer;
					}
				}
			}
		}

		public Developer GetDeveloperByName(string name)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				using (var command = new SqlCommand("GameTrack.GetDeveloperByName", connection))
				{
					command.CommandType = CommandType.StoredProcedure;

					command.Parameters.AddWithValue("Name", name);

					connection.Open();

					using (SqlDataReader reader = command.ExecuteReader())
					{
						Developer developer = TranslateDeveloper(reader)!;

						return developer;
					}
				}
			}
		}

		public Developer GetDeveloperByEmail(string email)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				using (var command = new SqlCommand("GameTrack.GetDeveloperByEmail", connection))
				{
					command.CommandType = CommandType.StoredProcedure;

					command.Parameters.AddWithValue("Email", email);

					connection.Open();

					using (SqlDataReader reader = command.ExecuteReader())
					{
						Developer developer = TranslateDeveloper(reader)!;

						return developer;
					}
				}
			}
		}

		public IReadOnlyList<Developer> GetDevelopersForGame(int gameID)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				using (var command = new SqlCommand("GameTrack.GetDevelopersForGame", connection))
				{
					command.CommandType = CommandType.StoredProcedure;

					command.Parameters.AddWithValue("GameID", gameID);

					connection.Open();

					using (SqlDataReader reader = command.ExecuteReader())
					{
						return TranslateDevelopers(reader);
					}
				}
			}
		}

		public IReadOnlyList<Developer> GetAllDevelopersWithAverageScore()
		{
			using (var connection = new SqlConnection(connectionString))
			{
				using (var command = new SqlCommand("GameTrack.GetDevelopersAndAverageScore", connection))
				{
					command.CommandType = CommandType.StoredProcedure;

					connection.Open();

					using (SqlDataReader reader = command.ExecuteReader())
					{
						return TranslateDevelopersWithAverageScore(reader);
					}
				}
			}
		}

		public IReadOnlyList<Developer> GetAllDevelopersWithNumGames()
		{
			using (var connection = new SqlConnection(connectionString))
			{
				using (var command = new SqlCommand("GameTrack.GetDevelopersAndNumGamesDeveloped", connection))
				{
					command.CommandType = CommandType.StoredProcedure;

					connection.Open();

					using (SqlDataReader reader = command.ExecuteReader())
					{
						return TranslateDevelopersWithNumGames(reader);
					}
				}
			}
		}

		private IReadOnlyList<Developer> TranslateDevelopersWithAverageScore(SqlDataReader reader)
		{
			List<Developer> developers = new List<Developer>();

			int developerIDOrdinal = reader.GetOrdinal("DeveloperID");
			int nameOrdinal = reader.GetOrdinal("Name");
			int emailOrdinal = reader.GetOrdinal("Email");
			int foundedDateOrdinal = reader.GetOrdinal("FoundedDate");
			int locationOrdinal = reader.GetOrdinal("Location");
			int teamCountOrdinal = reader.GetOrdinal("TeamCount");
			int averageReviewScoreOrdinal = reader.GetOrdinal("AverageReviewScore");

			while (reader.Read())
			{
				developers.Add(new Developer(reader.GetInt32(developerIDOrdinal), reader.GetString(nameOrdinal), reader.GetString(emailOrdinal),
				reader.GetDateTime(foundedDateOrdinal), reader.GetString(locationOrdinal), reader.GetInt32(teamCountOrdinal)) { AverageReviewScore = reader.GetDecimal(averageReviewScoreOrdinal)});
			}

			return developers;
		}

		private IReadOnlyList<Developer> TranslateDevelopersWithNumGames(SqlDataReader reader)
		{
			List<Developer> developers = new List<Developer>();

			int developerIDOrdinal = reader.GetOrdinal("DeveloperID");
			int nameOrdinal = reader.GetOrdinal("Name");
			int emailOrdinal = reader.GetOrdinal("Email");
			int foundedDateOrdinal = reader.GetOrdinal("FoundedDate");
			int locationOrdinal = reader.GetOrdinal("Location");
			int teamCountOrdinal = reader.GetOrdinal("TeamCount");
			int gamesDevelopedOrdinal = reader.GetOrdinal("GamesDeveloped");

			while (reader.Read())
			{
				developers.Add(new Developer(reader.GetInt32(developerIDOrdinal), reader.GetString(nameOrdinal), reader.GetString(emailOrdinal),
				reader.GetDateTime(foundedDateOrdinal), reader.GetString(locationOrdinal), reader.GetInt32(teamCountOrdinal)) { NumGames = reader.GetInt32(gamesDevelopedOrdinal) });
			}

			return developers;
		}

		private IReadOnlyList<Developer> TranslateDevelopers(SqlDataReader reader)
		{
			List<Developer> developers = new List<Developer>();

			int developerIDOrdinal = reader.GetOrdinal("DeveloperID");
			int nameOrdinal = reader.GetOrdinal("Name");
			int emailOrdinal = reader.GetOrdinal("Email");
			int foundedDateOrdinal = reader.GetOrdinal("FoundedDate");
			int locationOrdinal = reader.GetOrdinal("Location");
			int teamCountOrdinal = reader.GetOrdinal("TeamCount");

			while (reader.Read())
			{
				developers.Add(new Developer(reader.GetInt32(developerIDOrdinal), reader.GetString(nameOrdinal), reader.GetString(emailOrdinal),
				reader.GetDateTime(foundedDateOrdinal), reader.GetString(locationOrdinal), reader.GetInt32(teamCountOrdinal)));
			}

			return developers;
		}

		private Developer? TranslateDeveloper(SqlDataReader reader)
		{
			int developerIDOrdinal = reader.GetOrdinal("DeveloperID");
			int nameOrdinal = reader.GetOrdinal("Name");
			int emailOrdinal = reader.GetOrdinal("Email");
			int foundedDateOrdinal = reader.GetOrdinal("FoundedDate");
			int locationOrdinal = reader.GetOrdinal("Location");
			int teamCountOrdinal = reader.GetOrdinal("TeamCount");

			if (!reader.Read())
			{
				return null;
			}

			return new Developer(reader.GetInt32(developerIDOrdinal), reader.GetString(nameOrdinal), reader.GetString(emailOrdinal),
				reader.GetDateTime(foundedDateOrdinal), reader.GetString(locationOrdinal), reader.GetInt32(teamCountOrdinal));
		}


	}
}
