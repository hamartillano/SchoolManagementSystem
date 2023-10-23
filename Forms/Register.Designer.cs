namespace SchoolManagementSystem.Forms
{
    partial class Register
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
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.label_userType = new System.Windows.Forms.Label();
            this.radioButton_teacher = new System.Windows.Forms.RadioButton();
            this.radioButton_student = new System.Windows.Forms.RadioButton();
            this.button_back = new System.Windows.Forms.Button();
            this.button_register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(132, 146);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(235, 20);
            this.textBox_password.TabIndex = 7;
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(132, 110);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(235, 20);
            this.textBox_username.TabIndex = 6;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(70, 150);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(56, 13);
            this.label_password.TabIndex = 5;
            this.label_password.Text = "Password:";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(68, 114);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(58, 13);
            this.label_username.TabIndex = 4;
            this.label_username.Text = "Username:";
            // 
            // label_userType
            // 
            this.label_userType.AutoSize = true;
            this.label_userType.Location = new System.Drawing.Point(70, 61);
            this.label_userType.Name = "label_userType";
            this.label_userType.Size = new System.Drawing.Size(56, 13);
            this.label_userType.TabIndex = 8;
            this.label_userType.Text = "User Type";
            this.label_userType.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioButton_teacher
            // 
            this.radioButton_teacher.AutoSize = true;
            this.radioButton_teacher.Location = new System.Drawing.Point(132, 44);
            this.radioButton_teacher.Name = "radioButton_teacher";
            this.radioButton_teacher.Size = new System.Drawing.Size(65, 17);
            this.radioButton_teacher.TabIndex = 9;
            this.radioButton_teacher.TabStop = true;
            this.radioButton_teacher.Text = "Teacher";
            this.radioButton_teacher.UseVisualStyleBackColor = true;
            // 
            // radioButton_student
            // 
            this.radioButton_student.AutoSize = true;
            this.radioButton_student.Location = new System.Drawing.Point(132, 74);
            this.radioButton_student.Name = "radioButton_student";
            this.radioButton_student.Size = new System.Drawing.Size(62, 17);
            this.radioButton_student.TabIndex = 10;
            this.radioButton_student.TabStop = true;
            this.radioButton_student.Text = "Student";
            this.radioButton_student.UseVisualStyleBackColor = true;
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(71, 205);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 23);
            this.button_back.TabIndex = 11;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_register
            // 
            this.button_register.Location = new System.Drawing.Point(152, 205);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(75, 23);
            this.button_register.TabIndex = 12;
            this.button_register.Text = "Register";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.radioButton_student);
            this.Controls.Add(this.radioButton_teacher);
            this.Controls.Add(this.label_userType);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_userType;
        private System.Windows.Forms.RadioButton radioButton_teacher;
        private System.Windows.Forms.RadioButton radioButton_student;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_register;
    }
}