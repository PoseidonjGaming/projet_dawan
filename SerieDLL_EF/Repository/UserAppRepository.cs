using projet_dawan.Models;
using SerieDLL_EF.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieDLL_EF.Repository
{
    public class UserAppRepository
    {
        public static UserApp? GetUser(string login, string password)
        {
            using(BddprojetContext context= new())
            {
                return context.UserApps.Where(u => u.Login == login && u.Password == UserService.HashPassword(password)).ToList()[0];
            }
        }
    }
}
