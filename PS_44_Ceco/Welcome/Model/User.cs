using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Welcome.Others;

namespace Welcome.Model
{
    class User
    {
		private string names;

		public string Names
		{
			get { return names; }
			set { names = value; }
		}

		private string password;

		public string Password
		{
			get { return password; }
			set { password = HashClass.hashPassword(value); }
		}

		private UserRolesEnum role;

		public UserRolesEnum Role
        {
			get { return role; }
			set { role = value; }
		}
		private string facultyNumber;

		public string FacultyNumber
		{
			get { return facultyNumber; }
			set { facultyNumber = value; }
		}

		private string email;

		public string Email
		{
			get { return email; }
			set { email = value; }
		}
    }
}
