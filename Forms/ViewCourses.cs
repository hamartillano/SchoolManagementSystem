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
        private void LoadTeachingCourses(Teacher CurrentTeacher)
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
            LoadTeachingCourses(currentTeacher);
        }

        private void button_viewCourse_Click(object sender, EventArgs e)
        {
            
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
