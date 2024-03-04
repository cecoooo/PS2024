using Welcome.Others;

namespace Welcome.Model
{
    public class User
    {
		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		private bool activeStatus;

		public bool ActiveStatus
		{
			get { return activeStatus; }
			set { activeStatus = value; }
		}


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
