using SerieDLL_EF.BDD;
using SerieDLL_EF.Interface;
using SerieDLL_EF.Models;

namespace SerieDLL_EF.Repository
{
    //Cette classe implémente les interfaces IRepoCRUD et IRepSpecials pour gérer la table episode
    public class EpisodeRepository : IRepoCRUD<Episode>, IRepSpecials<Episode>
    {
        public List<Episode> GetAll()
        {
            using BddprojetContext context = new();
            return context.Episodes.ToList();
        }

        public Episode GetById(int id)
        {
            using BddprojetContext context = new();
            return context.Episodes.Where(p => p.Id == id).SingleOrDefault();
        }
        public List<Episode> GetBySaison(int saison_id)
        {
            using BddprojetContext context = new();
            return context.Episodes.Where(e => e.SaisonId == saison_id).ToList();
        }

        public List<Episode> GetByTxt(string txt)
        {
            using BddprojetContext context = new();
            return context.Episodes.Where(e => e.Nom.Contains(txt)).ToList();
        }

        public void Add(Episode item)
        {
            using BddprojetContext context = new();
            context.Episodes.Add(item);
            context.SaveChanges();
        }

        public void Update(Episode item)
        {
            using BddprojetContext context = new();
            context.Episodes.Update(item);
            context.SaveChanges();
        }

        public void Delete(Episode item)
        {
            using BddprojetContext context = new();
            context.Episodes.Remove(item);
            context.SaveChanges();
        }

        public bool CompareTo(Episode item)
        {
            using BddprojetContext context = new();
            Episode? episode = context.Episodes.Where(e => e.Nom == item.Nom
            && e.DatePremDiff == item.DatePremDiff && e.Resume == item.Resume).FirstOrDefault();
            return episode != null;
        }

        public Episode GetCompareTo(Episode item)
        {
            using BddprojetContext context = new();
            return context.Episodes.Where(e => e.Nom == item.Nom
            && e.DatePremDiff == item.DatePremDiff && e.Resume == item.Resume).FirstOrDefault();
        }
    }
}
