using projet_dawan.Models;
using SerieDLL_EF.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieDLL_EF.Service
{
    public class PersonnageService: Service<Personnage, PersonnageRepository>
    {

        public PersonnageService() : base(new PersonnageRepository())
        {

        }


        public List<Personnage> GetBySerie(int serie_id)
        {
            return repo.GetBySerie(serie_id);
        }

        public List<Personnage> GetByTxt(string txt)
        {
            return repo.GetByTxt(txt);
        }
    }
}
