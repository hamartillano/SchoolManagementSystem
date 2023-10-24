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
        private List<Student> enrolledStudents;

        public ViewCourse(Course selectedCourse)
        {
            InitializeComponent();

            textBox_couseID.Text = selectedCourse.CourseID.ToString();
            textBox_courseName.Text = selectedCourse.CourseName;
            textBox_teacher.Text = selectedCourse.TeacherName;

            LoadEnrolledStudents(selectedCourse);
            PopulateStudentListView(selectedCourse);
        }

        private void LoadEnrolledStudents(Course selectedCourse)
        {
            enrolledStudents = new List<Student>();

            // Read students from "Students.txt" and populate the enrolledStudents list
            string[] studentLines = File.ReadAllLines("Students.txt");
            foreach (string line in studentLines)
            {
                string[] parts = line.Split(':');
                if (parts.Length == 3)
                {
                    int studentID;
                    if (int.TryParse(parts[0], out studentID))
                    {
                        string name = parts[1];
                        string[] courseIDs = parts[2].Split(',');
                        List<Course> enrolledCourses = new List<Course>();

                        // Check if the selectedCourse is in the list of student's enrolled courses
                        if (courseIDs.Contains(selectedCourse.CourseID.ToString()))
                        {
                            enrolledCourses.Add(selectedCourse);
                        }

                        Student student = new Student(UserType.Student, name, "", name, studentID);
                        student.EnrolledCourses = enrolledCourses;
                        enrolledStudents.Add(student);
                    }
                }
            }
        }

        private void PopulateStudentListView(Course selectedCourse)
        {
            listView1.Items.Clear();

            foreach (Student student in enrolledStudents)
            {
                if (student.EnrolledCourses.Contains(selectedCourse))
                {
                    ListViewItem item = new ListViewItem(student.StudentID.ToString());
                    item.SubItems.Add(student.Name);
                    listView1.Items.Add(item);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
