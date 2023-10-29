using SchoolManagementSystem.Classes;
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
using System.Windows.Forms.VisualStyles;

namespace SchoolManagementSystem.Forms
{
	public partial class MyProfile : Form
	{
		private Student currentStudent;
		private string studentName;
		private string studentUsername;
		private string studentPassword;

		public MyProfile(Student student)
		{
			InitializeComponent();
			currentStudent = student;
			LoadStudentDetails();
		}

		private void LoadStudentDetails()
		{
			textBox_studentID.Text = currentStudent.Id.ToString();
			textBox_Password.Text = currentStudent.Password;
			textBox_Name.Text = currentStudent.Name;
			textBox_Username.Text = currentStudent.Username;
		}

		private void MyProfile_Load(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			//string updatedStudentName = textBox_cname.Text;

			//if (string.IsNullOrEmpty(updatedStudentName))
			//{
			//	MessageBox.Show("Student name must be provided.");
			//	return;
			//} 

			//try
			//{
			//	List<string> updatedLines = new List<string>();
			//	string[] lines = File.ReadAllLines("students.txt");
			//	foreach (string line in lines)
			//	{
			//		string[] parts = line.Split(',');
			//		if (parts.Length == 4)
			//		{
			//			int courseID = int.Parse(parts[0]);
			//			int studentID = int.Parse(parts[1]);
			//			string studentName = parts[2];
			//			string grade = parts[3];
			//			if (studentID == )
			//			{
			//				updatedLines.Add($"");
			//			}
			//			else
			//			{
			//				updatedLines.Add(line); // do nothing
			//			}
			//		}
			//	}

			//	File.WriteAllLines("courses.txt", updatedLines);
			//}
			//catch (Exception ex)
			//{
			//	MessageBox.Show("Error updating course: " + ex.Message);
			//	return;
			//}

			//MessageBox.Show("Course updated successfully.");
			//this.Close();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void label5_Click_1(object sender, EventArgs e)
		{

		}

		private void button2_Click_1(object sender, EventArgs e)
		{

		}

		private void label5_Click_2(object sender, EventArgs e)
		{

		}

		private void UpdateStudentInfoInFile()
		{
			string[] registrationLines = File.ReadAllLines("registrations.txt");
			string[] studentLines = File.ReadAllLines("students.txt");

			for (int i = 0; i < registrationLines.Length; i++)
			{
				string regLine = registrationLines[i];
				string[] regParts = regLine.Split(',');

				if (regParts.Length >= 1 && int.TryParse(regParts[0], out int id) && id == currentStudent.Id)
				{
					// Update the name and password in the "registrations.txt" file
					if (!string.IsNullOrEmpty(studentName))
					{
						regParts[4] = studentName;
					}
					if (!string.IsNullOrEmpty(studentPassword))
					{
						regParts[3] = studentPassword;
					}
					if (!string.IsNullOrEmpty(studentUsername))
					{
						regParts[2] = studentUsername;
					}

					// Update the line with the modified values
					registrationLines[i] = string.Join(",", regParts);
				}
			}

			for (int i = 0; i < studentLines.Length; i++)
			{
				string studentLine = studentLines[i];
				string[] studentParts = studentLine.Split(',');

				if (studentParts.Length >= 1 && int.TryParse(studentParts[1], out int id) && id == currentStudent.Id)
				{
					// Update the name in the "students.txt" file
					if (!string.IsNullOrEmpty(studentName))
					{
						studentParts[2] = studentName;
					}

					// Update the line with the modified values
					studentLines[i] = string.Join(",", studentParts);
				}
			}

			// Write the updated lines back to their respective files
			File.WriteAllLines("registrations.txt", registrationLines);
			File.WriteAllLines("students.txt", studentLines);
		}

		private void button3_Click_1(object sender, EventArgs e)
		{
			string newStudentUsername = textBox_Username.Text;
			string newStudentName = textBox_Name.Text;
			string newStudentPassword = textBox_Password.Text;

			if (newStudentUsername.Contains(" "))
			{
				MessageBox.Show("Username cannot contain spaces.");
			}
			else if (newStudentPassword.Length <= 1)
			{
				MessageBox.Show("Password must have at least 2 characters.");
			}
			else
			{
				studentUsername = newStudentUsername;
				studentName = newStudentName;
				studentPassword = newStudentPassword;
				UpdateStudentInfoInFile();
				this.Close();
			}
		}

		private void textBox3_studentID_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged_1(object sender, EventArgs e)
		{

		}
	}
	
}
