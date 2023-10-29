using SchoolManagementSystem.Classes;
using System;
using System.IO;
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
        private List<User> registeredUsers = new List<User>();

        public Login()
        {
            InitializeComponent();
            LoadRegisteredUsers();
        }

        private void LoadRegisteredUsers()
        {
            try
            {
                string[] lines = File.ReadAllLines("registrations.txt");
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 5)
                    {
                        User user = new User
                        (
                            int.Parse(parts[0]),
                            (UserType)Enum.Parse(typeof(UserType), parts[1]),
                            parts[2],
                            parts[3],
                            parts[4]
                        );
                        registeredUsers.Add(user);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading registered users: " + ex.Message);
            }
        }

        private User AuthenticateUser(string username, string password)
        {
            User authenticatedUser = registeredUsers.Find(user =>
                user.Username == username && user.Password == password);

            return authenticatedUser;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string username = textBox_username.Text;
            string password = textBox_password.Text;

            User authenticatedUser = AuthenticateUser(username, password);

            if (authenticatedUser != null)
            {
                MessageBox.Show("Authentication successful!");

                if(authenticatedUser.UserType == UserType.Admin)
                {
                    AdminMain adminMainForm = new AdminMain();
                    adminMainForm.Show();
                    this.Hide();
                }
                if (authenticatedUser.UserType == UserType.Teacher)
                {
                    Teacher currentTeacher = new Teacher(authenticatedUser);
                    ViewCourses viewCoursesForm = new ViewCourses(currentTeacher);
                    viewCoursesForm.Show();
                    this.Hide();
                }
                if (authenticatedUser.UserType == UserType.Student)
                {
                    Student currentStudent = new Student(authenticatedUser);
                    StudentView studentViewForm = new StudentView(currentStudent);
                    studentViewForm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Authentication failed. Please check your credentials.");
            }
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
            this.Hide();
        }

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (textBox_password.UseSystemPasswordChar)
			{
				textBox_password.UseSystemPasswordChar = false;
			}
			else
			{
				textBox_password.UseSystemPasswordChar = true;
			}
		}

		private void textBox_password_TextChanged(object sender, EventArgs e)
		{

		}

		private void Login_Load(object sender, EventArgs e)
		{

		}
	}
}
