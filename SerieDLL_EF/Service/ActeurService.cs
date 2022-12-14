using SerieDLL_EF.Models;
using SerieDLL_EF.Repository;

namespace SerieDLL_EF.Service
{
    /*
     * Classe qui hérite de la classe Service et qui type Service pour le type Acteur
     */
    public class ActeurService : Service<Acteur, ActeurRepository>
    {
        public ActeurService() : base(new ActeurRepository()) { }

        //Récupère la liste des Acteur dont le nom et/ou le prénom contient la chaîne txt
        public List<Acteur> GetByTxt(string txt)
        {
            return repo.GetByTxt(txt);
        }

    }
}
