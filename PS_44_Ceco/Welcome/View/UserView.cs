using Welcome.ViewModel;

namespace Welcome.View
{
    public class UserView
    {
        private UserViewModel _viewModel;
        public UserView(UserViewModel viewModel) {
            _viewModel = viewModel;
        }
        public void Display()
        {
            Console.WriteLine($"Welcome\r\nUser: {_viewModel.Name}\r\nRole: {_viewModel.Role}");
        }
        public void DysplayMoreData() {
            Console.WriteLine($"Welcome\r\nUser: {_viewModel.Name}\r\nRole: {_viewModel.Role}\nEmail: {_viewModel.Email}\nFaculty number: {_viewModel.FacultyNumber}");
        }

        public void DisplayError() 
        {
            throw new Exception("Display Error Message.");
        }
    }
}
