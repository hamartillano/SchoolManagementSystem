using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Classes
{
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public string TeacherName { get; set; }
        public List<Student> EnrolledStudents { get; set; }
        public List<AttendanceRecord> AttendanceRecords { get; set; }

        public Course(int courseID, string courseName, string teacherName)
        {
            this.CourseID = courseID;
            this.CourseName = courseName;
            this.TeacherName = teacherName;
            this.EnrolledStudents = new List<Student>();
            this.AttendanceRecords = new List<AttendanceRecord>();
        }
    }
}
