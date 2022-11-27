using projet_dawan.Model;

namespace projet_dawan.Interface
{
    public interface IUserAppDAO
    {
        void Add(UserApp user);
        void Update(UserApp user);
        void Delete(int id);
        List<UserApp> GetAll();
        UserApp GetById(int id);

    }
}
