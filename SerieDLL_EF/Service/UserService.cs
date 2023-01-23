using SerieDLL_EF.Models;
using SerieDLL_EF.Repository;
using System.Security.Cryptography;
using System.Text;

namespace SerieDLL_EF.Service
{
    public class UserService : Service<UserApp, UserAppRepository>
    {
        public UserService() : base(new UserAppRepository()) { }

        public UserApp GetUser(UserApp userApp)
        {
            return repo.GetUser(userApp.Login, HashPassword(userApp.Password));
        }

        public UserApp GetByLogin(UserApp user)
        {
            return repo.GetByLogin(user);
        }

        public override void Add(UserApp item)
        {
            item.Password= HashPassword(item.Password);
            base.Add(item);
        }

        public override void Update(UserApp item)
        {
            item.Password = HashPassword(item.Password);
            base.Update(item);
        }


        public string HashPassword(string password)
        {

            using SHA256 sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

            StringBuilder builder = new();

            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2")); // x hexadecimal / 2 : 2 digits
            }

            password = builder.ToString();
            return password;
        }
    }


}


