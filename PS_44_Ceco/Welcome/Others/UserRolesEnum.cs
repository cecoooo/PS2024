using System.Security.Cryptography;
using System.Text;

namespace Welcome.Others
{
    public enum UserRolesEnum {
        ANONYMOUS,
        ADMIN,
        INSPECTOR,
        PROFESSOR,
        STUDENT
    }

    public static class HashClass
    {
        public static string hashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}