using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SchoolManagementSystem.Classes
{
    public class Student : User
    {
        public Student(int ID, UserType UserType, string Username, string Password, string Name)
            : base(ID, UserType, Username, Password, Name)
        {
        }

        public List<Course> EnrolledCourses { get; set; }
    }
}
