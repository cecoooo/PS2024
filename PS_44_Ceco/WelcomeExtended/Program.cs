using System.Data;
using Welcome.Model;
using Welcome.Others;
using Welcome.View;
using Welcome.ViewModel;
using static WelcomeExtended.Others.Delegates;

namespace WelcomeExtended
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
				var user = new User
				{
					Names = "John Smith",
					Password = "password123",
					Role = UserRolesEnum.STUDENT
				};

				var viewModel = new UserViewModel(user);
				var view = new UserView(viewModel);
				view.Display();

				// Error
				view.DisplayError();
			}
			catch (Exception e)
			{
				var log = new ActionError(Log);
				log(e.Message);
			}
			finally
			{
                Console.WriteLine("Executed in any case!");
            }
        }
    }
}
