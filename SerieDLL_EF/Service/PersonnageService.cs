using SerieDLL_EF.Models;
using SerieDLL_EF.Repository;

namespace SerieDLL_EF.Service
{
    /*
    * Classe qui hérite de la classe Service et qui type Service pour le type Personnage
    */
    public class PersonnageService : Service<Personnage, PersonnageRepository>
    {

        public PersonnageService() : base(new PersonnageRepository())
        {

        }

        //Récupère la liste des personnages en fonction de la série dont l'id est passé en paramètre
        public List<Personnage> GetBySerie(int serie_id)
        {
            return repo.GetBySerie(serie_id);
        }

        //Récupère la liste des personnages dont le nom contient la chaîne txt
        public List<Personnage> GetByTxt(string txt)
        {
            return repo.GetByTxt(txt);
        }

        //Rècupère la liste des personnages qui sont intèrprèté par l'acteur dont l'id est passé en paramètre
        public List<Personnage> GetByActeur(int actur_id)
        {
            return repo.GetByActeur(actur_id);
        }
    }
}
