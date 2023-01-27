using SerieDLL_EF.Models;
using SerieDLL_EF.Repository;

namespace SerieDLL_EF.Service
{
    /*
     * Classe qui hérite de la classe Service et qui type Service pour le type Episode
     */
    public class EpisodeService : Service<Episode, EpisodeRepository>
    {
        public EpisodeService() : base() { }

        //Récupère la liste des épisodes qui appartienent à la saison spécifié
        public List<Episode> GetBySaison(int saison)
        {
            return repo.GetBySaison(saison);
        }

        //Récupère la liste des épisodes dont le nom contient la chaîne txt
        public List<Episode> GetByTxt(string text)
        {
            return repo.GetByTxt(text);
        }

        //Vérifie si l'épisode passé en paramètre existe dans la base de donnée.
        //Revoie true si elle existe et false dans le cas contraire
        public bool CompareTo(Episode episode)
        {
            return repo.CompareTo(episode);
        }

        public Episode GetCompareTo(Episode episode)
        {
            return repo.GetCompareTo(episode);
        }
    }
}