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

        SqlGameRepository sgr = new SqlGameRepository(connectionString);

        GameTracking.Models.Game? game;

        public AddGameView()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string title = TitleTextBox.Text;
            string genre = GenreTextBox.Text;
            string publisher = PublisherTextBox.Text;
            string developer = DeveloperTextBox.Text;
            DateTime releaseDate = ReleaseDatePicker.Value;

            game = sgr.CreateGame(title, releaseDate, developer, publisher);
            this.Hide();
            TitleTextBox.Text = "";
            GenreTextBox.Text = "";
            PublisherTextBox.Text = "";
            DeveloperTextBox.Text = "";
            ReleaseDatePicker.Value = default;

        }
    }
}
