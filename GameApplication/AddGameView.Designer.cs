namespace GameApplication
{
	partial class AddGameView
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
			SubmitButton = new Button();
			ReleaseDatePicker = new DateTimePicker();
			ReleaseDateLabel = new Label();
			DeveloperTextBox = new TextBox();
			DeveloperLabel = new Label();
			PublisherTextBox = new TextBox();
			PublisherLabel = new Label();
			GenreLabel = new Label();
			GenreComboBox = new ComboBox();
			TitleTextBox = new TextBox();
			TitleLabel = new Label();
			SuspendLayout();
			// 
			// SubmitButton
			// 
			SubmitButton.Location = new Point(75, 227);
			SubmitButton.Name = "SubmitButton";
			SubmitButton.Size = new Size(112, 34);
			SubmitButton.TabIndex = 0;
			SubmitButton.Text = "Submit";
			SubmitButton.UseVisualStyleBackColor = true;
			SubmitButton.Click += SubmitButton_Click;
			// 
			// ReleaseDatePicker
			// 
			ReleaseDatePicker.Format = DateTimePickerFormat.Short;
			ReleaseDatePicker.Location = new Point(148, 190);
			ReleaseDatePicker.Name = "ReleaseDatePicker";
			ReleaseDatePicker.Size = new Size(130, 31);
			ReleaseDatePicker.TabIndex = 6;
			// 
			// ReleaseDateLabel
			// 
			ReleaseDateLabel.AutoSize = true;
			ReleaseDateLabel.Location = new Point(15, 190);
			ReleaseDateLabel.Name = "ReleaseDateLabel";
			ReleaseDateLabel.Size = new Size(116, 25);
			ReleaseDateLabel.TabIndex = 2;
			ReleaseDateLabel.Text = "Release Date:";
			// 
			// DeveloperTextBox
			// 
			DeveloperTextBox.Location = new Point(128, 139);
			DeveloperTextBox.Name = "DeveloperTextBox";
			DeveloperTextBox.Size = new Size(150, 31);
			DeveloperTextBox.TabIndex = 8;
			// 
			// DeveloperLabel
			// 
			DeveloperLabel.AutoSize = true;
			DeveloperLabel.Location = new Point(15, 139);
			DeveloperLabel.Name = "DeveloperLabel";
			DeveloperLabel.Size = new Size(97, 25);
			DeveloperLabel.TabIndex = 4;
			DeveloperLabel.Text = "Developer:";
			// 
			// PublisherTextBox
			// 
			PublisherTextBox.Location = new Point(128, 88);
			PublisherTextBox.Name = "PublisherTextBox";
			PublisherTextBox.Size = new Size(150, 31);
			PublisherTextBox.TabIndex = 7;
			// 
			// PublisherLabel
			// 
			PublisherLabel.AutoSize = true;
			PublisherLabel.Location = new Point(15, 88);
			PublisherLabel.Name = "PublisherLabel";
			PublisherLabel.Size = new Size(98, 25);
			PublisherLabel.TabIndex = 5;
			PublisherLabel.Text = "Publisher:  ";
			// 
			// GenreLabel
			// 
			GenreLabel.AutoSize = true;
			GenreLabel.Location = new Point(15, 46);
			GenreLabel.Name = "GenreLabel";
			GenreLabel.Size = new Size(97, 25);
			GenreLabel.TabIndex = 3;
			GenreLabel.Text = "Genre:       ";
			// 
			// GenreComboBox
			// 
			GenreComboBox.FormattingEnabled = true;
			GenreComboBox.Location = new Point(128, 43);
			GenreComboBox.Name = "GenreComboBox";
			GenreComboBox.Size = new Size(150, 33);
			GenreComboBox.TabIndex = 12;
			// 
			// TitleTextBox
			// 
			TitleTextBox.Location = new Point(128, 6);
			TitleTextBox.Name = "TitleTextBox";
			TitleTextBox.Size = new Size(150, 31);
			TitleTextBox.TabIndex = 10;
			// 
			// TitleLabel
			// 
			TitleLabel.AutoSize = true;
			TitleLabel.Location = new Point(15, 9);
			TitleLabel.Name = "TitleLabel";
			TitleLabel.Size = new Size(98, 25);
			TitleLabel.TabIndex = 1;
			TitleLabel.Text = "Title:          ";
			// 
			// AddGameView
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(290, 274);
			Controls.Add(TitleTextBox);
			Controls.Add(TitleLabel);
			Controls.Add(ReleaseDateLabel);
			Controls.Add(DeveloperLabel);
			Controls.Add(ReleaseDatePicker);
			Controls.Add(PublisherTextBox);
			Controls.Add(DeveloperTextBox);
			Controls.Add(PublisherLabel);
			Controls.Add(GenreLabel);
			Controls.Add(GenreComboBox);
			Controls.Add(SubmitButton);
			Name = "AddGameView";
			Text = "Add Game";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button SubmitButton;
		private DateTimePicker ReleaseDatePicker;
		private Label ReleaseDateLabel;
		private TextBox DeveloperTextBox;
		private Label DeveloperLabel;
		private TextBox PublisherTextBox;
		private Label PublisherLabel;
		private Label GenreLabel;
		private ComboBox GenreComboBox;
		private TextBox TitleTextBox;
		private Label TitleLabel;
	}
}