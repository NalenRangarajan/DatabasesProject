﻿namespace GameApplication
{
    partial class LoginView
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
            UsernameLabel = new Label();
            PasswordLabel = new Label();
            UsernameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            LoginButton = new Button();
            RegisterButton = new Button();
            SuspendLayout();
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Location = new Point(12, 9);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(95, 25);
            UsernameLabel.TabIndex = 0;
            UsernameLabel.Text = "Username:";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(12, 46);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(91, 25);
            PasswordLabel.TabIndex = 1;
            PasswordLabel.Text = "Password:";
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(113, 6);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(150, 31);
            UsernameTextBox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(113, 43);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(150, 31);
            PasswordTextBox.TabIndex = 3;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(151, 99);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(112, 34);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(12, 99);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(112, 34);
            RegisterButton.TabIndex = 5;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 145);
            Controls.Add(RegisterButton);
            Controls.Add(LoginButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(UsernameTextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernameLabel);
            Name = "LoginView";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UsernameLabel;
        private Label PasswordLabel;
        private TextBox UsernameTextBox;
        private TextBox PasswordTextBox;
        private Button LoginButton;
        private Button RegisterButton;
    }
}