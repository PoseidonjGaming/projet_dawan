using projet_dawan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_dawan.Interface
{
    public interface ISaisonDAO
    {
        void Add(Saison acteur);
        void Update(Saison acteur);
        void Delete(int id);
        List<Saison> GetAll();
        Saison GetById(int id);
    }
}
