using GameTracking;
using GameTracking.Models;
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

        SqlGameRepository sgr = new SqlGameRepository(connectionString);

        SqlGenreRepository sgrr = new SqlGenreRepository(connectionString);

        SqlPublisherRepository spr = new SqlPublisherRepository(connectionString);

        SqlDeveloperRepository sdr = new SqlDeveloperRepository(connectionString);

        private AddGameView agv = new AddGameView();

        public Game? game;

        public Review? review;

        public AddReviewView()
        {
            InitializeComponent();
            SetGenres();
            IReadOnlyList<Game> games = sgr.GetAllGames();
            SetGamesList(games);
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
            IReadOnlyList<Genre> genres = sgrr.GetAllGenres();
            foreach (Genre genre in genres)
            {
                var item = new ListViewItem();
                item.Text = genre.Name;
                item.Tag = genre;
                GenreListView.Items.Add(item);
            }
        }

        private void SetGamesList(IReadOnlyList<Game> games)
        {
            GamesList.Items.Clear();
            foreach (Game ggame in games)
            {
                var item = new ListViewItem(ggame.Name);
                item.Text = ggame.Name;
                item.Tag = ggame;
                GamesList.Items.Add(item);
            }
        }

        private void AddGameButton_Click(object sender, EventArgs e)
        {
            if (agv.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Game Successfully Added.");

				IReadOnlyList<Game> games = sgr.GetAllGames();
				SetGamesList(games);
			}
        }

        private void GamesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem selectedItem = (ListViewItem)GamesList.SelectedItems[0];
            game = (Game)selectedItem.Tag;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (ListViewItem lvi in GenreListView.CheckedItems)
            {
                //ListViewItem lvi = (ListViewItem)v;
                sb.Append(((Genre)lvi.Tag).Name + ",");
            }
            if (sb.Length > 0)
            {
                sb.Remove(sb.Length - 1, 1);
            }
            if (TitleRadioButton.Checked)
            {
                IReadOnlyList<Game> g = sgr.SearchGamesByName(SearchBox.Text, MinDatePicker.Value, MaxDatePicker.Value, (int)MinUpDown.Value, (int)MaxUpDown.Value, sb.ToString());
                SetGamesList(g);
            }
            else if (PublisherRadioButton.Checked)
            {
                IReadOnlyList<Game> g = sgr.SearchGamesByPublisher(SearchBox.Text, MinDatePicker.Value, MaxDatePicker.Value, (int)MinUpDown.Value, (int)MaxUpDown.Value, sb.ToString());
                SetGamesList(g);
            }
            else
            {
                IReadOnlyList<Game> g = sgr.SearchGamesByDeveloper(SearchBox.Text, MinDatePicker.Value, MaxDatePicker.Value, (int)MinUpDown.Value, (int)MaxUpDown.Value, sb.ToString());
                SetGamesList(g);
            }
        }
    }
}
