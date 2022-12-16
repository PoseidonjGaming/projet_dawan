using SerieDLL_EF.Models;
using SerieDLL_EF.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SerieDLL_EF.Service
{
    public class UserService: Service<UserApp, UserAppRepository>
    {
        public UserService():base(new UserAppRepository())
        {

        }

        public UserApp GetUser(string login, string pwd)
        {
            return repo.GetUser(login, HashPassword(pwd));
        }

        public string HashPassword(string? pwd)
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

