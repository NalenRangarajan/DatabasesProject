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
            TitleLabel = new Label();
            ReleaseDateLabel = new Label();
            GenreLabel = new Label();
            DeveloperLabel = new Label();
            PublisherLabel = new Label();
            ReleaseDatePicker = new DateTimePicker();
            PublisherTextBox = new TextBox();
            DeveloperTextBox = new TextBox();
            GenreTextBox = new TextBox();
            TitleTextBox = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            flowLayoutPanel5 = new FlowLayoutPanel();
            flowLayoutPanel6 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(86, 233);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(112, 34);
            SubmitButton.TabIndex = 0;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Location = new Point(3, 0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(98, 25);
            TitleLabel.TabIndex = 1;
            TitleLabel.Text = "Title:          ";
            // 
            // ReleaseDateLabel
            // 
            ReleaseDateLabel.AutoSize = true;
            ReleaseDateLabel.Location = new Point(3, 0);
            ReleaseDateLabel.Name = "ReleaseDateLabel";
            ReleaseDateLabel.Size = new Size(116, 25);
            ReleaseDateLabel.TabIndex = 2;
            ReleaseDateLabel.Text = "Release Date:";
            // 
            // GenreLabel
            // 
            GenreLabel.AutoSize = true;
            GenreLabel.Location = new Point(3, 0);
            GenreLabel.Name = "GenreLabel";
            GenreLabel.Size = new Size(97, 25);
            GenreLabel.TabIndex = 3;
            GenreLabel.Text = "Genre:       ";
            // 
            // DeveloperLabel
            // 
            DeveloperLabel.AutoSize = true;
            DeveloperLabel.Location = new Point(3, 0);
            DeveloperLabel.Name = "DeveloperLabel";
            DeveloperLabel.Size = new Size(97, 25);
            DeveloperLabel.TabIndex = 4;
            DeveloperLabel.Text = "Developer:";
            // 
            // PublisherLabel
            // 
            PublisherLabel.AutoSize = true;
            PublisherLabel.Location = new Point(3, 0);
            PublisherLabel.Name = "PublisherLabel";
            PublisherLabel.Size = new Size(98, 25);
            PublisherLabel.TabIndex = 5;
            PublisherLabel.Text = "Publisher:  ";
            // 
            // ReleaseDatePicker
            // 
            ReleaseDatePicker.Format = DateTimePickerFormat.Short;
            ReleaseDatePicker.Location = new Point(125, 3);
            ReleaseDatePicker.Name = "ReleaseDatePicker";
            ReleaseDatePicker.Size = new Size(130, 31);
            ReleaseDatePicker.TabIndex = 6;
            // 
            // PublisherTextBox
            // 
            PublisherTextBox.Location = new Point(107, 3);
            PublisherTextBox.Name = "PublisherTextBox";
            PublisherTextBox.Size = new Size(150, 31);
            PublisherTextBox.TabIndex = 7;
            // 
            // DeveloperTextBox
            // 
            DeveloperTextBox.Location = new Point(106, 3);
            DeveloperTextBox.Name = "DeveloperTextBox";
            DeveloperTextBox.Size = new Size(150, 31);
            DeveloperTextBox.TabIndex = 8;
            // 
            // GenreTextBox
            // 
            GenreTextBox.Location = new Point(106, 3);
            GenreTextBox.Name = "GenreTextBox";
            GenreTextBox.Size = new Size(150, 31);
            GenreTextBox.TabIndex = 9;
            // 
            // TitleTextBox
            // 
            TitleTextBox.Location = new Point(107, 3);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(150, 31);
            TitleTextBox.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel4);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel5);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel6);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel3);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(12, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(266, 215);
            flowLayoutPanel1.TabIndex = 11;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.Controls.Add(TitleLabel);
            flowLayoutPanel2.Controls.Add(TitleTextBox);
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(260, 37);
            flowLayoutPanel2.TabIndex = 12;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.AutoSize = true;
            flowLayoutPanel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel4.Controls.Add(GenreLabel);
            flowLayoutPanel4.Controls.Add(GenreTextBox);
            flowLayoutPanel4.Location = new Point(3, 46);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(259, 37);
            flowLayoutPanel4.TabIndex = 14;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.AutoSize = true;
            flowLayoutPanel5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel5.Controls.Add(PublisherLabel);
            flowLayoutPanel5.Controls.Add(PublisherTextBox);
            flowLayoutPanel5.Location = new Point(3, 89);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(260, 37);
            flowLayoutPanel5.TabIndex = 14;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.AutoSize = true;
            flowLayoutPanel6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel6.Controls.Add(DeveloperLabel);
            flowLayoutPanel6.Controls.Add(DeveloperTextBox);
            flowLayoutPanel6.Location = new Point(3, 132);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(259, 37);
            flowLayoutPanel6.TabIndex = 15;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel3.Controls.Add(ReleaseDateLabel);
            flowLayoutPanel3.Controls.Add(ReleaseDatePicker);
            flowLayoutPanel3.Location = new Point(3, 175);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(258, 37);
            flowLayoutPanel3.TabIndex = 13;
            // 
            // AddGameView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 277);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(SubmitButton);
            Name = "AddGameView";
            Text = "Add Game";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            flowLayoutPanel6.ResumeLayout(false);
            flowLayoutPanel6.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SubmitButton;
        private Label TitleLabel;
        private Label ReleaseDateLabel;
        private Label GenreLabel;
        private Label DeveloperLabel;
        private Label PublisherLabel;
        private DateTimePicker ReleaseDatePicker;
        private TextBox PublisherTextBox;
        private TextBox DeveloperTextBox;
        private TextBox GenreTextBox;
        private TextBox TitleTextBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel5;
        private FlowLayoutPanel flowLayoutPanel6;
    }
}