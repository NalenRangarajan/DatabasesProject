using GameTracking;
using GameTracking.Models;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace GameApplication
{
    public partial class GameView : Form
    {
        private const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=CIS560;Integrated Security=SSPI;";

        private LoginView lv = new LoginView();

        private Profile profile;

        private Game game;

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
            Deactivate();
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
            if (lv.ShowDialog() != DialogResult.Cancel)
            {
                profile = lv.profile;
                Activate();
            }
        }

        private void Deactivate()
        {
            foreach (Control c in this.Controls)
            {
                c.Enabled = false;
            }
            SignOutButton.Enabled = true;
        }

        private void Activate()
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
            SetGame(game.Name, game.ReleaseDate, "Null", "Null");
        }

        private void SetWelcome()
        {
            string username = profile.Username;
            WelcomLabel.Text = $"Welcome {username}!";
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
            string[] gameTitles = new string[50]
            {
                "The Legend of Zelda: Breath of the Wild",
                "Elden Ring",
                "Red Dead Redemption 2",
                "Cyberpunk 2077",
                "God of War",
                "The Witcher 3: Wild Hunt",
                "Grand Theft Auto V",
                "Hollow Knight",
                "Minecraft",
                "Dark Souls III",
                "Sekiro: Shadows Die Twice",
                "Resident Evil Village",
                "Hades",
                "Stardew Valley",
                "Animal Crossing: New Horizons",
                "Portal 2",
                "Half-Life: Alyx",
                "Bloodborne",
                "Super Mario Odyssey",
                "Celeste",
                "Final Fantasy VII Remake",
                "Mass Effect Legendary Edition",
                "Disco Elysium",
                "Outer Wilds",
                "Death Stranding",
                "Assassin's Creed Valhalla",
                "Marvel's Spider-Man",
                "DOOM Eternal",
                "Control",
                "Ori and the Will of the Wisps",
                "A Plague Tale: Innocence",
                "Horizon Zero Dawn",
                "Forza Horizon 5",
                "The Elder Scrolls V: Skyrim",
                "Metal Gear Solid V: The Phantom Pain",
                "Persona 5 Royal",
                "Divinity: Original Sin 2",
                "Dead Cells",
                "Terraria",
                "Cuphead",
                "Fallout 4",
                "Dragon Age: Inquisition",
                "NieR: Automata",
                "Firewatch",
                "Inside",
                "Limbo",
                "Journey",
                "Among Us",
                "It Takes Two",
                "Overwatch"
            };
            foreach (string title in gameTitles)
            {
                var item = new ListViewItem(title);
                GamesList.Items.Add(item);
            }
        }

        private void AddGameButton_Click(object sender, EventArgs e)
        {
            AddReviewView agv = new AddReviewView();
            if (agv.ShowDialog() == DialogResult.OK)
            {
                WriteReview wr = new WriteReview();
                if (wr.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void SignOutButton_Click(object sender, EventArgs e)
        {
            LoginAttempt();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            WriteReview wr = new WriteReview();
            if (wr.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void GamesList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}