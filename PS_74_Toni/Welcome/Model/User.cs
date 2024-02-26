using System;
using System.Collections.Generic;
using System.Linq;
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
			set { password = value; }
		}

		private UserRolesEnum role;

		public UserRolesEnum Role
        {
			get { return role; }
			set { role = value; }
		}
	}
}
