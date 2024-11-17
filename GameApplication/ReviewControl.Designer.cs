namespace GameApplication
{
    partial class ReviewControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ScoreLabel = new Label();
            TitleLabel = new Label();
            BodyLabel = new Label();
            ReviewDateLabel = new Label();
            ReviewStack = new FlowLayoutPanel();
            ScoreAndTitle = new FlowLayoutPanel();
            ReviewStack.SuspendLayout();
            ScoreAndTitle.SuspendLayout();
            SuspendLayout();
            // 
            // ScoreLabel
            // 
            ScoreLabel.AutoSize = true;
            ScoreLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ScoreLabel.Location = new Point(0, 0);
            ScoreLabel.Margin = new Padding(0, 0, 2, 0);
            ScoreLabel.Name = "ScoreLabel";
            ScoreLabel.Size = new Size(33, 15);
            ScoreLabel.TabIndex = 1;
            ScoreLabel.Text = "#/10";
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Location = new Point(35, 0);
            TitleLabel.Margin = new Padding(0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(29, 15);
            TitleLabel.TabIndex = 2;
            TitleLabel.Text = "TItle";
            // 
            // BodyLabel
            // 
            BodyLabel.AutoSize = true;
            BodyLabel.Location = new Point(0, 30);
            BodyLabel.Margin = new Padding(0);
            BodyLabel.MaximumSize = new Size(295, 0);
            BodyLabel.Name = "BodyLabel";
            BodyLabel.Size = new Size(34, 15);
            BodyLabel.TabIndex = 3;
            BodyLabel.Text = "Body";
            // 
            // ReviewDateLabel
            // 
            ReviewDateLabel.AutoSize = true;
            ReviewDateLabel.Location = new Point(0, 15);
            ReviewDateLabel.Margin = new Padding(0);
            ReviewDateLabel.Name = "ReviewDateLabel";
            ReviewDateLabel.Size = new Size(31, 15);
            ReviewDateLabel.TabIndex = 4;
            ReviewDateLabel.Text = "Date";
            // 
            // ReviewStack
            // 
            ReviewStack.AutoSize = true;
            ReviewStack.Controls.Add(ScoreAndTitle);
            ReviewStack.Controls.Add(ReviewDateLabel);
            ReviewStack.Controls.Add(BodyLabel);
            ReviewStack.FlowDirection = FlowDirection.TopDown;
            ReviewStack.Location = new Point(0, 0);
            ReviewStack.Margin = new Padding(0);
            ReviewStack.Name = "ReviewStack";
            ReviewStack.Size = new Size(300, 80);
            ReviewStack.TabIndex = 5;
            // 
            // ScoreAndTitle
            // 
            ScoreAndTitle.AutoSize = true;
            ScoreAndTitle.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ScoreAndTitle.Controls.Add(ScoreLabel);
            ScoreAndTitle.Controls.Add(TitleLabel);
            ScoreAndTitle.Location = new Point(0, 0);
            ScoreAndTitle.Margin = new Padding(0);
            ScoreAndTitle.Name = "ScoreAndTitle";
            ScoreAndTitle.Size = new Size(64, 15);
            ScoreAndTitle.TabIndex = 6;
            // 
            // ReviewControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            Controls.Add(ReviewStack);
            Margin = new Padding(0);
            Name = "ReviewControl";
            Size = new Size(300, 80);
            ReviewStack.ResumeLayout(false);
            ReviewStack.PerformLayout();
            ScoreAndTitle.ResumeLayout(false);
            ScoreAndTitle.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ScoreLabel;
        private Label TitleLabel;
        private Label BodyLabel;
        private Label ReviewDateLabel;
        private FlowLayoutPanel ReviewStack;
        private FlowLayoutPanel ScoreAndTitle;
    }
}
