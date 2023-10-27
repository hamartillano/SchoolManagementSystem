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
using System.Data.Common;

namespace SchoolManagementSystem.Forms
{
    public partial class ViewCourses : Form
    {
        private Teacher CurrentTeacher;
        private Course selectedCourse;

        private void LoadTeachingCourses()
        {
            listView1.Items.Clear();

            foreach (Course course in CurrentTeacher.TeachingCourses)
            {
                ListViewItem item = new ListViewItem(course.CourseID.ToString());
                item.SubItems.Add(course.CourseName);
                listView1.Items.Add(item);
            }
        }

        public ViewCourses(Teacher currentTeacher)
        {
            InitializeComponent();
            CurrentTeacher = currentTeacher;
            LoadTeachingCourses();
        }

        private void button_viewCourse_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];

                int selectedCourseID;
                if (int.TryParse(selectedItem.SubItems[0].Text, out selectedCourseID))
                {
                    selectedCourse = CurrentTeacher.TeachingCourses.FirstOrDefault(course => course.CourseID == selectedCourseID);

                    if (selectedCourse != null)
                    {
                        ViewCourse viewCourseForm = new ViewCourse(selectedCourse);
                        viewCourseForm.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a course to view.");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_editCourse_Click(object sender, EventArgs e)
        {

        }

        private void button_deleteCourse_Click(object sender, EventArgs e)
        {

        }
    }
}
