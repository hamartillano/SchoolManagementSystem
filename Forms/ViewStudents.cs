using System;
using System.IO;
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
    public partial class ViewStudents : Form
    {
        public ViewStudents()
        {
            InitializeComponent();
            PopulateStudentsListView();
        }

        private void PopulateStudentsListView()
        {
            listView1.Items.Clear();

            try
            {
                string[] lines = File.ReadAllLines("registrations.txt");

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');

                    if (parts[1].Trim().Equals("Student", StringComparison.OrdinalIgnoreCase))
                    {
                        string studentID = parts[0];
                        string studentName = parts[4];

                        ListViewItem item = new ListViewItem(studentID);
                        item.SubItems.Add(studentName);
                        listView1.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading teachers: " + ex.Message);
            }
        }

        private void button_deleteStudent_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the Student?", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ListViewItem selectedStudentItem = listView1.SelectedItems[0];
                    string selectedStudentID = selectedStudentItem.SubItems[0].Text;

                    RemoveStudentFromRegistration(selectedStudentID);

                    listView1.Items.Remove(selectedStudentItem);
                }
            }
            else
            {
                MessageBox.Show("Please select a student to remove.");
            }
        }

        private void RemoveStudentFromRegistration(string teacherID)
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

		private void ViewStudents_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
            this.Close();
		}
	}
}
