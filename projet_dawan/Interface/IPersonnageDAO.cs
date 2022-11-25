using projet_dawan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_dawan.Interface
{
    public interface IPersonnageDAO
    {
        void Add(Personnage perso);
        void Update(Personnage perso);
        void Delete(int id);
        List<Personnage> GetAll();
        Personnage GetById(int id);
    }
}
