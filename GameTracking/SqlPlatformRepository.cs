using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using GameTracking.Models;
using System.Transactions;

namespace GameTracking
{
	public class SqlPlatformRepository : IPlatformRepository
	{
		public readonly string connectionString;

		public SqlPlatformRepository(string c)
		{
			connectionString = c;
		}

		public Platform FetchPlatform(int platformID)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				using (var command = new SqlCommand("GameTrack.FetchPlatform", connection))
				{
					command.CommandType = CommandType.StoredProcedure;

					command.Parameters.AddWithValue("PlatformID", platformID);

					connection.Open();

					using (SqlDataReader reader = command.ExecuteReader())
					{
						Platform? platform = TranslatePlatform(reader);

						if (platform == null)
						{
							throw new RecordNotFoundException(platformID.ToString());
						}

						return platform;
					}
				}
			}
		}

		public Platform GetPlatform(string name)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				using (var command = new SqlCommand("GameTrack.GetPlatformByName", connection))
				{
					command.CommandType = CommandType.StoredProcedure;

					command.Parameters.AddWithValue("Name", name);

					connection.Open();

					using (SqlDataReader reader = command.ExecuteReader())
					{
						Platform platform = TranslatePlatform(reader)!;

						return platform;
					}
				}
			}
		}

		public IReadOnlyList<Platform> GetPlatformsForGame(int gameID)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				using (var command = new SqlCommand("GameTrack.GetPlatformsForGame", connection))
				{
					command.CommandType = CommandType.StoredProcedure;

					command.Parameters.AddWithValue("GameID", gameID);

					connection.Open();

					using (SqlDataReader reader = command.ExecuteReader())
					{
						return TranslatePlatforms(reader);
					}
				}
			}
		}

		private IReadOnlyList<Platform> TranslatePlatforms(SqlDataReader reader)
		{
			List<Platform> platforms = new List<Platform>();

			int platformIDOrdinal = reader.GetOrdinal("PlatformID");
			int nameOrdinal = reader.GetOrdinal("Name");

			while (reader.Read())
			{
				platforms.Add(new Platform(reader.GetInt32(platformIDOrdinal), reader.GetString(nameOrdinal)));
			}

			return platforms;
		}

		private Platform? TranslatePlatform(SqlDataReader reader)
		{
			int platformIDOrdinal = reader.GetOrdinal("PlatformID");
			int nameOrdinal = reader.GetOrdinal("Name");

			if (!reader.Read())
			{
				return null;
			}

			return new Platform(reader.GetInt32(platformIDOrdinal), reader.GetString(nameOrdinal));
		}
	}
}
