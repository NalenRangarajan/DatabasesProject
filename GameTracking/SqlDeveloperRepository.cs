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

		public Developer GetDeveloperByWebsite(string website)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				using (var command = new SqlCommand("GameTrack.GetDeveloperByWebsite", connection))
				{
					command.CommandType = CommandType.StoredProcedure;

					command.Parameters.AddWithValue("Website", website);

					connection.Open();

					using (SqlDataReader reader = command.ExecuteReader())
					{
						Developer developer = TranslateDeveloper(reader)!;

						return developer;
					}
				}
			}
		}

		private Developer? TranslateDeveloper(SqlDataReader reader)
		{
			int developerIDOrdinal = reader.GetOrdinal("DeveloperID");
			int nameOrdinal = reader.GetOrdinal("Name");
			int websiteOrdinal = reader.GetOrdinal("Website");
			int foundedDateOrdinal = reader.GetOrdinal("FoundedDate");
			int locationOrdinal = reader.GetOrdinal("Location");
			int teamCountOrdinal = reader.GetOrdinal("TeamCount");

			if (!reader.Read())
			{
				return null;
			}

			return new Developer(reader.GetInt32(developerIDOrdinal), reader.GetString(nameOrdinal), reader.GetString(websiteOrdinal),
				reader.GetDateTime(foundedDateOrdinal), reader.GetString(locationOrdinal), reader.GetInt32(teamCountOrdinal));
		}
	}
}
