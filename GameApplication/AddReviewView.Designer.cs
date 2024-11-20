namespace GameApplication
{
    partial class AddReviewView
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
            GenreListView = new ListView();
            GenreLabel = new Label();
            MinDatePicker = new DateTimePicker();
            MaxDatePicker = new DateTimePicker();
            ReleaseDateLabel = new Label();
            FromLabel = new Label();
            ToLabel = new Label();
            MaxUpDown = new NumericUpDown();
            MinUpDown = new NumericUpDown();
            MinLabel = new Label();
            MaxLabel = new Label();
            AvgUserScoreLabel = new Label();
            SearchLabel = new Label();
            TitleRadioButton = new RadioButton();
            PublisherRadioButton = new RadioButton();
            DeveloperRadioButton = new RadioButton();
            RadioButtonPanel = new FlowLayoutPanel();
            SearchBox = new TextBox();
            GamesList = new ListView();
            GamesLabel = new Label();
            AddGameButton = new Button();
            ((System.ComponentModel.ISupportInitialize)MaxUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinUpDown).BeginInit();
            RadioButtonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // GenreListView
            // 
            GenreListView.BackColor = SystemColors.Control;
            GenreListView.BorderStyle = BorderStyle.None;
            GenreListView.CheckBoxes = true;
            GenreListView.Location = new Point(597, 52);
            GenreListView.Margin = new Padding(4, 5, 4, 5);
            GenreListView.Name = "GenreListView";
            GenreListView.Size = new Size(230, 450);
            GenreListView.TabIndex = 0;
            GenreListView.UseCompatibleStateImageBehavior = false;
            GenreListView.View = View.List;
            // 
            // GenreLabel
            // 
            GenreLabel.AutoSize = true;
            GenreLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            GenreLabel.Location = new Point(597, 14);
            GenreLabel.Margin = new Padding(4, 0, 4, 0);
            GenreLabel.Name = "GenreLabel";
            GenreLabel.Size = new Size(85, 30);
            GenreLabel.TabIndex = 1;
            GenreLabel.Text = "Genres";
            // 
            // MinDatePicker
            // 
            MinDatePicker.Format = DateTimePickerFormat.Short;
            MinDatePicker.Location = new Point(407, 281);
            MinDatePicker.Margin = new Padding(4, 5, 4, 5);
            MinDatePicker.Name = "MinDatePicker";
            MinDatePicker.ShowUpDown = true;
            MinDatePicker.Size = new Size(128, 31);
            MinDatePicker.TabIndex = 2;
            // 
            // MaxDatePicker
            // 
            MaxDatePicker.Format = DateTimePickerFormat.Short;
            MaxDatePicker.Location = new Point(407, 324);
            MaxDatePicker.Margin = new Padding(4, 5, 4, 5);
            MaxDatePicker.Name = "MaxDatePicker";
            MaxDatePicker.ShowUpDown = true;
            MaxDatePicker.Size = new Size(128, 31);
            MaxDatePicker.TabIndex = 3;
            // 
            // ReleaseDateLabel
            // 
            ReleaseDateLabel.AutoSize = true;
            ReleaseDateLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            ReleaseDateLabel.Location = new Point(348, 242);
            ReleaseDateLabel.Margin = new Padding(4, 0, 4, 0);
            ReleaseDateLabel.Name = "ReleaseDateLabel";
            ReleaseDateLabel.Size = new Size(145, 30);
            ReleaseDateLabel.TabIndex = 4;
            ReleaseDateLabel.Text = "Release Date";
            // 
            // FromLabel
            // 
            FromLabel.AutoSize = true;
            FromLabel.Location = new Point(348, 281);
            FromLabel.Margin = new Padding(4, 0, 4, 0);
            FromLabel.Name = "FromLabel";
            FromLabel.Size = new Size(54, 25);
            FromLabel.TabIndex = 5;
            FromLabel.Text = "From";
            // 
            // ToLabel
            // 
            ToLabel.AutoSize = true;
            ToLabel.Location = new Point(348, 324);
            ToLabel.Margin = new Padding(4, 0, 4, 0);
            ToLabel.Name = "ToLabel";
            ToLabel.Size = new Size(30, 25);
            ToLabel.TabIndex = 6;
            ToLabel.Text = "To";
            // 
            // MaxUpDown
            // 
            MaxUpDown.Location = new Point(416, 464);
            MaxUpDown.Margin = new Padding(4, 5, 4, 5);
            MaxUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            MaxUpDown.Name = "MaxUpDown";
            MaxUpDown.Size = new Size(74, 31);
            MaxUpDown.TabIndex = 7;
            MaxUpDown.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // MinUpDown
            // 
            MinUpDown.Location = new Point(416, 421);
            MinUpDown.Margin = new Padding(4, 5, 4, 5);
            MinUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            MinUpDown.Name = "MinUpDown";
            MinUpDown.Size = new Size(74, 31);
            MinUpDown.TabIndex = 8;
            // 
            // MinLabel
            // 
            MinLabel.AutoSize = true;
            MinLabel.Location = new Point(348, 424);
            MinLabel.Margin = new Padding(4, 0, 4, 0);
            MinLabel.Name = "MinLabel";
            MinLabel.Size = new Size(42, 25);
            MinLabel.TabIndex = 9;
            MinLabel.Text = "Min";
            // 
            // MaxLabel
            // 
            MaxLabel.AutoSize = true;
            MaxLabel.Location = new Point(348, 467);
            MaxLabel.Margin = new Padding(4, 0, 4, 0);
            MaxLabel.Name = "MaxLabel";
            MaxLabel.Size = new Size(45, 25);
            MaxLabel.TabIndex = 10;
            MaxLabel.Text = "Max";
            // 
            // AvgUserScoreLabel
            // 
            AvgUserScoreLabel.AutoSize = true;
            AvgUserScoreLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            AvgUserScoreLabel.Location = new Point(348, 382);
            AvgUserScoreLabel.Margin = new Padding(4, 0, 4, 0);
            AvgUserScoreLabel.Name = "AvgUserScoreLabel";
            AvgUserScoreLabel.Size = new Size(170, 30);
            AvgUserScoreLabel.TabIndex = 11;
            AvgUserScoreLabel.Text = "Avg User Score";
            // 
            // SearchLabel
            // 
            SearchLabel.AutoSize = true;
            SearchLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            SearchLabel.Location = new Point(348, 14);
            SearchLabel.Margin = new Padding(4, 0, 4, 0);
            SearchLabel.Name = "SearchLabel";
            SearchLabel.Size = new Size(82, 30);
            SearchLabel.TabIndex = 12;
            SearchLabel.Text = "Search";
            // 
            // TitleRadioButton
            // 
            TitleRadioButton.AutoSize = true;
            TitleRadioButton.Checked = true;
            TitleRadioButton.Location = new Point(4, 5);
            TitleRadioButton.Margin = new Padding(4, 5, 4, 5);
            TitleRadioButton.Name = "TitleRadioButton";
            TitleRadioButton.Size = new Size(69, 29);
            TitleRadioButton.TabIndex = 13;
            TitleRadioButton.TabStop = true;
            TitleRadioButton.Text = "Title";
            TitleRadioButton.UseVisualStyleBackColor = true;
            // 
            // PublisherRadioButton
            // 
            PublisherRadioButton.AutoSize = true;
            PublisherRadioButton.Location = new Point(4, 44);
            PublisherRadioButton.Margin = new Padding(4, 5, 4, 5);
            PublisherRadioButton.Name = "PublisherRadioButton";
            PublisherRadioButton.Size = new Size(109, 29);
            PublisherRadioButton.TabIndex = 14;
            PublisherRadioButton.Text = "Publisher";
            PublisherRadioButton.UseVisualStyleBackColor = true;
            // 
            // DeveloperRadioButton
            // 
            DeveloperRadioButton.AutoSize = true;
            DeveloperRadioButton.Location = new Point(4, 83);
            DeveloperRadioButton.Margin = new Padding(4, 5, 4, 5);
            DeveloperRadioButton.Name = "DeveloperRadioButton";
            DeveloperRadioButton.Size = new Size(118, 29);
            DeveloperRadioButton.TabIndex = 15;
            DeveloperRadioButton.Text = "Developer";
            DeveloperRadioButton.UseVisualStyleBackColor = true;
            // 
            // RadioButtonPanel
            // 
            RadioButtonPanel.AutoSize = true;
            RadioButtonPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            RadioButtonPanel.Controls.Add(TitleRadioButton);
            RadioButtonPanel.Controls.Add(PublisherRadioButton);
            RadioButtonPanel.Controls.Add(DeveloperRadioButton);
            RadioButtonPanel.FlowDirection = FlowDirection.TopDown;
            RadioButtonPanel.Location = new Point(348, 96);
            RadioButtonPanel.Margin = new Padding(4, 5, 4, 5);
            RadioButtonPanel.Name = "RadioButtonPanel";
            RadioButtonPanel.Size = new Size(126, 117);
            RadioButtonPanel.TabIndex = 16;
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(348, 52);
            SearchBox.Margin = new Padding(4, 5, 4, 5);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(240, 31);
            SearchBox.TabIndex = 17;
            // 
            // GamesList
            // 
            GamesList.Activation = ItemActivation.OneClick;
            GamesList.Location = new Point(13, 52);
            GamesList.Margin = new Padding(4, 5, 4, 5);
            GamesList.MultiSelect = false;
            GamesList.Name = "GamesList";
            GamesList.Size = new Size(327, 450);
            GamesList.TabIndex = 18;
            GamesList.TileSize = new Size(500, 30);
            GamesList.UseCompatibleStateImageBehavior = false;
            GamesList.View = View.Tile;
            GamesList.Click += GamesList_Click;
            // 
            // GamesLabel
            // 
            GamesLabel.AutoSize = true;
            GamesLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            GamesLabel.Location = new Point(13, 14);
            GamesLabel.Margin = new Padding(4, 0, 4, 0);
            GamesLabel.Name = "GamesLabel";
            GamesLabel.Size = new Size(86, 30);
            GamesLabel.TabIndex = 19;
            GamesLabel.Text = "Results";
            // 
            // AddGameButton
            // 
            AddGameButton.Location = new Point(228, 10);
            AddGameButton.Name = "AddGameButton";
            AddGameButton.Size = new Size(112, 34);
            AddGameButton.TabIndex = 20;
            AddGameButton.Text = "Add Game";
            AddGameButton.UseVisualStyleBackColor = true;
            AddGameButton.Click += AddGameButton_Click;
            // 
            // AddGameView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 517);
            Controls.Add(AddGameButton);
            Controls.Add(GamesLabel);
            Controls.Add(GamesList);
            Controls.Add(SearchBox);
            Controls.Add(RadioButtonPanel);
            Controls.Add(SearchLabel);
            Controls.Add(AvgUserScoreLabel);
            Controls.Add(MaxLabel);
            Controls.Add(MinLabel);
            Controls.Add(MinUpDown);
            Controls.Add(MaxUpDown);
            Controls.Add(ToLabel);
            Controls.Add(FromLabel);
            Controls.Add(ReleaseDateLabel);
            Controls.Add(MaxDatePicker);
            Controls.Add(MinDatePicker);
            Controls.Add(GenreLabel);
            Controls.Add(GenreListView);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AddGameView";
            Text = "Add Review";
            ((System.ComponentModel.ISupportInitialize)MaxUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinUpDown).EndInit();
            RadioButtonPanel.ResumeLayout(false);
            RadioButtonPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private ListView GenreListView;
        private Label GenreLabel;
        private DateTimePicker MinDatePicker;
        private DateTimePicker MaxDatePicker;
        private Label ReleaseDateLabel;
        private Label FromLabel;
        private Label ToLabel;
        private NumericUpDown MaxUpDown;
        private NumericUpDown MinUpDown;
        private Label MinLabel;
        private Label MaxLabel;
        private Label AvgUserScoreLabel;
        private Label SearchLabel;
        private RadioButton TitleRadioButton;
        private RadioButton PublisherRadioButton;
        private RadioButton DeveloperRadioButton;
        private FlowLayoutPanel RadioButtonPanel;
        private TextBox SearchBox;
        private ListView GamesList;
        private Label GamesLabel;
        private Button AddGameButton;
    }
}