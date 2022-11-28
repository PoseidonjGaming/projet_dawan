using projet_dawan.Model;

namespace projet_dawan.Interface
{
    public interface IRoleDAO
    {
        void Add(Role role);
        void Update(Role role);
        void Delete(int id);
        List<Role> GetAll();
        Role GetById(int id);
        List<Role> GetRolesUser(UserApp user);
    }
}
