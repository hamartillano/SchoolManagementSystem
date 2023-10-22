using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Classes
{
    public class User
    {
        public string UserType { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User(string userType, string username, string password)
        {
            this.UserType = userType;
            this.Username = username;
            this.Password = password;
        }
    }
}
