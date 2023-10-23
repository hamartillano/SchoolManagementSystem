using System;
using System.Collections.Generic;
using System.IO;
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

        public static void WriteUserToFile(User user)
        {
            try
            {
                string[] lines = File.ReadAllLines("login.txt");
                string newUserEntry = $"{user.UserType}:{user.Username}:{user.Password}";
                var updatedLines = lines.Concat(new[] { newUserEntry });
                File.WriteAllLines("login.txt", updatedLines);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while writing to the file: {ex.Message}");
            }
        }

        public static bool UserExists(string userType, string username)
        {
            try
            {
                string[] lines = File.ReadAllLines("login.txt");

                bool userExists = lines
                    .Where(line => line.Split(':').Length == 3)
                    .Any(line =>
                    {
                        var parts = line.Split(':');
                        return parts[0] == userType && parts[1] == username;
                    });

                return userExists;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while checking the file: {ex.Message}");
                return false;
            }
        }
    }
}
