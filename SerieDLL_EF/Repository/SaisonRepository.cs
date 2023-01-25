using SerieDLL_EF.BDD;
using SerieDLL_EF.Interface;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;

namespace SerieDLL_EF.Repository
{
    /*
     * Les Répositories sont les classes qui gèrent la bdd.
     * Dans notre cas, elles implèmentent les interfaces du dossier Interface, pour plus de simplicité
     * Cette classe implémente les interfaces IRepoCRUD et IRepSpecials pour gérer la table saison
     */
    public class SaisonRepository : IRepoCRUD<Saison>, IRepSpecials<Saison>
    {
        /*
         * Récupère toutes les saisons depuis la base données
         */
        public List<Saison> GetAll()
        {
            using BddprojetContext context = new();
            return context.Saisons.ToList();
        }

        /*
         * Récupère la saison dont l'id correxpond à l'id passé en paramètre
         */
        public Saison GetById(int id)
        {
            using BddprojetContext context = new();
            return context.Saisons.Where(sa => sa.Id == id).SingleOrDefault();
        }

        /*
         * Récupère la saison dont l'id de la série associée
         * correspond à l'id passé en paramètre
         */
        public List<Saison> GetSaisonsBySerie(int id)
        {
            using BddprojetContext context = new();
            return context.Saisons.Where(sa => sa.SerieId == id).ToList();
        }

        /*
         * Ajoute la saison passée en paramètre dans la base de données
         */
        public void Add(Saison item)
        {
            using BddprojetContext context = new();
            context.Saisons.Add(item);
            context.SaveChanges();
        }

        /*
         * Modifie la saison passée en paramètre dans la base de données
         */
        public void Update(Saison item)
        {
            using BddprojetContext context = new();
            context.Saisons.Update(item);
            context.SaveChanges();
        }

        /*
         * Supprime dans la base de donneés la saison passée en paramètre
         */
        public void Delete(Saison item)
        {
            using BddprojetContext context = new();
            context.Saisons.Remove(item);
            context.SaveChanges();
        }

        /*
         * Récupère la saison dont le numèro
         * correspond au texte passé en paramètre
         */
        public List<Saison> GetByTxt(string txt)
        {
            using BddprojetContext context = new();
            return context.Saisons.Where(sa => sa.Numero == short.Parse(txt)).ToList();
        }

        /*
         * Vérif si une saison dont
         * le numéro, le nombre d'épisodes et l'id de la série associée
         * correspondent à ceux de la saison passée en paramètre
         * existe dans la base de données
         */
        public bool CompareTo(Saison saison)
        {
            using BddprojetContext context = new();
            Saison? oldSaison = context.Saisons.Where(sa => sa.Numero == saison.Numero
            && sa.NbEpisode == saison.NbEpisode && sa.SerieId == saison.SerieId).FirstOrDefault();
            return oldSaison != null;
        }

        /*
         * Récupère la saison, depuis la base de données, dont
         * le numéro, le nombre d'épisodes et l'id de la série associée
         * correspondent à ceux de la saison passée en paramètre
         */
        public Saison GetCompareTo(Saison saison)
        {
            SerieService serieService = new();
            using BddprojetContext context = new();
            return context.Saisons.Where(sa => sa.Numero == saison.Numero
            && sa.NbEpisode == saison.NbEpisode && sa.SerieId == saison.SerieId).FirstOrDefault();
        }
    }
}
