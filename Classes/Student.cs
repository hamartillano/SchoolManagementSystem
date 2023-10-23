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
        public List<Course> EnrolledCourses { get; set; }
        public Dictionary<Course, double> Grade { get; set; }
        public Dictionary<Course, List<AttendanceRecord>> Attendance {  get; set; }

        public Student(UserType userType, string username, string password, string name)
            : base(userType, username, password, name)
        {
            this.EnrolledCourses = new List<Course>();
            this.Grade = new Dictionary<Course, double>();
            this.Attendance = new Dictionary<Course, List<AttendanceRecord>>();
        }
    }
}
