

using projet_dawan.Model;

namespace SerieDLL.Interface
{
    public interface IUserAppDAO
    {
        UserApp GetByLogin(string login); 
    }
}