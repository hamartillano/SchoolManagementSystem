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
            string inputUsername = textBox_username.Text;
            string inputPassword = textBox_password.Text;

            string[] lines = System.IO.File.ReadAllLines("login.txt");
            CurrentUser = lines
                .Select(line => line.Split(':'))
                .Where(parts => parts.Length == 4)
                .Select(parts => new User(
                    (UserType)Enum.Parse(typeof(UserType), parts[0]),
                    parts[1],
                    parts[2],
                    parts[3]))
                .FirstOrDefault(u => u.Username == inputUsername && u.Password == inputPassword);

            if (CurrentUser != null)
            {
                switch (CurrentUser.UserType)
                {
                    case UserType.Admin:
                        MessageBox.Show("Admin login successful!");
                        break;
                    case UserType.Teacher:
                        MessageBox.Show("Teacher login successful!");
                        break;
                    case UserType.Student:
                        MessageBox.Show("Student login successful!");
                        break;
                    default:
                        MessageBox.Show("Unknown user type.");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Login failed. Please check your credentials");
            }
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
            this.Hide();
        }
    }
}
