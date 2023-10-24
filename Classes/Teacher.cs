using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Classes
{
    public class Teacher : User
    {
        public List<Course> TeachingCourses { get; set; }
        public List<Student> EnrolledStudents { get; set; }

        public Teacher(UserType userType, string username, string password, string name)
            : base(userType, username, password, name)
        {
            this.TeachingCourses = new List<Course>();
            this.EnrolledStudents = new List<Student>();
        }
    }
}
