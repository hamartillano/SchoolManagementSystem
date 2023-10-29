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
    public partial class EditCourse : Form
    {
        private Course currentCourse;

        public EditCourse(Course course)
        {
            InitializeComponent();
            currentCourse = course;
            textBox_cid.Text = currentCourse.CourseID.ToString();
            textBox_cname.Text = currentCourse.CourseName;
            textBox_assignedTeacher.Text = currentCourse.TeacherID.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string updatedCourseName = textBox_cname.Text;

            if (string.IsNullOrEmpty(updatedCourseName))
            {
                MessageBox.Show("Course Name must be provided.");
                return;
            }

            try
            {
                List<string> updatedLines = new List<string>();
                string[] lines = File.ReadAllLines("courses.txt");
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        int courseID = int.Parse(parts[0]);
                        string courseName = parts[1];
                        int teacherID = int.Parse(parts[2]);
                        if (courseID == currentCourse.CourseID)
                        {
                            updatedLines.Add($"{courseID},{updatedCourseName},{teacherID}");
                        }
                        else
                        {
                            updatedLines.Add(line);
                        }
                    }
                }

                File.WriteAllLines("courses.txt", updatedLines);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating course: " + ex.Message);
                return;
            }

            MessageBox.Show("Course updated successfully.");
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }

		private void textBox_assignedTeacher_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
