using DataLayer.Database;
using DataLayer.Model;
using Microsoft.Extensions.Logging;
using System.Text;
using DataLayer.Database;
using DataLayer.Model;
using Welcome.Others;
using DataLayer.Helpers;

class Program
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        using (var context = new DatabaseContext())
        {
            ILogger logger = LoggerHelper.GetDbLogger("db");
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            context.Add<DatabaseUser>(new DatabaseUser()
            {
                Names = "user",
                Password = "password",
                Expires = DateTime.Now,
                Role = UserRolesEnum.STUDENT,
                FacultyNumber = "121221",
                Email = "ff@ff"
            });
            context.SaveChanges();
            var users = context.Users.ToList();
            Console.WriteLine("Username:");
            string username = Console.ReadLine();
            Console.WriteLine("Password:");
            string password = Console.ReadLine();

            var usss = context.Users.Where(x => x.Names == username).Where(x => x.Password == password).FirstOrDefault();

            if (usss != null)
            {
                Console.WriteLine("Invalid User.");
            }
            else
            {
                Console.WriteLine("Invalid data");
                Environment.Exit(0);
            }

            while (true)
            {
                Console.WriteLine("Chose:");
                Console.WriteLine("1: All");
                Console.WriteLine("2: Add");
                Console.WriteLine("3: Del");
                Console.WriteLine("4: Logs");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        var allUsers = context.Users.ToList();
                        Console.WriteLine();
                        Console.WriteLine("- - - -");
                        foreach (var sUser in allUsers)
                        {
                            Console.WriteLine(sUser.Names);
                        }
                        Console.WriteLine("- - - -");
                        Console.WriteLine();
                        logger.LogInformation("listed users");
                        break;

                    case 2:
                        Console.WriteLine("Username:");
                        string addUname = Console.ReadLine();
                        Console.WriteLine("Password:");
                        string addPass = Console.ReadLine();

                        context.Add<DatabaseUser>(new DatabaseUser()
                        {
                            Names = addUname,
                            Password = addPass,
                            Expires = DateTime.Now,
                            Role = UserRolesEnum.STUDENT,
                            FacultyNumber = "@",
                            Email = "@"
                        });
                        context.SaveChanges();
                        logger.LogInformation("added user");
                        break;
                    case 3:
                        Console.WriteLine("Username:");
                        string rUname = Console.ReadLine();
                        context.Remove<DatabaseUser>(context.Users.Where(x => x.Names == rUname).First());
                        context.SaveChanges();
                        logger.LogInformation("deleted user");
                        break;
                    case 4:
                        var allLogs = context.Logs.ToList();
                        foreach (var log in allLogs)
                        {
                            Console.WriteLine(log.Message);
                        }
                        logger.LogInformation("listed logs");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}