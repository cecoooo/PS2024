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
        public int Id
        {
            get { return _user.Id; }
            set { _user.Id = value; }
        }
        public DateTime Expires
        {
            get { return _user.Expires; }
            set { _user.Expires = value; }
        }


        public string Name
        {
            get { return _user.Names; }
            set { _user.Names = _user.Names; }
        }
        public string Password
        {
            get { return _user.Password; }
            set { _user.Password = _user.Password; }
        }
        public UserRolesEnum Role
        {
            get { return _user.Role; }
            set { _user.Role = value; }
        }

        public string Email
        {
            get { return _user.Email; }
            set { _user.Email = value; }
        }

        public string FacultyNumber
        {
            get { return _user.FacultyNumber; }
            set { _user.FacultyNumber = value; }
        }
    }
}
