using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameTracking;
using GameTracking.Models;

namespace GameApplication
{
	public partial class GameAndDevStatsView : Form
	{
		private const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=CIS560;Integrated Security=SSPI;";

		private SqlGameRepository sgr = new SqlGameRepository(connectionString);

		private SqlDeveloperRepository sdr = new SqlDeveloperRepository(connectionString);
		public GameAndDevStatsView()
		{
			InitializeComponent();
			DisplayGameStatistics();
			DisplayDeveloperStatistics();
		}

		private void DisplayGameStatistics()
		{
			IReadOnlyList<Game> gamesWithReviewCount = sgr.GetAllGamesWithReviewCount();
			IReadOnlyList<Game> gamesWithAverageScore = sgr.GetAllGamesWithAverageScore();

			List<Game> gamesToDisplay = new List<Game>();

			foreach (Game g1 in gamesWithReviewCount)
			{
				foreach (Game g2 in gamesWithAverageScore)
				{
					if (g1.Equals(g2))
					{
						gamesToDisplay.Add(new Game(g1.GameID, g1.PublisherID, g1.Name, g1.ReleaseDate) { ReviewCount = g1.ReviewCount, AverageScore = g2.AverageScore });
						break;
					}
				}
			}

			foreach (Game game in gamesToDisplay)
			{
				var item = new ListViewItem();
				item.Text = game.Name + " | Review Count: " + game.ReviewCount + " | Average Score: " + game.AverageScore;
				item.Tag = game;
				GamesList.Items.Add(item);
			}
		}

		private void DisplayDeveloperStatistics()
		{
			IReadOnlyList<Developer> devsWithNumGames = sdr.GetAllDevelopersWithNumGames();
			IReadOnlyList<Developer> devsWithAverageScore = sdr.GetAllDevelopersWithAverageScore();

			List<Developer> devsToDisplay = new List<Developer>();

			foreach (Developer d1 in devsWithNumGames)
			{
				foreach (Developer d2 in devsWithAverageScore)
				{
					if (d1.Equals(d2))
					{
						devsToDisplay.Add(new Developer(d1.DeveloperID, d1.Name, d1.Email, d1.FoundedDate, d1.Location, d1.TeamCount) { AverageReviewScore = d2.AverageReviewScore, NumGames = d1.NumGames });
						break;
					}
				}
			}

			foreach (Developer dev in devsToDisplay)
			{
				var item = new ListViewItem();
				item.Text = dev.Name + " | Games Developed: " + dev.NumGames + " | Average Review Score: " + dev.AverageReviewScore;
				item.Tag = dev;
				DevelopersList.Items.Add(item);
			}
		}
	}
}
