using projet_dawan.Models;
using SerieDLL_EF.Interface;
using SerieDLL_EF.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieDLL_EF.Repository
{
    public class UserAppRepository: IRepoCRUD<UserApp>
    {
        public static UserApp GetUser(string login, string password)
        {
            using(BddprojetContext context= new())
            {
                UserService service = new();
                return context.UserApps.Where(u => u.Login == login && u.Password == service.HashPassword(password)).SingleOrDefault();
            }
        }

        public List<UserApp> GetAll()
        {
            using (BddprojetContext context = new())
            {
                return context.UserApps.ToList();
            }
        }

        public UserApp GetById(int id)
        {
            using (BddprojetContext context = new())
            {
                return context.UserApps.Where(u => u.Id == id).SingleOrDefault();
            }
        }


        public void Add(UserApp item)
        {
            using(BddprojetContext context= new())
            {
                UserService service = new();
                context.UserApps.Add(item);
                context.SaveChanges();
            }
        }

        public void Delete(UserApp item)
        {
            using (BddprojetContext context = new())
            {
                context.UserApps.Remove(item);
                context.SaveChanges();
            }
        }

        
        public void Update(UserApp item)
        {
            using (BddprojetContext context = new())
            {
                context.UserApps.Update(item);
                context.SaveChanges();
            }
        }
    }
}
