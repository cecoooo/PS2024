using Microsoft.Extensions.Logging;
using System.Text;
using Welcome.Model;
using Welcome.Others;
using WelcomeExtended.Data;
using WelcomeExtended.Helpers;

class Program
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        ILogger il = LoggerHelper.GetFileLogger("hi");
        try
        {
            UserData userData = new UserData();

            User studentUser = new User()
            {
                Names = "student",
                Password = "123",
                Role = UserRolesEnum.STUDENT
            };
            User u2 = new User()
            {
                Names = "Student2",
                Password = "123",
                Role = UserRolesEnum.STUDENT
            };
            User u3 = new User()
            {
                Names = "Teacher",
                Password = "1234",
                Role = UserRolesEnum.PROFESSOR
            };
            User u4 = new User()
            {
                Names = "Admin",
                Password = "12345",
                Role = UserRolesEnum.ADMIN
            };
            userData.AddUser(studentUser);
            userData.AddUser(u2);
            userData.AddUser(u3);
            userData.AddUser(u4);

            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Pass:");
            string pass = Console.ReadLine();

            userData.ValidateCredentials(name, pass);
            User gu = userData.GetUser(name, pass);

            Console.WriteLine(gu.ToString(true));


            il.LogInformation($"{gu.ToString(true)} - {DateTime.Now.ToString()}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            il.LogError(ex.Message);
        }

    }
}