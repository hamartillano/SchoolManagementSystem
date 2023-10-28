using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Classes
{
    public enum UserType
    {
        Admin,
        Teacher,
        Student
    }

    public class User
    {
        public int Id { get; set; }
        public UserType UserType { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }

        public User(int ID, UserType UserType, string Username, string Password, string Name)
        {
            this.Id = ID;
            this.UserType = UserType;
            this.Username = Username;
            this.Password = Password;
            this.Name = Name;
        }
    }
}
