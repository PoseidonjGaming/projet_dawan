using projet_dawan.Models;
using SerieDLL_EF.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieDLL_EF.Service
{
    public class ActeurService: Service<Acteur, ActeurRepository>
    {
        public ActeurService():base(new ActeurRepository()) { }

        public List<Acteur> GetByTxt(string txt)
        {
            return repo.GetByTxt(txt);
        }

    }
}
