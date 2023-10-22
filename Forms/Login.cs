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
    public partial class Login : Form
    {
        public User CurrentUser;

        public Login()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines("login.txt");

            string inputUsername = textBox_username.Text;
            string inputPassword = textBox_password.Text;

            foreach (string line in lines)
            {
                string[] parts = line.Split(':');
                if (parts.Length == 3)
                {
                    string storedUserType = parts[0];
                    string storedUsername = parts[1];
                    string storedPassword = parts[2];

                    if (inputUsername == storedUsername && inputPassword == storedPassword)
                    {
                        CurrentUser = new User(storedUserType, storedUsername, storedPassword);
                        break;
                    }
                }
            }

            if (CurrentUser != null)
            {
                switch (CurrentUser.UserType)
                {
                    case "admin":
                        MessageBox.Show("Admin login successful!");
                        break;
                    case "teacher":
                        MessageBox.Show("Teacher login successful!");
                        break;
                    case "student":
                        MessageBox.Show("Student login successful!");
                        break;
                    default:
                        MessageBox.Show("Unknown user type.");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Login failed. Please check your credentials.");
            }
        }
    }
}
