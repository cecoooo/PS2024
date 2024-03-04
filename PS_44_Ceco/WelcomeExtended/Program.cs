using System.Data;
using Welcome.Model;
using Welcome.Others;
using Welcome.View;
using Welcome.ViewModel;
using WelcomeExtended.Data;
using WelcomeExtended.Helpers;
using static WelcomeExtended.Others.Delegates;

namespace WelcomeExtended
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
				UserData userData = new UserData();

				User studentUser = new User() 
				{
					Names = "student123",
					Password = "123",
					Role = UserRolesEnum.STUDENT
				};
				userData.AddUser(studentUser);
                User teacherUser = new User()
                {
                    Names = "Teacher",
                    Password = "1234",
                    Role = UserRolesEnum.PROFESSOR
                };
                userData.AddUser(studentUser);
                User adminUser = new User()
                {
                    Names = "Admin",
                    Password = "12345",
                    Role = UserRolesEnum.ADMIN
                };

                Console.Write("Enter name: ");
                var name = Console.ReadLine();
                Console.Write("Enter password: ");
                var password = Console.ReadLine();
                User user = new User();

                Console.WriteLine(UserHelper.ToString(UserHelper.GetUser(user, name, password)));
            }
			catch (Exception e)
			{
				var log = new ActionError(Log);
				log(e.Message);
			}
			finally
			{
                Console.WriteLine("\nExecuted in any case!");
            }
        }
    }
}
