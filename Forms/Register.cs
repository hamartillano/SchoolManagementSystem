using SchoolManagementSystem.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.Forms
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            this.Close();
            loginForm.Show();
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox_username.Text) && !string.IsNullOrWhiteSpace(textBox_password.Text))
            {
                if ((radioButton_teacher.Checked && radioButton_student.Checked) ||
                    (!radioButton_teacher.Checked && !radioButton_student.Checked))
                {
                    MessageBox.Show("Please select one user type (teacher or student)");
                    return;
                }

                string userType = radioButton_teacher.Checked ? "teacher" : "student";
                string username = textBox_username.Text;
                string password = textBox_password.Text;

                User newUser = new User(userType, username, password);
                User.WriteUserToFile(newUser);

                MessageBox.Show("Registration successful!");
                this.Close();
                Login loginForm = new Login();
                loginForm.Show();
            }
            else
            {
                MessageBox.Show("Please provide both a username and a password");
            }
        }
    }
}
