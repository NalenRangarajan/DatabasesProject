using System.Reflection;
using System.Runtime.CompilerServices;

namespace GameApplication
{
    public partial class GameView : Form
    {
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
            SetGame("Doom", new DateTime(2016, 5, 13), "First-person shooter", "PS4, Windows, Xbox One, Nintendo Switch");
            reviewControl1.SetReview(5, "Great!", "Goob game but idaf about giving it a higher score. Tbh the game probably changed my life. Sucks I'll only give it a 5 tho. I break mirrors with my face in the united states. I break mirrors with my face in the united states. I break mirrors with my face in the united states.", DateTime.Now);
            SetOtherReviews();
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
                r.SetReview(5,"Great!","Goob game but idaf about giving it a higher score. Tbh the game probably changed my life. Sucks I'll only give it a 5 tho. I break mirrors with my face in the united states. I break mirrors with my face in the united states. I break mirrors with my face in the united states.", DateTime.Now);
                OtherReviews.Controls.Add(r);
            }
        }
    }
}