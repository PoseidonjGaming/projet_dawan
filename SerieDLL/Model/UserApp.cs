using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace projet_dawan.Model
{
    public class UserApp
    {
        private int id;
        private string login;
        private string password;
        private List<Role> roles;


        public List<Role> Roles
        {
            get { return roles; }
            set { roles = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }


        public UserApp()
        {
            roles = new List<Role>();
        }

        public UserApp(string login, string password, List<Role> roles)
        {
            this.login = login;
            this.password = HashPassword(password);
            this.roles = roles;
        }


        public string Login
        {
            get { return login; }
            set { login = value; }
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public static string HashPassword(string? pwd)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(pwd));

                StringBuilder builder = new();

                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2")); // x hexadecimal / 2 : 2 digits
                }

                return builder.ToString();
            }
        }

    }
}
