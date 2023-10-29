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

namespace SchoolManagementSystem.Forms
{
	public partial class EnrollandUnenrollCourse : Form
	{
		public List<Course> AllCourses { get; }
		private Student currentStudent;



		public EnrollandUnenrollCourse(Student student)
		{
			InitializeComponent();
			currentStudent = student;
			AllCourses = LoadAllCourses();
			PopulateCourseList();
		}
		public List<Course> LoadAllCourses()
		{
			List<Course> courses = new List<Course>();

			try
			{
				string[] lines = File.ReadAllLines("courses.txt");
				string[] enrollmentLines = File.ReadAllLines("students.txt"); // Read student enrollments

				List<int> enrolledCourseIDs = new List<int>();

				// Find course IDs in which the current student is enrolled
				foreach (string enrollmentLine in enrollmentLines)
				{
					string[] enrollmentParts = enrollmentLine.Split(',');
					if (enrollmentParts.Length >= 4)
					{
						int studentID = int.Parse(enrollmentParts[1]);
						if (studentID == currentStudent.Id)
						{
							int enrolledCourseID = int.Parse(enrollmentParts[0]);
							enrolledCourseIDs.Add(enrolledCourseID);
						}
					}
				}

				foreach (string line in lines)
				{
					string[] parts = line.Split(',');
					if (parts.Length >= 3)
					{
						int courseID = int.Parse(parts[0]);
						string courseName = parts[1];
						int teacherID = int.Parse(parts[2]);

						Course course = new Course
						{
							CourseID = courseID,
							CourseName = courseName,
							TeacherID = teacherID
						};

						// Check if the course is in the list of enrolled courses
						if (enrolledCourseIDs.Contains(course.CourseID))
						{
							currentStudent.EnrollInCourse(course); // Enroll the student in the course
						}

						courses.Add(course);
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error loading courses: " + ex.Message);
			}

			return courses;
		}
	

		private void PopulateCourseList()
		{
			listView1.Items.Clear();

			foreach (Course course in AllCourses)
			{

				ListViewItem item = new ListViewItem(course.CourseID.ToString());
				item.SubItems.Add(course.CourseName);
				item.SubItems.Add(course.TeacherID.ToString());
				// Check if the currentStudent is enrolled in the course
				if (currentStudent.EnrolledCourses.Contains(course))
				{
					item.SubItems.Add("Enrolled"); // Display "Enrolled" if the student is enrolled
				}
				else
				{
					item.SubItems.Add("Not Enrolled"); // Display "Not Enrolled" if the student is not enrolled
					item.SubItems.Add("N/A");
				}

				
				listView1.Items.Add(item);
			}
		}

		private void EnrollandUnenrollCourse_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			// Check if a course is selected in the list view
			if (listView1.SelectedItems.Count == 1)
			{
				ListViewItem selectedItem = listView1.SelectedItems[0];
				int selectedCourseID = int.Parse(selectedItem.SubItems[0].Text);

				// Check if the student is already enrolled in the course
				Course selectedCourse = AllCourses.Find(course => course.CourseID == selectedCourseID);
				if (selectedCourse != null && !currentStudent.EnrolledCourses.Contains(selectedCourse))
				{
					// Add an enrollment entry for the student and the selected course
					string newEnrollment = $"{selectedCourseID},{currentStudent.Id},{currentStudent.Name},*";
					// Add any other relevant enrollment information here (e.g., grade)

					// Append the new enrollment entry to the students.txt file
					File.AppendAllText("students.txt", newEnrollment + Environment.NewLine);

					// Update the student's enrolled courses list
					currentStudent.EnrollInCourse(selectedCourse);

					// Re-populate the course list to reflect the changes
					PopulateCourseList();
				}
				else
				{
					MessageBox.Show("You are already enrolled in this course.");
				}
			}
			else
			{
				MessageBox.Show("Please select a course to enroll in.");
			}
		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			// Check if a course is selected in the list view
			if (listView1.SelectedItems.Count == 1)
			{
				ListViewItem selectedItem = listView1.SelectedItems[0];
				int selectedCourseID = int.Parse(selectedItem.SubItems[0].Text);

				// Find the enrollment entry for the current student and selected course
				string[] enrollmentLines = File.ReadAllLines("students.txt");
				List<string> updatedEnrollments = new List<string>();

				foreach (string enrollmentLine in enrollmentLines)
				{
					string[] enrollmentParts = enrollmentLine.Split(',');
					if (enrollmentParts.Length >= 2)
					{
						int courseID = int.Parse(enrollmentParts[0]);
						int studentID = int.Parse(enrollmentParts[1]);

						if (courseID == selectedCourseID && studentID == currentStudent.Id)
						{
							// Skip this line to unenroll the student from the course
							continue;
						}
					}

					// Add other enrollment entries back to the updated list
					updatedEnrollments.Add(enrollmentLine);
				}

				// Write the updated enrollment list back to the students.txt file
				File.WriteAllLines("students.txt", updatedEnrollments);

				// Update the student's enrolled courses list
				Course selectedCourse = AllCourses.Find(course => course.CourseID == selectedCourseID);
				if (selectedCourse != null)
				{
					currentStudent.WithdrawFromCourse(selectedCourse);
				}

				// Re-populate the course list to reflect the changes
				PopulateCourseList();
			}
			else
			{
				MessageBox.Show("Please select a course to unenroll from.");
			}
		}
	}
}
