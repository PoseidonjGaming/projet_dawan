using SerieDLL.Model;

namespace SerieDLL.Interface
{
    public interface IUserRoleDAO
    {
        void Add(UserApp user, Role role);
        void Update(UserApp user, Role role, Role oldRole);
        void Delete(UserApp user, Role role);

        List<UserApp> GetAllUser(int id);
        List<Role> GetAllRole(int id);

    }
}
