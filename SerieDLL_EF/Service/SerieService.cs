using SerieDLL_EF.Models;
using SerieDLL_EF.Repository;

namespace SerieDLL_EF.Service
{
    /*
    * Classe qui hérite de la classe Service et qui type Service pour le type Série
    */
    public class SerieService : Service<Serie, SerieRepository>
    {
        public SerieService() : base(new SerieRepository()) { }

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

        //Vérifie si la série passée en paramètre existe dans la base de donnée.
        //Revoie true si elle existe et false dans le cas contraire
        public bool CompareTo(Serie serie)
        {
            return repo.CompareTo(serie);
        }

        public Serie GetCompareTo(Serie serie)
        {
            return repo.GetCompareTo(serie);
        }


    }
}