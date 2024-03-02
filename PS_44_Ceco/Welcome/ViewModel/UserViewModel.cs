using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Model;
using Welcome.Others;

namespace Welcome.ViewModel
{
    public class UserViewModel
    {
        public UserViewModel(User user) {
            _user = user;
        }

        private User _user;
        private string name;

        public string Name
        {
            get { return _user.Names; }
            set { name = _user.Names; }
        }
        private string password;
        public string Password
        {
            get { return _user.Password; }
            set { password = _user.Password; }
        }
        private UserRolesEnum role;
        public UserRolesEnum Role
        {
            get { return _user.Role; }
            set { role = _user.Role; }
        }

        private string email;

        public string Email
        {
            get { return _user.Email; }
            set { _user.Email = value; }
        }

        private string faucltyNumber;

        public string FacultyNumber
        {
            get { return _user.FacultyNumber; }
            set { _user.FacultyNumber = value; }
        }
    }
}
