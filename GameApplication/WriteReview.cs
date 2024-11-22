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

        private int gameID;

        public WriteReview(int gameID)
        {
            this.gameID = gameID;
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            reviewRepo.CreateReview(gameID, Convert.ToInt32(ScoreUpDown.Value), BodyTextBox.Text);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
