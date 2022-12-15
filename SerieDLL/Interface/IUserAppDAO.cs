using projet_dawan.DAO;
using SerieDLL.Model;

namespace SerieDLL.Interface
{
    public interface IUserAppDAO
    {
        UserApp? GetByLogin(string login); 
    }
}