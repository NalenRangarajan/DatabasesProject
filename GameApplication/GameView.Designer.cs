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
            GamesList = new FlowLayoutPanel();
            GameTitleLabel = new Label();
            ReleaseDateLabel = new Label();
            GenreLabel = new Label();
            PlatformLabel = new Label();
            ReviewLabel = new Label();
            reviewControl1 = new ReviewControl();
            label1 = new Label();
            OtherReviews = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // GamesList
            // 
            GamesList.AutoSize = true;
            GamesList.FlowDirection = FlowDirection.TopDown;
            GamesList.Location = new Point(11, 11);
            GamesList.Margin = new Padding(2);
            GamesList.Name = "GamesList";
            GamesList.Size = new Size(245, 276);
            GamesList.TabIndex = 0;
            GamesList.WrapContents = false;
            // 
            // GameTitleLabel
            // 
            GameTitleLabel.AutoSize = true;
            GameTitleLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            GameTitleLabel.Location = new Point(368, 23);
            GameTitleLabel.Margin = new Padding(2, 0, 2, 0);
            GameTitleLabel.Name = "GameTitleLabel";
            GameTitleLabel.Size = new Size(85, 20);
            GameTitleLabel.TabIndex = 1;
            GameTitleLabel.Text = "Game Title";
            // 
            // ReleaseDateLabel
            // 
            ReleaseDateLabel.AutoSize = true;
            ReleaseDateLabel.Location = new Point(261, 46);
            ReleaseDateLabel.Margin = new Padding(2, 0, 2, 0);
            ReleaseDateLabel.Name = "ReleaseDateLabel";
            ReleaseDateLabel.Size = new Size(59, 15);
            ReleaseDateLabel.TabIndex = 2;
            ReleaseDateLabel.Text = "Released: ";
            // 
            // GenreLabel
            // 
            GenreLabel.AutoSize = true;
            GenreLabel.Location = new Point(261, 61);
            GenreLabel.Margin = new Padding(2, 0, 2, 0);
            GenreLabel.Name = "GenreLabel";
            GenreLabel.Size = new Size(44, 15);
            GenreLabel.TabIndex = 3;
            GenreLabel.Text = "Genre: ";
            // 
            // PlatformLabel
            // 
            PlatformLabel.AutoSize = true;
            PlatformLabel.Location = new Point(261, 76);
            PlatformLabel.Name = "PlatformLabel";
            PlatformLabel.Size = new Size(56, 15);
            PlatformLabel.TabIndex = 4;
            PlatformLabel.Text = "Platform:";
            // 
            // ReviewLabel
            // 
            ReviewLabel.AutoSize = true;
            ReviewLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            ReviewLabel.Location = new Point(368, 91);
            ReviewLabel.Margin = new Padding(2, 0, 2, 0);
            ReviewLabel.Name = "ReviewLabel";
            ReviewLabel.Size = new Size(95, 20);
            ReviewLabel.TabIndex = 5;
            ReviewLabel.Text = "Your Review";
            // 
            // reviewControl1
            // 
            reviewControl1.AutoScroll = true;
            reviewControl1.AutoSize = true;
            reviewControl1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            reviewControl1.Body = "Body";
            reviewControl1.ForeColor = SystemColors.ControlText;
            reviewControl1.Location = new Point(261, 111);
            reviewControl1.Margin = new Padding(0);
            reviewControl1.MaximumSize = new Size(300, 96);
            reviewControl1.Name = "reviewControl1";
            reviewControl1.ReviewDate = "Date";
            reviewControl1.Score = "#/10";
            reviewControl1.Size = new Size(300, 80);
            reviewControl1.TabIndex = 7;
            reviewControl1.Title = "TItle";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(368, 208);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 8;
            label1.Text = "Other Reviews";
            // 
            // OtherReviews
            // 
            OtherReviews.AutoScroll = true;
            OtherReviews.Location = new Point(261, 231);
            OtherReviews.Name = "OtherReviews";
            OtherReviews.Size = new Size(300, 138);
            OtherReviews.TabIndex = 10;
            // 
            // GameView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(568, 381);
            Controls.Add(OtherReviews);
            Controls.Add(label1);
            Controls.Add(reviewControl1);
            Controls.Add(ReviewLabel);
            Controls.Add(PlatformLabel);
            Controls.Add(GenreLabel);
            Controls.Add(ReleaseDateLabel);
            Controls.Add(GameTitleLabel);
            Controls.Add(GamesList);
            Margin = new Padding(2);
            Name = "GameView";
            Text = "GameTrack";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel GamesList;
        private Label GameTitleLabel;
        private Label ReleaseDateLabel;
        private Label GenreLabel;
        private Label PlatformLabel;
        private Label ReviewLabel;
        private ReviewControl reviewControl1;
        private Label label1;
        private ReviewControl reviewControl2;
        private FlowLayoutPanel OtherReviews;
        private ReviewControl reviewControl3;
        private ReviewControl reviewControl4;
        private ReviewControl reviewControl5;
        private ReviewControl reviewControl6;
    }
}