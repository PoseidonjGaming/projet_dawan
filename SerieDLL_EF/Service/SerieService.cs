using SerieDLL_EF.Models;
using SerieDLL_EF.Repository;

namespace SerieDLL_EF.Service
{
    /*
    * Classe qui hérite de la classe Service et qui type Service pour le type Série
    */
    public class SerieService : Service<Serie, SerieRepository>
    {
        public SerieService() : base() {  }

        //Récupère la liste des séries dont l'id est présent dans la liste toWatch
        public List<Serie> ExportWatchList(List<int> toWatch)
        {
            return repo.ExportWatchList(toWatch);
        }

        //Récupère la liste des séries dont le nom contient la chaîne txt
        public List<Serie> GetByTxt(string text)
        {
            return repo.GetByTxt(text);
        }

        //Récupère la liste des séries dans l'ordre des dernière ajoutées ddans la base de données
        public List<Serie> LastAdd()
        {
            return repo.LastAdd();
        }







    }
}