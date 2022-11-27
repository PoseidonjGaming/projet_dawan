using Microsoft.VisualBasic.ApplicationServices;
using projet_dawan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_dawan.Interface
{
    public interface IUserAppDAO
    {
        void Add(UserApp user);
        void Update(UserApp user);
        void Delete(int id);
        List<UserApp> GetAll();
        UserApp GetById(int id);

    }
}
