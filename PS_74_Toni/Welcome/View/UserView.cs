using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.ViewModel;

namespace Welcome.View
{
    class UserView
    {
        private UserViewModel _viewModel;
        public UserView(UserViewModel viewModel) {
            _viewModel = viewModel;
        }
        public void Display()
        {
            Console.WriteLine($"Welcome\r\nUser: {_viewModel.Name}\r\nRole: {_viewModel.Role}");
        }
    }
}
