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
            return repo.GetUser(userApp.Login, HashPassword(userApp).Password);
        }


        public override void Add(UserApp item)
        {

            base.Add(HashPassword(item));
        }

        public override void Update(UserApp item)
        {
            
            base.Update(HashPassword(item));
        }


        public UserApp HashPassword(UserApp user)
        {

            using SHA256 sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(user.Password));

            StringBuilder builder = new();

            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2")); // x hexadecimal / 2 : 2 digits
            }

            user.Password = builder.ToString();
            return user;
        }
    }


}


