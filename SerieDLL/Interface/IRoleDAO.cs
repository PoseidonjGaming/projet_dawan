using SerieDLL.Model;

namespace SerieDLL.Interface
{
    public interface IRoleDAO
    {
        List<Role> GetRolesUser(UserApp user);
    }
}
