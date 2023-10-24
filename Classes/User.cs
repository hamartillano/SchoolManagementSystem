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
        public UserType UserType { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }

        public User(UserType userType, string username, string password, string name)
        {
            this.UserType = userType;
            this.Username = username;
            this.Password = password;
            this.Name = name;
        }

        public static void WriteUserToLoginFile(User user)
        {
            try
            {
                string[] lines = File.ReadAllLines("login.txt");
                string newUserEntry = $"{user.UserType}:{user.Username}:{user.Password}:{user.Name}";
                var updatedLines = lines.Concat(new[] { newUserEntry });
                File.WriteAllLines("login.txt", updatedLines);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while writing to the file: {ex.Message}");
            }
        }

        public static bool UserLoginExists(UserType userType, string username)
        {
            try
            {
                string[] lines = File.ReadAllLines("login.txt");

                bool userExists = lines
                    .Where(line => line.Split(':').Length == 4)
                    .Any(line =>
                    {
                        var parts = line.Split(':');
                        return Enum.TryParse<UserType>(parts[0], out var parsedType) &&
                               parsedType == userType &&
                               parts[1] == username;
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
