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
    public partial class CreateCourse : Form
    {
        private Teacher currentTeacher;

        public CreateCourse(Teacher teacher)
        {
            InitializeComponent();
            currentTeacher = teacher;
            textBox_assignedTeacher.Text = currentTeacher.Id.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_addCourse_Click(object sender, EventArgs e)
        {
            int courseID;
            if (!int.TryParse(textBox_cid.Text, out courseID))
            {
                MessageBox.Show("Invalid course ID. Please enter a valid number.");
                return;
            }

            string courseName = textBox_cname.Text;

            if (string.IsNullOrEmpty(courseName))
            {
                MessageBox.Show("Course name cannot be empty.");
                return;
            }

            Course newCourse = new Course
            {
                CourseID = courseID,
                CourseName = courseName,
                TeacherID = currentTeacher.Id
            };

            using (System.IO.StreamWriter file = new System.IO.StreamWriter("courses.txt", true))
            {
                file.WriteLine($"{newCourse.CourseID},{newCourse.CourseName},{newCourse.TeacherID}");
            }

            MessageBox.Show("Course added successfully.");
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }
    }
}
