﻿namespace SchoolManagementSystem.Forms
{
	partial class MyProfile
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
			this.label2 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox_studentID = new System.Windows.Forms.TextBox();
			this.textBox_Name = new System.Windows.Forms.TextBox();
			this.textBox_Username = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.Password = new System.Windows.Forms.Label();
			this.textBox_Password = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(31, 86);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(0, 20);
			this.label2.TabIndex = 6;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(566, 312);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(148, 32);
			this.button3.TabIndex = 23;
			this.button3.Text = "Edit My Profile";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click_1);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 310);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(96, 37);
			this.button1.TabIndex = 21;
			this.button1.Text = "Back";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(194, 260);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(26, 20);
			this.label4.TabIndex = 19;
			this.label4.Text = "ID";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(162, 204);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 20);
			this.label3.TabIndex = 18;
			this.label3.Text = "Name";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(137, 115);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 20);
			this.label1.TabIndex = 17;
			this.label1.Text = "Username";
			// 
			// textBox_studentID
			// 
			this.textBox_studentID.Enabled = false;
			this.textBox_studentID.Location = new System.Drawing.Point(250, 254);
			this.textBox_studentID.Name = "textBox_studentID";
			this.textBox_studentID.Size = new System.Drawing.Size(273, 26);
			this.textBox_studentID.TabIndex = 15;
			this.textBox_studentID.TextChanged += new System.EventHandler(this.textBox3_studentID_TextChanged);
			// 
			// textBox_Name
			// 
			this.textBox_Name.Location = new System.Drawing.Point(250, 204);
			this.textBox_Name.Name = "textBox_Name";
			this.textBox_Name.Size = new System.Drawing.Size(273, 26);
			this.textBox_Name.TabIndex = 14;
			// 
			// textBox_Username
			// 
			this.textBox_Username.Location = new System.Drawing.Point(250, 112);
			this.textBox_Username.Name = "textBox_Username";
			this.textBox_Username.Size = new System.Drawing.Size(273, 26);
			this.textBox_Username.TabIndex = 13;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(299, 62);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(145, 20);
			this.label5.TabIndex = 24;
			this.label5.Text = "YOUR DETAILS:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label5.Click += new System.EventHandler(this.label5_Click_2);
			// 
			// Password
			// 
			this.Password.AutoSize = true;
			this.Password.Location = new System.Drawing.Point(142, 160);
			this.Password.Name = "Password";
			this.Password.Size = new System.Drawing.Size(78, 20);
			this.Password.TabIndex = 25;
			this.Password.Text = "Password";
			// 
			// textBox_Password
			// 
			this.textBox_Password.Location = new System.Drawing.Point(250, 157);
			this.textBox_Password.Name = "textBox_Password";
			this.textBox_Password.Size = new System.Drawing.Size(273, 26);
			this.textBox_Password.TabIndex = 26;
			this.textBox_Password.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
			// 
			// MyProfile
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(727, 349);
			this.Controls.Add(this.textBox_Password);
			this.Controls.Add(this.Password);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox_studentID);
			this.Controls.Add(this.textBox_Name);
			this.Controls.Add(this.textBox_Username);
			this.Controls.Add(this.label2);
			this.Name = "MyProfile";
			this.Text = "MyProfile";
			this.Load += new System.EventHandler(this.MyProfile_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox_studentID;
		private System.Windows.Forms.TextBox textBox_Name;
		private System.Windows.Forms.TextBox textBox_Username;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label Password;
		private System.Windows.Forms.TextBox textBox_Password;
	}
}