using projet_dawan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_dawan.Interface
{
    public interface IActeurDAO
    {
        void Add(Acteur acteur);
        void Update(Acteur acteur);
        void Delete(int id);
        List<Acteur> GetAll();
        Acteur GetById(int id);
    }
}
