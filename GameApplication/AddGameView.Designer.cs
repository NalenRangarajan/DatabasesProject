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
            GenreListView = new ListView();
            GenreLabel = new Label();
            MInDatePicker = new DateTimePicker();
            MaxDatePicker = new DateTimePicker();
            ReleaseDateLabel = new Label();
            FromLabel = new Label();
            ToLabel = new Label();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            MinLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            SearchLabel = new Label();
            TitleRadioButton = new RadioButton();
            PublisherRadioButton = new RadioButton();
            DeveloperRadioButton = new RadioButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // GenreListView
            // 
            GenreListView.BackColor = SystemColors.Control;
            GenreListView.BorderStyle = BorderStyle.None;
            GenreListView.CheckBoxes = true;
            GenreListView.Location = new Point(182, 32);
            GenreListView.Name = "GenreListView";
            GenreListView.Size = new Size(161, 270);
            GenreListView.TabIndex = 0;
            GenreListView.UseCompatibleStateImageBehavior = false;
            GenreListView.View = View.List;
            // 
            // GenreLabel
            // 
            GenreLabel.AutoSize = true;
            GenreLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            GenreLabel.Location = new Point(182, 9);
            GenreLabel.Name = "GenreLabel";
            GenreLabel.Size = new Size(58, 20);
            GenreLabel.TabIndex = 1;
            GenreLabel.Text = "Genres";
            // 
            // MInDatePicker
            // 
            MInDatePicker.Format = DateTimePickerFormat.Short;
            MInDatePicker.Location = new Point(49, 169);
            MInDatePicker.Name = "MInDatePicker";
            MInDatePicker.ShowUpDown = true;
            MInDatePicker.Size = new Size(82, 23);
            MInDatePicker.TabIndex = 2;
            // 
            // MaxDatePicker
            // 
            MaxDatePicker.Format = DateTimePickerFormat.Short;
            MaxDatePicker.Location = new Point(49, 195);
            MaxDatePicker.Name = "MaxDatePicker";
            MaxDatePicker.ShowUpDown = true;
            MaxDatePicker.Size = new Size(82, 23);
            MaxDatePicker.TabIndex = 3;
            // 
            // ReleaseDateLabel
            // 
            ReleaseDateLabel.AutoSize = true;
            ReleaseDateLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            ReleaseDateLabel.Location = new Point(8, 146);
            ReleaseDateLabel.Name = "ReleaseDateLabel";
            ReleaseDateLabel.Size = new Size(99, 20);
            ReleaseDateLabel.TabIndex = 4;
            ReleaseDateLabel.Text = "Release Date";
            // 
            // FromLabel
            // 
            FromLabel.AutoSize = true;
            FromLabel.Location = new Point(8, 169);
            FromLabel.Name = "FromLabel";
            FromLabel.Size = new Size(35, 15);
            FromLabel.TabIndex = 5;
            FromLabel.Text = "From";
            // 
            // ToLabel
            // 
            ToLabel.AutoSize = true;
            ToLabel.Location = new Point(11, 195);
            ToLabel.Name = "ToLabel";
            ToLabel.Size = new Size(19, 15);
            ToLabel.TabIndex = 6;
            ToLabel.Text = "To";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(55, 279);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(52, 23);
            numericUpDown1.TabIndex = 7;
            numericUpDown1.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(55, 253);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(52, 23);
            numericUpDown2.TabIndex = 8;
            // 
            // MinLabel
            // 
            MinLabel.AutoSize = true;
            MinLabel.Location = new Point(8, 255);
            MinLabel.Name = "MinLabel";
            MinLabel.Size = new Size(28, 15);
            MinLabel.TabIndex = 9;
            MinLabel.Text = "Min";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 281);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 10;
            label2.Text = "Max";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(8, 230);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 11;
            label3.Text = "Avg User Score";
            // 
            // SearchLabel
            // 
            SearchLabel.AutoSize = true;
            SearchLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            SearchLabel.Location = new Point(8, 9);
            SearchLabel.Name = "SearchLabel";
            SearchLabel.Size = new Size(55, 20);
            SearchLabel.TabIndex = 12;
            SearchLabel.Text = "Search";
            // 
            // TitleRadioButton
            // 
            TitleRadioButton.AutoSize = true;
            TitleRadioButton.Location = new Point(3, 3);
            TitleRadioButton.Name = "TitleRadioButton";
            TitleRadioButton.Size = new Size(47, 19);
            TitleRadioButton.TabIndex = 13;
            TitleRadioButton.TabStop = true;
            TitleRadioButton.Text = "Title";
            TitleRadioButton.UseVisualStyleBackColor = true;
            // 
            // PublisherRadioButton
            // 
            PublisherRadioButton.AutoSize = true;
            PublisherRadioButton.Location = new Point(3, 28);
            PublisherRadioButton.Name = "PublisherRadioButton";
            PublisherRadioButton.Size = new Size(74, 19);
            PublisherRadioButton.TabIndex = 14;
            PublisherRadioButton.TabStop = true;
            PublisherRadioButton.Text = "Publisher";
            PublisherRadioButton.UseVisualStyleBackColor = true;
            // 
            // DeveloperRadioButton
            // 
            DeveloperRadioButton.AutoSize = true;
            DeveloperRadioButton.Location = new Point(3, 53);
            DeveloperRadioButton.Name = "DeveloperRadioButton";
            DeveloperRadioButton.Size = new Size(78, 19);
            DeveloperRadioButton.TabIndex = 15;
            DeveloperRadioButton.TabStop = true;
            DeveloperRadioButton.Text = "Developer";
            DeveloperRadioButton.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(TitleRadioButton);
            flowLayoutPanel1.Controls.Add(PublisherRadioButton);
            flowLayoutPanel1.Controls.Add(DeveloperRadioButton);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(8, 58);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(84, 75);
            flowLayoutPanel1.TabIndex = 16;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(8, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(169, 23);
            textBox1.TabIndex = 17;
            // 
            // AddGameView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 311);
            Controls.Add(textBox1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(SearchLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(MinLabel);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(ToLabel);
            Controls.Add(FromLabel);
            Controls.Add(ReleaseDateLabel);
            Controls.Add(MaxDatePicker);
            Controls.Add(MInDatePicker);
            Controls.Add(GenreLabel);
            Controls.Add(GenreListView);
            Name = "AddGameView";
            Text = "Add Review";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView GenreListView;
        private Label GenreLabel;
        private DateTimePicker MInDatePicker;
        private DateTimePicker MaxDatePicker;
        private Label ReleaseDateLabel;
        private Label FromLabel;
        private Label ToLabel;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label MinLabel;
        private Label label2;
        private Label label3;
        private Label SearchLabel;
        private RadioButton TitleRadioButton;
        private RadioButton PublisherRadioButton;
        private RadioButton DeveloperRadioButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox textBox1;
    }
}