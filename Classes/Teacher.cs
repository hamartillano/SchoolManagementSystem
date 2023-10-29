using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Classes
{
    public class Teacher : User
    {
        public List<Course> TeachingCourses { get; set; }

        public Teacher(User user)
            : base(user.Id, user.UserType, user.Username, user.Password, user.Name)
        {
            this.TeachingCourses = new List<Course>();
            LoadTeachingCourses();
        }
        private List<Course> LoadTeachingCourses()
        {
            try
            {
                string[] lines = File.ReadAllLines("courses.txt");

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts[2] == this.Id.ToString())
                    {
                        int courseID = int.Parse(parts[0]);
                        string courseName = parts[1];

                        Course course = new Course
                        {
                            CourseID = courseID,
                            CourseName = courseName,
                            TeacherID = this.Id
                        };

                        TeachingCourses.Add(course);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading teaching courses: " + ex.Message);
            }

            return TeachingCourses;
        }

		public Course GetCourseById(int courseId)
		{
			foreach (Course course in TeachingCourses)
			{
				if (course.CourseID == courseId)
				{
					return course; // Course found
				}
			}
			return null; // Course not found
		}

	
    }
}
