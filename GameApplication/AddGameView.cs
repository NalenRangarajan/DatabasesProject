using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameApplication
{
    public partial class AddGameView : Form
    {
        public AddGameView()
        {
            InitializeComponent();
            SetGenres();

        }

        private void SetGenres()
        {
            string[] gameGenres = new string[]
            {
                "Action",
                "Adventure",
                "Role-Playing Games (RPG)",
                "Shooter",
                "Simulation",
                "Strategy",
                "Sports",
                "Puzzle",
                "Survival Horror",
                "Platformer"
            };
            foreach (string genre in gameGenres)
            {
                GenreListView.Items.Add(genre);
            }
        }
    }
}
