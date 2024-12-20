﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameTracking;

namespace GameApplication
{
    public partial class WriteReview : Form
    {
		private const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=CIS560;Integrated Security=SSPI;";

        private SqlReviewRepository reviewRepo = new SqlReviewRepository(connectionString);

        public int Score
        {
            get => (int)ScoreUpDown.Value;
            set
            {
                ScoreUpDown.Value = value;
            }
        }

        public string Body
        {
            get => BodyTextBox.Text;
            set
            {
                BodyTextBox.Text = value;
            }
        }

        public WriteReview()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
