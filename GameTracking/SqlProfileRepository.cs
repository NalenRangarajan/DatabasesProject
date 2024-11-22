using GameTracking.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Transactions;

namespace GameTracking
{
	public class SqlProfileRepository : IProfileRepository
	{
		public readonly string connectionString;

		public SqlProfileRepository(string c)
		{
			connectionString = c;
		}

		public Profile CreateProfile(string username, string hashedPassword)
		{
			if (string.IsNullOrWhiteSpace(username))
				throw new ArgumentException("The parameter cannot be null or empty.", nameof(username));

			if (string.IsNullOrWhiteSpace(hashedPassword))
				throw new ArgumentException("The parameter cannot be null or empty.", nameof(hashedPassword));

			using (var transaction = new TransactionScope())
			{
				using (var connection = new SqlConnection(connectionString))
				{
					using (var command = new SqlCommand("GameTrack.CreateProfile", connection))
					{
						command.CommandType = CommandType.StoredProcedure;

						command.Parameters.AddWithValue("Username", username);
						command.Parameters.AddWithValue("HashedPassword", hashedPassword);

						var p = command.Parameters.Add("ProfileID", SqlDbType.Int);
						p.Direction = ParameterDirection.Output;

						connection.Open();

						command.ExecuteNonQuery();

						transaction.Complete();

						int profileID = (int)command.Parameters["ProfileID"].Value;

						return new Profile(profileID, username, hashedPassword, DateTime.Now);
					}
				}
			}
		}

		public Profile FetchProfile(int profileID)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				using (var command = new SqlCommand("GameTrack.FetchProfile", connection))
				{
					command.CommandType = CommandType.StoredProcedure;

					command.Parameters.AddWithValue("ProfileID", profileID);

					connection.Open();

					using (SqlDataReader reader = command.ExecuteReader())
					{
						Profile? profile = TranslateProfile(reader);

						if(profile == null)
						{
							throw new RecordNotFoundException(profileID.ToString());
						}

						return profile;
					}
				}
			}
		}

		public Profile GetProfile(string username)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				using (var command = new SqlCommand("GameTrack.GetProfileByUsername", connection))
				{
					command.CommandType = CommandType.StoredProcedure;

					command.Parameters.AddWithValue("Username", username);

					connection.Open();

					using (SqlDataReader reader = command.ExecuteReader())
					{
						Profile profile = TranslateProfile(reader)!;

						return profile;
					}
				}
			}
		}

		private Profile? TranslateProfile(SqlDataReader reader)
		{
			int profileIDOrdinal = reader.GetOrdinal("ProfileID");
			int usernameOrdinal = reader.GetOrdinal("Username");
			int hashedPasswordOrdinal = reader.GetOrdinal("HashedPassword");

			if(!reader.Read())
			{
				return null;
			}

			return new Profile(reader.GetInt32(profileIDOrdinal), reader.GetString(usernameOrdinal), 
				reader.GetString(hashedPasswordOrdinal));
		}
	}
}
