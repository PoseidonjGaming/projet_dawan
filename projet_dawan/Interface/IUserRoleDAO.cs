using Microsoft.VisualBasic.ApplicationServices;
using projet_dawan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_dawan.Interface
{
    public interface IUserRoleDAO
    {
        void Add(UserApp user, Role role);
        void Update(UserApp user, Role role, int id);
        void Delete(int id);
        List<UserApp> GetAllUser(int id);
        List<Role> GetAllRole(int id);

    }
}
