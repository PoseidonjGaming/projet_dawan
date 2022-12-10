using projet_dawan.Models;
using SerieDLL_EF.Repository;

namespace SerieDLL_EF.Service
{
    /*
     * Classe qui hérite de la classe Service et qui type Service pour le type Episode
     */
    public class EpisodeService: Service<Episode, EpisodeRepository>
    {
        public EpisodeService():base(new EpisodeRepository()) { }

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
    }
}