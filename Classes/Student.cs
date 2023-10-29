using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SchoolManagementSystem.Classes
{
    public class Student : User
    {

		public List<Course> EnrolledCourses { get; set; }
		public Teacher teacher { get; set; }

		public Student(User user)
            : base(user.Id, user.UserType, user.Username, user.Password, user.Name)
        {
		    this.EnrolledCourses = new List<Course>();
			this.teacher = teacher;
		}

		public void LoadEnrolledCoursesAndDetails()
		{
			try
			{
				string[] lines = File.ReadAllLines("students.txt");

				foreach (string line in lines)
				{
					string[] parts = line.Split(',');
					if (parts.Length >= 4)
					{
						int courseID = int.Parse(parts[0]);
						int studentID = int.Parse(parts[1]);
						string studentName = parts[2];
						string grade = parts[3];

						if (studentID == this.Id)
						{
							Course enrolledCourse = teacher.GetCourseById(courseID); 
							if (enrolledCourse != null)
							{
								EnrolledCourses.Add(enrolledCourse);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error loading enrolled courses and details: " + ex.Message);
			}
		}

		public void EnrollInCourse(Course course)
		{
			EnrolledCourses.Add(course);
			course.EnrolledStudents.Add(this);
		}

		public void WithdrawFromCourse(Course course)
		{
			EnrolledCourses.Remove(course);
			course.EnrolledStudents.Remove(this);
		}

	}
}
