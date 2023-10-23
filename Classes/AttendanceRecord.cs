using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Classes
{
    public class AttendanceRecord
    {
        public DateTime DateTime { get; set; }
        public List<Student> PresentStudents { get; set; }

        public AttendanceRecord(DateTime dateTime)
        {
            this.DateTime = dateTime;
            this.PresentStudents = new List<Student>();
        }
    }
}
