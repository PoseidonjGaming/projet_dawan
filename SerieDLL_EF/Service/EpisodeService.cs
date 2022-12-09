using projet_dawan.Models;
using SerieDLL_EF.Repository;

namespace SerieDLL_EF.Service
{
    public class EpisodeService: Service<Episode, EpisodeRepository>
    {
        public EpisodeService():base(new EpisodeRepository()) { }

        public List<Episode> GetBySaison(int saison)
        {
            return repo.GetBySaison(saison);
        }
    }
}