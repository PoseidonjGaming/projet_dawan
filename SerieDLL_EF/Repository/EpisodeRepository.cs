using SerieDLL_EF.BDD;
using SerieDLL_EF.Interface;
using SerieDLL_EF.Models;

namespace SerieDLL_EF.Repository
{
    /*
     * Les Répositories sont les classes qui gèrent la bdd.
     * Dans notre cas, elles implèment les interfaces du dossier Interface, pour plus de simplicité
     * Cette classe implémente les interfaces IRepoCRUD et IRepSpecials pour gérer la table episode
     */
    public class EpisodeRepository : IRepoCRUD<Episode>, IRepSpecials<Episode>
    {
        /*
         * Récupère tous les épisodes depuis la base de données
         */
        public List<Episode> GetAll()
        {
            using BddprojetContext context = new();
            return context.Episodes.ToList();
        }

        /*
         * Récupère l'épisode depuis la base de données
         * dont l'id correspond à l'id passé en paramètre
         */
        public Episode GetById(int id)
        {
            using BddprojetContext context = new();
            return context.Episodes.Where(p => p.Id == id).SingleOrDefault();
        }

        /*
         *Récupère les épisodes depuis la base données
         *dont l'id de la saison associé
         *correspond à l'id passé en paramètre
         */
        public List<Episode> GetBySaison(int saison_id)
        {
            using BddprojetContext context = new();
            return context.Episodes.Where(e => e.SaisonId == saison_id).ToList();
        }

        /*
         * Récupère les épisodes dont le nom conitent
         * le texte passé en paramètre
         */
        public List<Episode> GetByTxt(string txt)
        {
            using BddprojetContext context = new();
            return context.Episodes.Where(e => e.Nom.Contains(txt)).ToList();
        }

        /*
         * Ajoute dans la base de données l'épisode passé en paramètre
         */
        public void Add(Episode item)
        {
            using BddprojetContext context = new();
            context.Episodes.Add(item);
            context.SaveChanges();
        }

        /*
         * Modifie dans la base de données, l'épisode passé en paramètre 
         */
        public void Update(Episode item)
        {
            using BddprojetContext context = new();
            context.Episodes.Update(item);
            context.SaveChanges();
        }
        
        /*
         * Supprime dans la base de données, l'épisode passé en paramètre
         */
        public void Delete(Episode item)
        {
            using BddprojetContext context = new();
            context.Episodes.Remove(item);
            context.SaveChanges();
        }

        /*
         * Vérifie si l'épisode passé existe dans la base de données
         */
        public bool CompareTo(Episode item)
        {
            using BddprojetContext context = new();
            Episode? episode = context.Episodes.Where(e => e.Nom == item.Nom
            && e.DatePremDiff == item.DatePremDiff && e.Resume == item.Resume).FirstOrDefault();
            return episode != null;
        }

        /*
         * Récupère l'épisode depuis la base de données
         * dont les nom, prénom, datePremDiff correspondent
         * à ceux de l'épisode passé en paramètre
         */
        public Episode GetCompareTo(Episode item)
        {
            using BddprojetContext context = new();
            return context.Episodes.Where(e => e.Nom == item.Nom
            && e.DatePremDiff == item.DatePremDiff && e.Resume == item.Resume).FirstOrDefault();
        }

        public Episode Export(int id)
        {
            using BddprojetContext context = new();
            return context.Episodes.Where(e => e.Id == id).ToList().FirstOrDefault();

        }
    }
}
