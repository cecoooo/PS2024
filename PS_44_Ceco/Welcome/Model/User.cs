using Welcome.Others;

namespace Welcome.Model
{
    public class User
    {
        private int id;

		public virtual int Id
		{
			get { return id; }
			set { id = value; }
		}

		private DateTime expires;

		public virtual DateTime Expires
        {
			get { return expires; }
			set { expires = value; }
		}


		private string names;

		public virtual string Names
		{
			get { return names; }
			set { names = value; }
		}

		private string password;

		public virtual string Password
		{
			get { return password; }
			set { password = HashClass.hashPassword(value); }
		}

		private UserRolesEnum role;

		public virtual UserRolesEnum Role
        {
			get { return role; }
			set { role = value; }
		}
		private string facultyNumber;

		public virtual string FacultyNumber
		{
			get { return facultyNumber; }
			set { facultyNumber = value; }
		}

		private string email;

		public virtual string Email
		{
			get { return email; }
			set { email = value; }
		}
    }
}
