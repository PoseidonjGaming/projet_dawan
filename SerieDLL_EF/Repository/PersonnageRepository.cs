using SerieDLL_EF.BDD;
using SerieDLL_EF.Interface;
using SerieDLL_EF.Models;

namespace SerieDLL_EF.Repository
{
    /*
     * Les Répositories sont les classes qui gèrent la bdd.
     * Dans notre cas, elles implèmentent les interfaces du dossier Interface, pour plus de simplicité
     * Cette classe implémente les interfaces IRepoCRUD et IRepSpecials pour gérer la table personnage
     */
    public class PersonnageRepository : IRepoCRUD<Personnage>, IRepSpecials<Personnage>
    {
        /*
         * Réécupère tous les personnages depuis la base de données
         */
        public List<Personnage> GetAll()
        {
            using BddprojetContext context = new();
            return context.Personnages.ToList();
        }

        /*
         * Récupère le personnage dont l'id correspond
         * à l'id passée en paramètre
         */
        public Personnage GetById(int id)
        {
            using BddprojetContext context = new();
            return context.Personnages.Where(p => p.Id == id).ToList()[0];
        }

        /*
         * Récupère les personnages dont l'id de la série associée
         * correspond à l'id passé en paramètre
         */
        public List<Personnage> GetBySerie(int serie_id)
        {
            using BddprojetContext context = new();
            return context.Personnages.Where(p => p.SerieId == serie_id).ToList();
        }

        /*
         * Récupère les personnages dont le nom
         * contient le texte passé en paramètre
         */
        public List<Personnage> GetByTxt(string txt)
        {
            using BddprojetContext context = new();
            return context.Personnages.Where(p => p.Nom.Contains(txt)).ToList();
        }

        /*
         * Récupère les personnages dont l'id de l'acteur associé
         * correspond à l'id passé en paramètre
         */
        public List<Personnage> GetByActeur(int acteur_id)
        {
            using BddprojetContext context = new();
            return context.Personnages.Where(p => p.ActeurId == acteur_id).ToList();
        }

        /*
         * Ajoute le personnage passé en paramètre dans la base de données
         */
        public void Add(Personnage item)
        {
            using BddprojetContext context = new();
            context.Personnages.Add(item);
            context.SaveChanges();
        }

        /*
         * Modifie le personnage passé en paramètre dans la base de données
         */
        public void Update(Personnage item)
        {
            using BddprojetContext context = new();
            context.Personnages.Update(item);
            context.SaveChanges();
        }

        /*
         * Supprime le personnage passé en paramètre dans la base de données
         */
        public void Delete(Personnage item)
        {
            using BddprojetContext context = new();
            context.Personnages.Remove(item);
            context.SaveChanges();
        }

        /*
         * Vérifie si le personnage dont le nom 
         * correspond à celui du personnage passé en paramètre
         */
        public bool CompareTo(Personnage item)
        {
            using BddprojetContext context = new();
            Personnage? personnage = context.Personnages.Where(p => p.Nom == item.Nom).FirstOrDefault();
            return personnage != null;
        }

        /*
         * Récupère le personnage dont le nom
         * correspond à celui du personnage passé en paramètre
         */
        public Personnage GetCompareTo(Personnage item)
        {
            using BddprojetContext context = new();
            return context.Personnages.Where(p => p.Nom == item.Nom).FirstOrDefault();
        }
    }
}
