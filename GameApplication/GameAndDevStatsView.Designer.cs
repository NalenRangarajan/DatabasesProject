namespace GameApplication
{
	partial class GameAndDevStatsView
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			DevelopersList = new ListView();
			GamesList = new ListView();
			DevStatsLabel = new Label();
			GameStatsLabel = new Label();
			SuspendLayout();
			// 
			// DevelopersList
			// 
			DevelopersList.Activation = ItemActivation.OneClick;
			DevelopersList.Location = new Point(9, 61);
			DevelopersList.Margin = new Padding(4, 5, 4, 5);
			DevelopersList.MultiSelect = false;
			DevelopersList.Name = "DevelopersList";
			DevelopersList.Size = new Size(599, 629);
			DevelopersList.TabIndex = 12;
			DevelopersList.TileSize = new Size(500, 30);
			DevelopersList.UseCompatibleStateImageBehavior = false;
			DevelopersList.View = View.Tile;
			// 
			// GamesList
			// 
			GamesList.Activation = ItemActivation.OneClick;
			GamesList.Location = new Point(616, 61);
			GamesList.Margin = new Padding(4, 5, 4, 5);
			GamesList.MultiSelect = false;
			GamesList.Name = "GamesList";
			GamesList.Size = new Size(599, 629);
			GamesList.TabIndex = 13;
			GamesList.TileSize = new Size(500, 30);
			GamesList.UseCompatibleStateImageBehavior = false;
			GamesList.View = View.Tile;
			// 
			// DevStatsLabel
			// 
			DevStatsLabel.AutoSize = true;
			DevStatsLabel.Location = new Point(13, 31);
			DevStatsLabel.Name = "DevStatsLabel";
			DevStatsLabel.Size = new Size(166, 25);
			DevStatsLabel.TabIndex = 14;
			DevStatsLabel.Text = "Developer Statistics";
			// 
			// GameStatsLabel
			// 
			GameStatsLabel.AutoSize = true;
			GameStatsLabel.Location = new Point(620, 31);
			GameStatsLabel.Name = "GameStatsLabel";
			GameStatsLabel.Size = new Size(131, 25);
			GameStatsLabel.TabIndex = 15;
			GameStatsLabel.Text = "Game Statistics";
			// 
			// GameAndDevStatsView
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1220, 704);
			Controls.Add(GameStatsLabel);
			Controls.Add(DevStatsLabel);
			Controls.Add(GamesList);
			Controls.Add(DevelopersList);
			Name = "GameAndDevStatsView";
			Text = "GameAndDevStatsView";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ListView DevelopersList;
		private ListView GamesList;
		private Label DevStatsLabel;
		private Label GameStatsLabel;
	}
}