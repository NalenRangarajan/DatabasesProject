using GameTracking;
using GameTracking.Models;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.Pkcs;
using System.Text;

namespace GameApplication
{
    public partial class GameView : Form
    {
        private const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=CIS560;Integrated Security=SSPI;";

        private Profile? profile;

        private Game? game;

        private Review? review;

        private IReadOnlyList<Game>? games;

        private SqlGameRepository sgr = new SqlGameRepository(connectionString);

        private SqlGenreRepository sgrr = new SqlGenreRepository(connectionString);

        private SqlPlatformRepository spr = new SqlPlatformRepository(connectionString);

        private SqlReviewRepository srr = new SqlReviewRepository(connectionString);
        public string GameTitle
        {
            get
            {
                return GameTitleLabel.Text;
            }
            set
            {
                GameTitleLabel.Text = value;
            }
        }

        public string ReleaseDate
        {
            get
            {
                return ReleaseDateLabel.Text;
            }
            set
            {
                ReleaseDateLabel.Text = value;
            }
        }

        public string Genre
        {
            get
            {
                return GenreLabel.Text;
            }
            set
            {
                GenreLabel.Text = value;
            }
        }

        public string Platform
        {
            get
            {
                return PlatformLabel.Text;
            }
            set
            {
                PlatformLabel.Text = value;
            }
        }

        public GameView()
        {
            InitializeComponent();
            DeactivateControls();
            LoginAttempt();
        }

        private void LoginAttempt()
        {
            using (LoginView lv = new LoginView())
            {
                if (lv.ShowDialog() == DialogResult.OK)
                {
                    profile = lv.profile;
                    ActivateControls();
                    EditButton.Enabled = false;
                    UpdateGUIProfile();
                }
            }
        }

        private void WriteReviewAttempt(int gameID)
        {
            using (WriteReview wr = new WriteReview())
            {
                if (wr.ShowDialog() == DialogResult.OK)
                {
                    sgr.AddGameProfile(gameID, profile.Username);
                    srr.CreateReview(gameID, wr.Score, wr.Body);
                    UpdateGUIGame();
                }
            }
        }

        private void AddReviewAttempt()
        {
            using (AddReviewView arv = new AddReviewView())
            {
                if (arv.ShowDialog() == DialogResult.OK)
                {
                    WriteReviewAttempt(arv.game.GameID);
                }
            }
        }

        private void DeactivateControls()
        {
            foreach (Control c in this.Controls)
            {
                c.Enabled = false;
            }
            SignOutButton.Enabled = true;
        }

        private void ActivateControls()
        {
            foreach (Control c in this.Controls)
            {
                c.Enabled = true;
            }
        }

        private void UpdateGUIProfile()
        {
            SetWelcome();
            SetGamesList();
        }

        private void UpdateGUIGame()
        {
            SetGamesList();
            if (game != null)
            {
                EditButton.Enabled = true;

                StringBuilder genreString = new StringBuilder();
                IReadOnlyList<Genre> genres = sgrr.GetGenresForGame(game.GameID);
                foreach (Genre genre in genres)
                {
                    genreString.Append(genre.Name + ", ");
                }
                genreString.Remove(genreString.Length - 2, 2);

                StringBuilder platformString = new StringBuilder();
                foreach (Platform platform in spr.GetPlatformsForGame(game.GameID))
                {
                    platformString.Append(platform.Name + ", ");
                }
                if(platformString.Length != 0)
                {
					platformString.Remove(platformString.Length - 2, 2);
				}

                SetGame(game.Name, game.ReleaseDate, genreString.ToString(), platformString.ToString()); ;
                review = srr.GetReviewByProfileAndGame(profile.Username, game.GameID);
                YourReview.SetReview(review.Score, review.Body, review.ReviewDate);
                SetOtherReviews();
            }

        }

        private void SetWelcome()
        {
            if (profile != null)
            {
                string username = profile.Username;
                WelcomLabel.Text = $"Welcome {username}!";
            }
        }

        private void SetGame(string t, DateTime rd, string g, string p)
        {
            GameTitle = t;
            ReleaseDate = $"Release Date: {rd.ToString("MMM dd, yyyy")}";
            Genre = $"Genre: {g}"; ;
            Platform = $"Platform: {p}"; ;
        }

        private void SetOtherReviews()
        {
            IReadOnlyList<Review> reviews = srr.GetReviews(game.GameID);
            OtherReviews.Controls.Clear();
            foreach (Review review in reviews)
            {
                ReviewControl r = SetReview(review.Score, review.Body, DateTime.Now);
                OtherReviews.Controls.Add(r);
            }
        }

        private ReviewControl SetReview(int score, string? body, DateTime dt)
        {
            ReviewControl r = new ReviewControl();
            r.Margin = new Padding(0, 0, 0, 5);
            r.SetReview(score, body, dt);
            return r;
        }

        private void SetGamesList()
        {
            if (profile != null)
            {
                games = sgr.GetGamesForProfile(profile.Username);
                GamesList.Items.Clear();
                foreach (Game game in games)
                {
                    var item = new ListViewItem();
                    item.Text = game.Name;
                    item.Tag = game;
                    GamesList.Items.Add(item);
                }
            }
        }

        private void AddGameButton_Click(object sender, EventArgs e)
        {
            AddReviewAttempt();
        }

        private void SignOutButton_Click(object sender, EventArgs e)
        {
            DeactivateControls();
            LoginAttempt();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            WriteReviewAttempt(game.GameID);
        }

        private void GamesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem selectedItem = (ListViewItem)GamesList.SelectedItems[0];
            game = (Game)selectedItem.Tag;
            UpdateGUIGame();
        }
    }
}