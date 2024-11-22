using GameTracking.Models;
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
	public partial class AddGameView : Form
	{
		private const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=CIS560;Integrated Security=SSPI;";

		private SqlGameRepository sgr = new SqlGameRepository(connectionString);

		private SqlGenreRepository sgenr = new SqlGenreRepository(connectionString);

		public Game CreatedGame;

		public AddGameView()
		{
			InitializeComponent();

			IReadOnlyList<Genre> genres = sgenr.GetAllGenres();
			foreach(Genre g in genres)
			{
				GenreComboBox.Items.Add(g);
			}
		}

		private void SubmitButton_Click(object sender, EventArgs e)
		{
			string title = TitleTextBox.Text;
			Genre genre = (Genre)GenreComboBox.SelectedItem;
			string publisher = PublisherTextBox.Text;
			string developer = DeveloperTextBox.Text;
			DateTime releaseDate = ReleaseDatePicker.Value;
			if (title != "" && genre.Name != "" && developer != "" && publisher != "")
			{
				CreatedGame = sgr.CreateGame(title, releaseDate, developer, publisher);
				if (CreatedGame == null)
				{
					MessageBox.Show("Null game");
				}

				DialogResult = DialogResult.OK;
				this.Close();
			}
			else
			{
				MessageBox.Show("Error: Leave no boxes empty.");
			}
		}
	}
}
