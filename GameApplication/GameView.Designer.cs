namespace GameApplication
{
    partial class GameView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GameTitleLabel = new Label();
            ReleaseDateLabel = new Label();
            GenreLabel = new Label();
            PlatformLabel = new Label();
            ReviewLabel = new Label();
            YourReview = new ReviewControl();
            label1 = new Label();
            OtherReviews = new FlowLayoutPanel();
            GamesList = new ListView();
            PlayedGamesLabel = new Label();
            AddGameButton = new Button();
            SignOutButton = new Button();
            SuspendLayout();
            // 
            // GameTitleLabel
            // 
            GameTitleLabel.AutoSize = true;
            GameTitleLabel.BackColor = SystemColors.Control;
            GameTitleLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            GameTitleLabel.Location = new Point(368, 9);
            GameTitleLabel.Margin = new Padding(2, 0, 2, 0);
            GameTitleLabel.Name = "GameTitleLabel";
            GameTitleLabel.Size = new Size(85, 20);
            GameTitleLabel.TabIndex = 1;
            GameTitleLabel.Text = "Game Title";
            // 
            // ReleaseDateLabel
            // 
            ReleaseDateLabel.AutoSize = true;
            ReleaseDateLabel.BackColor = SystemColors.Control;
            ReleaseDateLabel.Location = new Point(261, 35);
            ReleaseDateLabel.Margin = new Padding(2, 0, 2, 0);
            ReleaseDateLabel.Name = "ReleaseDateLabel";
            ReleaseDateLabel.Size = new Size(59, 15);
            ReleaseDateLabel.TabIndex = 2;
            ReleaseDateLabel.Text = "Released: ";
            // 
            // GenreLabel
            // 
            GenreLabel.AutoSize = true;
            GenreLabel.BackColor = SystemColors.Control;
            GenreLabel.Location = new Point(261, 50);
            GenreLabel.Margin = new Padding(2, 0, 2, 0);
            GenreLabel.Name = "GenreLabel";
            GenreLabel.Size = new Size(44, 15);
            GenreLabel.TabIndex = 3;
            GenreLabel.Text = "Genre: ";
            // 
            // PlatformLabel
            // 
            PlatformLabel.AutoSize = true;
            PlatformLabel.BackColor = SystemColors.Control;
            PlatformLabel.Location = new Point(261, 65);
            PlatformLabel.Name = "PlatformLabel";
            PlatformLabel.Size = new Size(56, 15);
            PlatformLabel.TabIndex = 4;
            PlatformLabel.Text = "Platform:";
            // 
            // ReviewLabel
            // 
            ReviewLabel.AutoSize = true;
            ReviewLabel.BackColor = SystemColors.Control;
            ReviewLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            ReviewLabel.Location = new Point(368, 82);
            ReviewLabel.Margin = new Padding(2, 0, 2, 0);
            ReviewLabel.Name = "ReviewLabel";
            ReviewLabel.Size = new Size(95, 20);
            ReviewLabel.TabIndex = 5;
            ReviewLabel.Text = "Your Review";
            // 
            // YourReview
            // 
            YourReview.AutoScroll = true;
            YourReview.AutoSize = true;
            YourReview.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            YourReview.BackColor = SystemColors.Control;
            YourReview.Body = "Body";
            YourReview.ForeColor = SystemColors.ControlText;
            YourReview.Location = new Point(261, 102);
            YourReview.Margin = new Padding(0);
            YourReview.MaximumSize = new Size(300, 96);
            YourReview.Name = "YourReview";
            YourReview.ReviewDate = "Date";
            YourReview.Score = "#/10";
            YourReview.Size = new Size(300, 70);
            YourReview.TabIndex = 7;
            YourReview.Title = "TItle";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(368, 172);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 8;
            label1.Text = "Other Reviews";
            // 
            // OtherReviews
            // 
            OtherReviews.AutoScroll = true;
            OtherReviews.BackColor = SystemColors.Control;
            OtherReviews.Location = new Point(261, 195);
            OtherReviews.Margin = new Padding(0);
            OtherReviews.Name = "OtherReviews";
            OtherReviews.Size = new Size(300, 138);
            OtherReviews.TabIndex = 10;
            // 
            // GamesList
            // 
            GamesList.Activation = ItemActivation.OneClick;
            GamesList.Location = new Point(12, 32);
            GamesList.MultiSelect = false;
            GamesList.Name = "GamesList";
            GamesList.Size = new Size(230, 301);
            GamesList.TabIndex = 11;
            GamesList.TileSize = new Size(500, 30);
            GamesList.UseCompatibleStateImageBehavior = false;
            GamesList.View = View.Tile;
            // 
            // PlayedGamesLabel
            // 
            PlayedGamesLabel.AutoSize = true;
            PlayedGamesLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            PlayedGamesLabel.Location = new Point(77, 9);
            PlayedGamesLabel.Margin = new Padding(2, 0, 2, 0);
            PlayedGamesLabel.Name = "PlayedGamesLabel";
            PlayedGamesLabel.Size = new Size(93, 20);
            PlayedGamesLabel.TabIndex = 12;
            PlayedGamesLabel.Text = "Your Games";
            // 
            // AddGameButton
            // 
            AddGameButton.Anchor = AnchorStyles.Right;
            AddGameButton.AutoSize = true;
            AddGameButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AddGameButton.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            AddGameButton.Location = new Point(165, 9);
            AddGameButton.Margin = new Padding(0);
            AddGameButton.Name = "AddGameButton";
            AddGameButton.Size = new Size(77, 23);
            AddGameButton.TabIndex = 13;
            AddGameButton.Text = "Add Review";
            AddGameButton.UseVisualStyleBackColor = true;
            AddGameButton.Click += AddGameButton_Click;
            // 
            // SignOutButton
            // 
            SignOutButton.Anchor = AnchorStyles.Right;
            SignOutButton.AutoSize = true;
            SignOutButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SignOutButton.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            SignOutButton.Location = new Point(498, 9);
            SignOutButton.Margin = new Padding(0);
            SignOutButton.Name = "SignOutButton";
            SignOutButton.Size = new Size(63, 23);
            SignOutButton.TabIndex = 14;
            SignOutButton.Text = "Sign Out";
            SignOutButton.UseVisualStyleBackColor = true;
            SignOutButton.Click += SignOutButton_Click;
            // 
            // GameView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(572, 345);
            Controls.Add(SignOutButton);
            Controls.Add(AddGameButton);
            Controls.Add(PlayedGamesLabel);
            Controls.Add(GamesList);
            Controls.Add(OtherReviews);
            Controls.Add(label1);
            Controls.Add(YourReview);
            Controls.Add(ReviewLabel);
            Controls.Add(PlatformLabel);
            Controls.Add(GenreLabel);
            Controls.Add(ReleaseDateLabel);
            Controls.Add(GameTitleLabel);
            Margin = new Padding(2);
            Name = "GameView";
            Text = "GameTrack";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label GameTitleLabel;
        private Label ReleaseDateLabel;
        private Label GenreLabel;
        private Label PlatformLabel;
        private Label ReviewLabel;
        private ReviewControl YourReview;
        private Label label1;
        private ReviewControl reviewControl2;
        private FlowLayoutPanel OtherReviews;
        private ReviewControl reviewControl3;
        private ReviewControl reviewControl4;
        private ReviewControl reviewControl5;
        private ReviewControl reviewControl6;
        private ListView GamesList;
        private Label PlayedGamesLabel;
        private Button AddGameButton;
        private Button SignOutButton;
    }
}