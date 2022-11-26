using Microsoft.VisualBasic.ApplicationServices;
using projet_dawan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
