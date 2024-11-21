using GameTracking;
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
    public partial class AddReviewView : Form
    {
        private const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=CIS560;Integrated Security=SSPI;";

        SqlReviewRepository srr = new SqlReviewRepository(connectionString);

        private AddGameView agv = new AddGameView();

        public AddReviewView()
        {
            InitializeComponent();
            SetGenres();
            SetGamesList();
            MaxDatePicker.ValueChanged += UpdateDatePicker;
            MinDatePicker.ValueChanged += UpdateDatePicker;
            MinUpDown.ValueChanged += UpdateUpDown;
            MaxUpDown.ValueChanged += UpdateUpDown;
        }

        private void UpdateUpDown(object? sender, EventArgs e)
        {
            MaxUpDown.Minimum = MinUpDown.Value;
            MinUpDown.Maximum = MaxUpDown.Value;
        }

        private void UpdateDatePicker(object? sender, EventArgs e)
        {
            MaxDatePicker.MinDate = MinDatePicker.Value;
            MinDatePicker.MaxDate = MaxDatePicker.Value;
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
            if (agv.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void GamesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
