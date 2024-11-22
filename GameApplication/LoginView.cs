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
    public partial class LoginView : Form
    {
        private const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=CIS560;Integrated Security=SSPI;";

        private SqlProfileRepository spr = new SqlProfileRepository(connectionString);

        public Profile profile;

        public LoginView()
        {
            InitializeComponent();
        }

        public static string Rot13(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            char Rot13Char(char c)
            {
                if (c >= 'a' && c <= 'z')
                {
                    return (char)((c - 'a' + 13) % 26 + 'a');
                }
                else if (c >= 'A' && c <= 'Z')
                {
                    return (char)((c - 'A' + 13) % 26 + 'A');
                }
                return c; // Non-alphabetic characters are returned unchanged
            }

            return new string(input.Select(Rot13Char).ToArray());
        }


        private void LoginButton_Click(object sender, EventArgs e)
        {   
            string user = UsernameTextBox.Text;
            string pass = PasswordTextBox.Text;

            profile = spr.GetProfile(user);
            if (profile != null)
            {
                if (profile.HashedPassword == Rot13(pass))
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            MessageBox.Show("Incorrect username or passowrd.");
            
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string user = UsernameTextBox.Text;
            string pass = PasswordTextBox.Text;
            if (user != "" && pass != "")
            {
                profile = spr.CreateProfile(user, Rot13(pass));
                this.Hide();
                UsernameTextBox.Text = "";
                PasswordTextBox.Text = "";
            }
        }
    }
}
