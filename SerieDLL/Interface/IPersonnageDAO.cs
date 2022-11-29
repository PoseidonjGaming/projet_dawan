using projet_dawan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieDLL.Interface
{
    internal interface IPersonnageDAO
    {
        List<Personnage> GetPersonnages(int id);
    }
}
