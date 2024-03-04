using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Model;
using WelcomeExtended.Data;

namespace WelcomeExtended.Helpers
{
    public static class UserHelper
    {
        public static string ToString(this User user) 
        {
            return $"User name: {user.Names}\n" +
                $"Faculty number: {user.FacultyNumber}\n" +
                $"Email: {user.Email}\n" +
                $"Role: {user.Role}\n" +
                $"Active/Unactive: {user.ActiveStatus}";
        }

        public static void ValidateCredentials(this User user, string name, string password)
        {
            if (name == null)
                throw new Exception($"The name field cannot be empty");
            else if (password == null)
                throw new Exception($"The password field cannot be empty");

            user.Password = password;
            user.Names = name;
        }

        public static User GetUser(this User user, string name, string password)
        {
            user.ValidateCredentials(name, password);
            return user;
        }
    }
}
