using SerieDLL_EF.Models;
using SerieDLL_EF.Repository;

namespace SerieDLL_EF.Service
{
    public class SaisonService : Service<Saison, SaisonRepository>
    {
        /*
        * Classe qui hérite de la classe Service et qui type Service pour le type Saison
        */
        public SaisonService(string Cnx) : base() { repo = new(Cnx); }

        //Récupère la liste des saisons qui appartiennent à la série dont l'id est passé en paramètre
        public List<Saison> GetSaisonsBySerie(int id)
        {
            return repo.GetSaisonsBySerie(id);
        }

        public bool CompareTo(Saison saison)
        {
            return repo.CompareTo(saison);
        }

        public Saison GetCompareTo(Saison saison)
        {
            return repo.GetCompareTo(saison);
        }
    }
}
