namespace GameApplication
{
    partial class WriteReview
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
            ScoreLabel = new Label();
            BodyLabel = new Label();
            SubmitButton = new Button();
            ScoreUpDown = new NumericUpDown();
            BodyTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ScoreUpDown).BeginInit();
            SuspendLayout();
            // 
            // ScoreLabel
            // 
            ScoreLabel.AutoSize = true;
            ScoreLabel.Location = new Point(12, 9);
            ScoreLabel.Name = "ScoreLabel";
            ScoreLabel.Size = new Size(60, 25);
            ScoreLabel.TabIndex = 0;
            ScoreLabel.Text = "Score:";
            // 
            // BodyLabel
            // 
            BodyLabel.AutoSize = true;
            BodyLabel.Location = new Point(12, 44);
            BodyLabel.Name = "BodyLabel";
            BodyLabel.Size = new Size(57, 25);
            BodyLabel.TabIndex = 1;
            BodyLabel.Text = "Body:";
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(170, 157);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(112, 34);
            SubmitButton.TabIndex = 2;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // ScoreUpDown
            // 
            ScoreUpDown.Location = new Point(78, 7);
            ScoreUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            ScoreUpDown.Name = "ScoreUpDown";
            ScoreUpDown.Size = new Size(55, 31);
            ScoreUpDown.TabIndex = 3;
            ScoreUpDown.Value = new decimal(new int[] { 7, 0, 0, 0 });
            // 
            // BodyTextBox
            // 
            BodyTextBox.Location = new Point(75, 44);
            BodyTextBox.Multiline = true;
            BodyTextBox.Name = "BodyTextBox";
            BodyTextBox.Size = new Size(363, 107);
            BodyTextBox.TabIndex = 4;
            // 
            // WriteReview
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(453, 196);
            Controls.Add(BodyTextBox);
            Controls.Add(ScoreUpDown);
            Controls.Add(SubmitButton);
            Controls.Add(BodyLabel);
            Controls.Add(ScoreLabel);
            Name = "WriteReview";
            Text = "WriteReview";
            ((System.ComponentModel.ISupportInitialize)ScoreUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ScoreLabel;
        private Label BodyLabel;
        private Button SubmitButton;
        private NumericUpDown ScoreUpDown;
        private TextBox BodyTextBox;
    }
}