namespace SchoolManagementSystem.Forms
{
    partial class EditGrade
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
			this.label1 = new System.Windows.Forms.Label();
			this.textBox_sid = new System.Windows.Forms.TextBox();
			this.textBox_sname = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox_sgrade = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button_confirm = new System.Windows.Forms.Button();
			this.button_back = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 26);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Student ID:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// textBox_sid
			// 
			this.textBox_sid.Enabled = false;
			this.textBox_sid.Location = new System.Drawing.Point(150, 20);
			this.textBox_sid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBox_sid.Name = "textBox_sid";
			this.textBox_sid.Size = new System.Drawing.Size(336, 26);
			this.textBox_sid.TabIndex = 1;
			// 
			// textBox_sname
			// 
			this.textBox_sname.Enabled = false;
			this.textBox_sname.Location = new System.Drawing.Point(150, 75);
			this.textBox_sname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBox_sname.Name = "textBox_sname";
			this.textBox_sname.Size = new System.Drawing.Size(336, 26);
			this.textBox_sname.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(24, 82);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(116, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Student Name:";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// textBox_sgrade
			// 
			this.textBox_sgrade.Location = new System.Drawing.Point(150, 131);
			this.textBox_sgrade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBox_sgrade.Name = "textBox_sgrade";
			this.textBox_sgrade.Size = new System.Drawing.Size(336, 26);
			this.textBox_sgrade.TabIndex = 5;
			this.textBox_sgrade.TextChanged += new System.EventHandler(this.textBox_sgrade_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(24, 137);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(119, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Student Grade:";
			// 
			// button_confirm
			// 
			this.button_confirm.Location = new System.Drawing.Point(375, 185);
			this.button_confirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button_confirm.Name = "button_confirm";
			this.button_confirm.Size = new System.Drawing.Size(112, 35);
			this.button_confirm.TabIndex = 6;
			this.button_confirm.Text = "Confirm";
			this.button_confirm.UseVisualStyleBackColor = true;
			this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click_1);
			// 
			// button_back
			// 
			this.button_back.Location = new System.Drawing.Point(28, 185);
			this.button_back.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button_back.Name = "button_back";
			this.button_back.Size = new System.Drawing.Size(112, 35);
			this.button_back.TabIndex = 7;
			this.button_back.Text = "Back";
			this.button_back.UseVisualStyleBackColor = true;
			this.button_back.Click += new System.EventHandler(this.button_back_Click);
			// 
			// EditGrade
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(512, 242);
			this.Controls.Add(this.button_back);
			this.Controls.Add(this.button_confirm);
			this.Controls.Add(this.textBox_sgrade);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox_sname);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox_sid);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "EditGrade";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "EditGrade";
			this.Load += new System.EventHandler(this.EditGrade_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_sid;
        private System.Windows.Forms.TextBox textBox_sname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_sgrade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.Button button_back;
    }
}