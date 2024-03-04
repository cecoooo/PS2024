using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Model;
using Welcome.Others;

namespace WelcomeExtended.Data
{
    public class UserData
    {
        private List<User> _users;
        private int _nextId;

        public UserData() 
        {
            _nextId = 0;
            _users = new List<User>();
        }

        public void AddUser(User user) 
        {
            user.Id = _nextId++;
            _users.Add(user);
        }

        public void DeleteUser(User user) 
        {
            _users.Remove(user);
        }

        public User ?GetUser(string name, string password) 
        {
            foreach (var user in _users)
                    if (user.Names == name && user.Password == password)
                    return user;
            
            return null;
        }



        public bool ValidateUser(string name, string password) 
        {
            foreach (var user in _users)
                if (user.Names == name && user.Password == password)
                    return true;
            return false;
        }

        public bool ValidateUserLambda(string name, string password) 
        {
            return _users.Where(x => x.Names == name && x.Password == password).FirstOrDefault() != null? true: false;
        }

        public bool ValidateUserLinq(string name, string password)
        {
            var res = from user in _users
                      where user.Names == name && user.Password == password
                      select user.Id;
            return res != null ? true : false;
        }

        public void setActive(string name, string password) 
        {
            foreach (var user in _users)
                if (user.Names == name && user.Password == password)
                    user.ActiveStatus = true;
        }

        public void setRole(string name, UserRolesEnum role) 
        {
            foreach (var user in _users)
                if (user.Names == name)
                    user.Role = role;
        }
    }
}
