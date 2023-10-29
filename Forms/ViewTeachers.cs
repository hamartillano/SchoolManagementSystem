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
    public partial class ViewTeachers : Form
    {
        public ViewTeachers()
        {
            InitializeComponent();
            PopulateTeachersListView();
        }

        private void PopulateTeachersListView()
        {
            listView1.Items.Clear();

            try
            {
                string[] lines = File.ReadAllLines("registrations.txt");

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');

                    if (parts[1].Trim().Equals("Teacher", StringComparison.OrdinalIgnoreCase))
                    {
                        string teacherID = parts[0];
                        string teacherName = parts[4];

                        ListViewItem item = new ListViewItem(teacherID);
                        item.SubItems.Add(teacherName);
                        listView1.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading teachers: " + ex.Message);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the Teacher?", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ListViewItem selectedTeacherItem = listView1.SelectedItems[0];
                    string selectedTeacherID = selectedTeacherItem.SubItems[0].Text;

                    RemoveTeacherFromRegistrations(selectedTeacherID);

                    UpdateCoursesFile(selectedTeacherID);

                    listView1.Items.Remove(selectedTeacherItem);
                }
            }
            else
            {
                MessageBox.Show("Please select a teacher to remove.");
            }
        }

        private void RemoveTeacherFromRegistrations(string teacherID)
        {
            try
            {
                string[] lines = File.ReadAllLines("registrations.txt");

                using (StreamWriter writer = new StreamWriter("registrations.txt"))
                {
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length >= 2 && parts[0].Trim() != teacherID)
                        {
                            writer.WriteLine(line);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing teacher from registrations.txt: " + ex.Message);
            }
        }

        private void UpdateCoursesFile(string teacherID)
        {
            try
            {
                string[] lines = File.ReadAllLines("courses.txt");

                using (StreamWriter writer = new StreamWriter("courses.txt"))
                {
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length >= 3 && parts[2].Trim() != teacherID)
                        {
                            writer.WriteLine(line);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating courses.txt: " + ex.Message);
            }
        }

		private void ViewTeachers_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
