using projet_dawan.Models;
using SerieDLL_EF.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieDLL_EF.Service
{
    /*
     * Classe qui hérite de la classe Service et qui type Service pour le type Acteur
     */
    public class ActeurService: Service<Acteur, ActeurRepository>
    {
        public ActeurService():base(new ActeurRepository()) { }

        //Récupère la liste des Acteur dont le nom et/ou le prénom contient la chaîne txt
        public List<Acteur> GetByTxt(string txt)
        {
            return repo.GetByTxt(txt);
        }

    }
}
