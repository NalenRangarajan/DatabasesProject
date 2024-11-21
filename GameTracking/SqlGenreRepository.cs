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
	public class SqlGenreRepository : IGenreRepository
	{
		public readonly string connectionString;

		public SqlGenreRepository(string c)
		{
			connectionString = c;
		}

		public Genre FetchGenre(int genreID)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				using (var command = new SqlCommand("GameTrack.FetchGenre", connection))
				{
					command.CommandType = CommandType.StoredProcedure;

					command.Parameters.AddWithValue("GenreID", genreID);

					connection.Open();

					using (SqlDataReader reader = command.ExecuteReader())
					{
						Genre? genre = TranslateGenre(reader);

						if (genre == null)
						{
							throw new RecordNotFoundException(genreID.ToString());
						}

						return genre;
					}
				}
			}
		}

		public Genre GetGenre(string name)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				using (var command = new SqlCommand("GameTrack.GetGenreByName", connection))
				{
					command.CommandType = CommandType.StoredProcedure;

					command.Parameters.AddWithValue("Name", name);

					connection.Open();

					using (SqlDataReader reader = command.ExecuteReader())
					{
						Genre genre = TranslateGenre(reader)!;

						return genre;
					}
				}
			}
		}

		public IReadOnlyList<Genre> GetGenresForGame(int gameID)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				using (var command = new SqlCommand("GameTrack.GetGenresForGame", connection))
				{
					command.CommandType = CommandType.StoredProcedure;

					command.Parameters.AddWithValue("GameID", gameID);

					connection.Open();

					using (SqlDataReader reader = command.ExecuteReader())
					{
						return TranslateGenres(reader);
					}
				}
			}
		}

		private IReadOnlyList<Genre> TranslateGenres(SqlDataReader reader)
		{
			List<Genre> genres = new List<Genre>();

			int genreIDOrdinal = reader.GetOrdinal("GenreID");
			int nameOrdinal = reader.GetOrdinal("Name");

			while (reader.Read())
			{
				genres.Add(new Genre(reader.GetInt32(genreIDOrdinal), reader.GetString(nameOrdinal)));
			}

			return genres;
		}

		private Genre? TranslateGenre(SqlDataReader reader)
		{
			int genreIDOrdinal = reader.GetOrdinal("GenreID");
			int nameOrdinal = reader.GetOrdinal("Name");

			if (!reader.Read())
			{
				return null;
			}

			return new Genre(reader.GetInt32(genreIDOrdinal), reader.GetString(nameOrdinal));
		}
	}
}

