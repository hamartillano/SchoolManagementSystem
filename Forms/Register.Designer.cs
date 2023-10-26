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
            this.button_register = new System.Windows.Forms.Button();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(134, 154);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(235, 20);
            this.textBox_password.TabIndex = 7;
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(134, 118);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(235, 20);
            this.textBox_username.TabIndex = 6;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(72, 158);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(56, 13);
            this.label_password.TabIndex = 5;
            this.label_password.Text = "Password:";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(70, 122);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(58, 13);
            this.label_username.TabIndex = 4;
            this.label_username.Text = "Username:";
            // 
            // label_userType
            // 
            this.label_userType.AutoSize = true;
            this.label_userType.Location = new System.Drawing.Point(72, 63);
            this.label_userType.Name = "label_userType";
            this.label_userType.Size = new System.Drawing.Size(56, 13);
            this.label_userType.TabIndex = 8;
            this.label_userType.Text = "User Type";
            this.label_userType.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioButton_teacher
            // 
            this.radioButton_teacher.AutoSize = true;
            this.radioButton_teacher.Location = new System.Drawing.Point(134, 46);
            this.radioButton_teacher.Name = "radioButton_teacher";
            this.radioButton_teacher.Size = new System.Drawing.Size(65, 17);
            this.radioButton_teacher.TabIndex = 9;
            this.radioButton_teacher.TabStop = true;
            this.radioButton_teacher.Text = "Teacher";
            this.radioButton_teacher.UseVisualStyleBackColor = true;
            this.radioButton_teacher.CheckedChanged += new System.EventHandler(this.radioButton_teacher_CheckedChanged);
            // 
            // radioButton_student
            // 
            this.radioButton_student.AutoSize = true;
            this.radioButton_student.Location = new System.Drawing.Point(134, 76);
            this.radioButton_student.Name = "radioButton_student";
            this.radioButton_student.Size = new System.Drawing.Size(62, 17);
            this.radioButton_student.TabIndex = 10;
            this.radioButton_student.TabStop = true;
            this.radioButton_student.Text = "Student";
            this.radioButton_student.UseVisualStyleBackColor = true;
            this.radioButton_student.CheckedChanged += new System.EventHandler(this.radioButton_student_CheckedChanged);
            // 
            // button_register
            // 
            this.button_register.Location = new System.Drawing.Point(134, 278);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(75, 23);
            this.button_register.TabIndex = 12;
            this.button_register.Text = "Register";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(134, 190);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(235, 20);
            this.textBox_name.TabIndex = 14;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(90, 194);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(38, 13);
            this.label_name.TabIndex = 13;
            this.label_name.Text = "Name:";
            // 
            // textBox_id
            // 
            this.textBox_id.Enabled = false;
            this.textBox_id.Location = new System.Drawing.Point(134, 226);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(235, 20);
            this.textBox_id.TabIndex = 16;
            this.textBox_id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID:";
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(294, 278);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(75, 23);
            this.button_login.TabIndex = 17;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 313);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.button_register);
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
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_login;
    }
}