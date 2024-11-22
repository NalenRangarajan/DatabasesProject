using GameTracking;
using GameTracking.Models;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.Pkcs;

namespace GameApplication
{
    public partial class GameView : Form
    {
        private const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=CIS560;Integrated Security=SSPI;";

        private LoginView lv = new LoginView();

        private WriteReview wr = new WriteReview();

        AddReviewView agv = new AddReviewView();

        private Profile? profile;

        private Game? game;

        private IReadOnlyList<Game>? games;

        private SqlGameRepository sgr = new SqlGameRepository(connectionString);

        private SqlPlatformRepository spr = new SqlPlatformRepository(connectionString);
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
            /*
            SetGame("Doom", new DateTime(2016, 5, 13), "First-person shooter", "PS4, Windows, Xbox One, Nintendo Switch");
            YourReview.SetReview(5, "Great!", "Goob game but idaf about giving it a higher score. Tbh the game probably changed my life. Sucks I'll only give it a 5 tho.", DateTime.Now);
            SetOtherReviews();
            SetGamesList();
            SetWelcome();
            */
        }

        private void LoginAttempt()
        {
            if (lv.ShowDialog() == DialogResult.OK)
            {
                profile = lv.profile;
                ActivateControls();
                UpdateGUIProfile();
            }
        }

        private void WriteReviewAttempt()
        {
            if (wr.ShowDialog() != DialogResult.Cancel)
            {

            }
        }

        private void AddReviewAttempt()
        {
            if (agv.ShowDialog() != DialogResult.Cancel)
            {
                WriteReviewAttempt();
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
        }

        private void UpdateGUIGame()
        {
            if (game != null)
            {
                SetGame(game.Name, game.ReleaseDate, "Null", "Null");
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
            for (int i = 0; i < 10; i++)
            {
                ReviewControl r = new ReviewControl();
                r.Margin = new Padding(0, 0, 0, 5);
                r.SetReview(i, "When id Software resurrected the DOOM franchise in 2016, it was clear they aimed to recapture the lightning-in-a-bottle that made the original 1993 game a cultural phenomenon. What emerged was a masterclass in modern game design that paid homage to its roots while blazing its own trail—a visceral, chaotic, and relentlessly fun shooter that sets the gold standard for reboots.", DateTime.Now);
                OtherReviews.Controls.Add(r);
            }
        }

        private void SetReview(int score, string body, DateTime dt)
        {
            ReviewControl r = new ReviewControl();
            r.Margin = new Padding(0, 0, 0, 5);
            r.SetReview(score, body, dt);
            OtherReviews.Controls.Add(r);
        }

        private void SetGamesList()
        {
            if (profile != null) {
                games = sgr.GetGamesForProfile(profile.Username);
                foreach (Game game in games)
                {
                    var item = new ListViewItem(game.Name);
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
            WriteReviewAttempt();
        }

        private void GamesList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}