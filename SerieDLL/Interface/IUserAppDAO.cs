
using SerieDLL.Model;

namespace SerieDLL.Interface
{
    public interface IUserAppDAO
    {
        UserApp GetByLogin(string login); 
    }
}