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
        void Add(UserApp user);
        void Update(UserApp user, Role role);
        void Delete(UserApp user, Role role);
        List<UserApp> GetAllUser(int id);
        List<Role> GetAllRole(int id);

    }
}
