using projet_dawan.Model;

namespace projet_dawan.Interface
{
    public interface IRoleDAO
    {
        List<Role> GetRolesUser(UserApp user);
    }
}
