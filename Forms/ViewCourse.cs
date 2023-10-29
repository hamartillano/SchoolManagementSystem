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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SchoolManagementSystem.Forms
{
    public partial class ViewCourse : Form
    {
        private Course selectedCourse;

        public ViewCourse(Course course)
        {
            InitializeComponent();
            selectedCourse = course;
            LoadCourseDetails();
            LoadEnrolledStudents();
        }

        private void LoadCourseDetails()
        {
            textBox_courseID.Text = selectedCourse.CourseID.ToString();
            textBox_courseName.Text = selectedCourse.CourseName;
            textBox_teacher.Text = selectedCourse.TeacherID.ToString();
        }

        private void LoadEnrolledStudents()
        {
            listView1.Items.Clear();

            string[] lines = File.ReadAllLines("students.txt");

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                int courseID = int.Parse(parts[0]);
                int studentID = int.Parse(parts[1]);
                string studentName = parts[2];
                string grade = parts[3];

                if (courseID == selectedCourse.CourseID)
                {
                    ListViewItem item = new ListViewItem(studentID.ToString());
                    item.SubItems.Add(studentName);
                    item.SubItems.Add(grade);
                    listView1.Items.Add(item);
                }
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_teacher_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button_editGrade_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                int studentID = int.Parse(selectedItem.Text);
                string studentName = selectedItem.SubItems[1].Text;
                string studentGrade = selectedItem.SubItems[2].Text;
                int courseID = selectedCourse.CourseID;

                EditGrade editGradeForm = new EditGrade(studentID, studentName, studentGrade, courseID);
                editGradeForm.Show();
                this.Close();
			}
            else
            {
                MessageBox.Show("Please select a student to mark the grade.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ViewCourse_Load(object sender, EventArgs e)
        {

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void textBox_couseID_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
