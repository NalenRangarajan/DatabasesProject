﻿using GameTracking.Models;
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
	public class SqlReviewRepository : IReviewRepository
	{
		public readonly string connectionString;

		public SqlReviewRepository(string c)
		{
			connectionString = c;
		}

		public Review CreateReview(int gameID, decimal score, string? body)
		{
			using (var transaction = new TransactionScope())
			{
				using (var connection = new SqlConnection(connectionString))
				{
					using (var command = new SqlCommand("GameTrack.CreateOrEditReview", connection))
					{
						command.CommandType = CommandType.StoredProcedure;

						command.Parameters.AddWithValue("GameID", gameID);
						command.Parameters.AddWithValue("Score", score);
						command.Parameters.AddWithValue("Body", body);

						var p = command.Parameters.Add("ReviewID", SqlDbType.Int);
						p.Direction = ParameterDirection.Output;

						connection.Open();

						command.ExecuteNonQuery();

						transaction.Complete();

						int reviewID = (int)command.Parameters["ReviewID"].Value;

						return new Review(reviewID, gameID, score, body, DateTime.Now);
					}
				}
			}
		}

		public Review FetchReview(int reviewID)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				using (var command = new SqlCommand("GameTrack.FetchReview", connection))
				{
					command.CommandType = CommandType.StoredProcedure;

					command.Parameters.AddWithValue("ReviewID", reviewID);

					connection.Open();

					using (SqlDataReader reader = command.ExecuteReader())
					{
						Review? review = TranslateReview(reader);

						if (review == null)
						{
							throw new RecordNotFoundException(reviewID.ToString());
						}

						return review;
					}
				}
			}
		}

		public Review GetReviewByProfileAndGame(string username, int gameID)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				using (var command = new SqlCommand("GameTrack.GetReviewByUsernameAndGameID", connection))
				{
					command.CommandType = CommandType.StoredProcedure;

					command.Parameters.AddWithValue("Username", username);
					command.Parameters.AddWithValue("GameID", gameID);

					connection.Open();

					using (SqlDataReader reader = command.ExecuteReader())
					{
						Review? review = TranslateReview(reader);

						if (review == null)
						{
							throw new RecordNotFoundException(username.ToString() + gameID.ToString());
						}

						return review;
					}
				}
			}
		}

		public IReadOnlyList<Review> GetReviews(int gameID)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				using (var command = new SqlCommand("GameTrack.GetReviewByGameID", connection))
				{
					command.CommandType = CommandType.StoredProcedure;

					command.Parameters.AddWithValue("GameID", gameID);

					connection.Open();

					using (SqlDataReader reader = command.ExecuteReader())
					{
						return TranslateReviews(reader);
					}
				}
			}
		}


		private IReadOnlyList<Review> TranslateReviews(SqlDataReader reader)
		{
			List<Review> review = new List<Review>();

			int reviewIDOrdinal = reader.GetOrdinal("ReviewID");
			int gameIDOrdinal = reader.GetOrdinal("GameID");
			int scoreOrdinal = reader.GetOrdinal("Score");
			int bodyOrdinal = reader.GetOrdinal("Body");
			int reviewDateOrdinal = reader.GetOrdinal("ReviewDate");

			while (reader.Read())
			{
				review.Add(new Review(reader.GetInt32(reviewIDOrdinal), reader.GetInt32(gameIDOrdinal), reader.GetDecimal(scoreOrdinal),
				reader.GetString(bodyOrdinal), reader.GetDateTime(reviewDateOrdinal)));
			}

			return review;
		}

		private Review? TranslateReview(SqlDataReader reader)
		{
			int reviewIDOrdinal = reader.GetOrdinal("ReviewID");
			int gameIDOrdinal = reader.GetOrdinal("GameID");
			int scoreOrdinal = reader.GetOrdinal("Score");
			int bodyOrdinal = reader.GetOrdinal("Body");
			int reviewDateOrdinal = reader.GetOrdinal("ReviewDate");

			if (!reader.Read())
			{
				return null;
			}

			return new Review(reader.GetInt32(reviewIDOrdinal), reader.GetInt32(gameIDOrdinal), reader.GetDecimal(scoreOrdinal), 
				reader.GetString(bodyOrdinal), reader.GetDateTime(reviewDateOrdinal));
		}
	}
}
