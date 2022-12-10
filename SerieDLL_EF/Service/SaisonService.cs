using projet_dawan.Models;
using SerieDLL_EF.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieDLL_EF.Service
{
    public class SaisonService : Service<Saison, SaisonRepository>
    {
        /*
        * Classe qui hérite de la classe Service et qui type Service pour le type Saison
        */
        public SaisonService() : base(new SaisonRepository())
        {

        }

        //Récupère la liste des saisons qui appartiennent à la série dont l'id est passé en paramètre
        public List<Saison> GetSaisonsBySerie(int id)
        {
            return repo.GetSaisonsBySerie(id);
        }
    }
}
