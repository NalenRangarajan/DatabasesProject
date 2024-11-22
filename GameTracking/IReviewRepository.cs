using GameTracking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTracking
{
	public interface IReviewRepository
	{
		Review CreateReview(int gameID, int score, string? body);

		Review FetchGame(int reviewID);

		IReadOnlyList<Review> GetReview(int gameID);

		Review GetReviewByProfileAndGame(string username, int gameID);
	}
}
