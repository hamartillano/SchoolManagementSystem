using SchoolManagementSystem.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            int randomUserID = GenerateRandomUserID();
            textBox_id.Text = randomUserID.ToString();
        }

        private int GenerateRandomUserID()
        {
            Random random = new Random();
            int minUserID = 1000;
            int maxUserID = 9999;
            int userID = random.Next(minUserID, maxUserID + 1);

            return userID;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_register_Click(object sender, EventArgs e)
        {
            if (!(radioButton_teacher.Checked || radioButton_student.Checked))
            {
                MessageBox.Show("Please select a user type (Teacher or Student).");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox_username.Text) ||
                string.IsNullOrWhiteSpace(textBox_password.Text) ||
                string.IsNullOrWhiteSpace(textBox_name.Text)
                )
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            else
            {
                string registrationInfo = $"{textBox_id.Text}," +
                                          $"{(radioButton_teacher.Checked ? "Teacher" : "Student")}," +
                                          $"{textBox_username.Text}," +
                                          $"{textBox_password.Text}," +
                                          $"{textBox_name.Text}";

                try
                {
                    using (StreamWriter sw = new StreamWriter("registrations.txt", true))
                    {
                        sw.WriteLine(registrationInfo);
                    }

                    MessageBox.Show("Registration successful. Data has been saved to the text file.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

                textBox_username.Clear();
                textBox_password.Clear();
                textBox_name.Clear();
                textBox_id.Clear();
                radioButton_teacher.Checked = false;
                radioButton_student.Checked = false;

                Login logingScreen = new Login();
                logingScreen.Show();
                this.Hide();
            }
        }

        private void radioButton_student_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_teacher_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

		private void textBox_name_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
