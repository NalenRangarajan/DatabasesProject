using GameTracking.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTracking
{
	public class SqlPublisherRepository : IPublisherRepository
	{
		public readonly string connectionString;

		public SqlPublisherRepository(string c)
		{
			connectionString = c;
		}

		public Publisher FetchPublisher(int publisherID)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				using (var command = new SqlCommand("GameTrack.FetchPublisher", connection))
				{
					command.CommandType = CommandType.StoredProcedure;

					command.Parameters.AddWithValue("PublisherID", publisherID);

					connection.Open();

					using (SqlDataReader reader = command.ExecuteReader())
					{
						Publisher? publisher = TranslatePublisher(reader);

						if (publisher == null)
						{
							throw new RecordNotFoundException(publisherID.ToString());
						}

						return publisher;
					}
				}
			}
		}

		public Publisher GetPublisher(string name)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				using (var command = new SqlCommand("GameTrack.GetPublisherByName", connection))
				{
					command.CommandType = CommandType.StoredProcedure;

					command.Parameters.AddWithValue("Name", name);

					connection.Open();

					using (SqlDataReader reader = command.ExecuteReader())
					{
						Publisher publisher = TranslatePublisher(reader)!;

						return publisher;
					}
				}
			}
		}

		private Publisher? TranslatePublisher(SqlDataReader reader)
		{
			int publisherIDOrdinal = reader.GetOrdinal("PublisherID");
			int nameOrdinal = reader.GetOrdinal("Name");
			int foundedDateOrdinal = reader.GetOrdinal("FoundedDate");
			int locationOrdinal = reader.GetOrdinal("Location");
			int websiteOrdinal = reader.GetOrdinal("Website");
			int employeeCountOrdinal = reader.GetOrdinal("EmployeeCount");

			if (!reader.Read())
			{
				return null;
			}

			return new Publisher(reader.GetInt32(publisherIDOrdinal), reader.GetString(nameOrdinal), 
				reader.GetDateTime(foundedDateOrdinal), reader.GetString(locationOrdinal), reader.GetString(websiteOrdinal), reader.GetInt32(employeeCountOrdinal));
		}
	}
}
