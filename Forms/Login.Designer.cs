﻿namespace SchoolManagementSystem.Forms
{
    partial class Login
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
			this.label_username = new System.Windows.Forms.Label();
			this.label_password = new System.Windows.Forms.Label();
			this.textBox_username = new System.Windows.Forms.TextBox();
			this.textBox_password = new System.Windows.Forms.TextBox();
			this.button_login = new System.Windows.Forms.Button();
			this.button_register = new System.Windows.Forms.Button();
			this.togglePassword_Click = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// label_username
			// 
			this.label_username.AutoSize = true;
			this.label_username.Location = new System.Drawing.Point(102, 34);
			this.label_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_username.Name = "label_username";
			this.label_username.Size = new System.Drawing.Size(87, 20);
			this.label_username.TabIndex = 0;
			this.label_username.Text = "Username:";
			// 
			// label_password
			// 
			this.label_password.AutoSize = true;
			this.label_password.Location = new System.Drawing.Point(105, 89);
			this.label_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_password.Name = "label_password";
			this.label_password.Size = new System.Drawing.Size(82, 20);
			this.label_password.TabIndex = 1;
			this.label_password.Text = "Password:";
			// 
			// textBox_username
			// 
			this.textBox_username.Location = new System.Drawing.Point(198, 28);
			this.textBox_username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBox_username.Name = "textBox_username";
			this.textBox_username.Size = new System.Drawing.Size(350, 26);
			this.textBox_username.TabIndex = 2;
			// 
			// textBox_password
			// 
			this.textBox_password.Location = new System.Drawing.Point(198, 83);
			this.textBox_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBox_password.Name = "textBox_password";
			this.textBox_password.Size = new System.Drawing.Size(350, 26);
			this.textBox_password.TabIndex = 3;
			this.textBox_password.UseSystemPasswordChar = true;
			this.textBox_password.TextChanged += new System.EventHandler(this.textBox_password_TextChanged);
			// 
			// button_login
			// 
			this.button_login.Location = new System.Drawing.Point(198, 138);
			this.button_login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button_login.Name = "button_login";
			this.button_login.Size = new System.Drawing.Size(112, 35);
			this.button_login.TabIndex = 4;
			this.button_login.Text = "Login";
			this.button_login.UseVisualStyleBackColor = true;
			this.button_login.Click += new System.EventHandler(this.button_login_Click);
			// 
			// button_register
			// 
			this.button_register.Location = new System.Drawing.Point(320, 138);
			this.button_register.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button_register.Name = "button_register";
			this.button_register.Size = new System.Drawing.Size(112, 35);
			this.button_register.TabIndex = 5;
			this.button_register.Text = "Register";
			this.button_register.UseVisualStyleBackColor = true;
			this.button_register.Click += new System.EventHandler(this.button_register_Click);
			// 
			// togglePassword_Click
			// 
			this.togglePassword_Click.AutoSize = true;
			this.togglePassword_Click.Location = new System.Drawing.Point(555, 85);
			this.togglePassword_Click.Name = "togglePassword_Click";
			this.togglePassword_Click.Size = new System.Drawing.Size(79, 24);
			this.togglePassword_Click.TabIndex = 6;
			this.togglePassword_Click.Text = "Show ";
			this.togglePassword_Click.UseVisualStyleBackColor = true;
			this.togglePassword_Click.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(651, 200);
			this.Controls.Add(this.togglePassword_Click);
			this.Controls.Add(this.button_register);
			this.Controls.Add(this.button_login);
			this.Controls.Add(this.textBox_password);
			this.Controls.Add(this.textBox_username);
			this.Controls.Add(this.label_password);
			this.Controls.Add(this.label_username);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.Load += new System.EventHandler(this.Login_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_register;
		private System.Windows.Forms.CheckBox togglePassword_Click;
	}
}