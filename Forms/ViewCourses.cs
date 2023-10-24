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
using SchoolManagementSystem.Classes;

namespace SchoolManagementSystem.Forms
{
    public partial class ViewCourses : Form
    {
        private void PopulateCourseListView(User currentUser)
        {
            listView1.Items.Clear();

            string[] courseLines = File.ReadAllLines("Courses.txt");

            var filteredCourses = courseLines
                .Where(line =>
                {
                    string[] courseInfo = line.Split(':');
                    return courseInfo.Length == 3 && courseInfo[2] == currentUser.Name;
                })
                .Select(courseInfo => courseInfo.Split(':'))
                .Select(courseInfo => new
                {
                    CourseID = courseInfo[0],
                    CourseName = courseInfo[1],
                    TeacherName = courseInfo[2]
                });

            foreach (var course in filteredCourses)
            {
                ListViewItem item = new ListViewItem(course.CourseID);
                item.SubItems.Add(course.CourseName);
                item.SubItems.Add(course.TeacherName);
                listView1.Items.Add(item);
            }
        }

        public ViewCourses(User currentUser)
        {
            InitializeComponent();
            PopulateCourseListView(currentUser);
        }

        private void button_viewCourse_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];

                int courseID = int.Parse(selectedItem.Text);
                string courseName = selectedItem.SubItems[1].Text;
                string teacherName = selectedItem.SubItems[2].Text;

                Course selectedCourse = new Course(courseID, courseName, teacherName);
                ViewCourse viewCourseForm = new ViewCourse(selectedCourse);
                viewCourseForm.Show();
            }
            else
            {
                MessageBox.Show("Please select a course to view.", "No Course Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
