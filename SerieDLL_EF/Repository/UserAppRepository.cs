using SerieDLL_EF.Interface;
using SerieDLL_EF.Models;

namespace SerieDLL_EF.Repository
{
    public class UserAppRepository : IRepoCRUD<UserApp>
    {
        public UserApp GetUser(string login, string password)
        {
            using (BddprojetContext context = new())
            {

                return context.UserApps.Where(u => u.Login == login && u.Password == password).SingleOrDefault();
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
            using (BddprojetContext context = new())
            {
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

        public bool CompareTo(UserApp obj)
        {
            throw new NotImplementedException();
        }

        public UserApp GetCompareTo(UserApp obj)
        {
            throw new NotImplementedException();
        }
    }
}
