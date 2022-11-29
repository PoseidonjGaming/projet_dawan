using projet_dawan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieDLL.Interface
{
    internal interface ISaisonDao
    {
        List<Saison> GetSaisons(int id);
    }
}
