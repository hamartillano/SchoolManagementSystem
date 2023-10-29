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
	public partial class ViewStudents : Form
	{
		public ViewStudents()
		{
			InitializeComponent();
			PopulateStudentListView();
		}

		public void PopulateStudentListView()
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

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
