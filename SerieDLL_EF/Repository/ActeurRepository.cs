using SerieDLL_EF.BDD;
using SerieDLL_EF.Interface;
using SerieDLL_EF.Models;

namespace SerieDLL_EF.Repository
{
    /*
     * Les Répositories sont les classes qui gèrent la bdd.
     * Dans notre cas, elles implèmentent les interfaces du dossier Interface, pour plus de simplicité
     * Cette classe implémente les interfaces IRepoCRUD et IRepSpecials pour gérer la table acteur
     */
    public class ActeurRepository : IRepoCRUD<Acteur>, IRepSpecials<Acteur>
    {
        /*
         *Récupère tous les acteurs depuis la base de donées
         */
        public List<Acteur> GetAll()
        {
            using BddprojetContext context = new();
            return context.Acteurs.ToList();
        }

        /*
         *Récupère l'acteur depuis la base de donées 
         *dont l'id correspond 
         *à l'id passé en paramètre 
         */

        public Acteur GetById(int id)
        {
            using BddprojetContext context = new();
            return context.Acteurs.Where(p => p.Id == id).ToList()[0];
        }

        /*
         *Récupère les acteurs depuis la base de donées 
         *dont le nom ou le prénom contiennent 
         *le texte passé en paramètre 
         */

        public List<Acteur> GetByTxt(string txt)
        {
            using BddprojetContext context = new();
            return context.Acteurs.Where(a => a.Nom.Contains(txt) || a.Prenom.Contains(txt)).ToList();
        }

        public Acteur Export(int acteur_id)
        {
            using BddprojetContext context = new();
            return context.Acteurs.Where(a => a.Id == acteur_id).ToList()[0];
        }

        /*
         * Ajoute l'acteur passé en paramètre dans la base de donnée
         */
        public void Add(Acteur item)
        {
            using BddprojetContext context = new();
            context.Acteurs.Add(item);
            context.SaveChanges();
        }

        /*
        * Modifie l'acteur passé en paramètre dans la base de donnée
        */
        public void Update(Acteur item)
        {
            using BddprojetContext context = new();
            context.Acteurs.Update(item);
            context.SaveChanges();
        }

        /*
        * Supprime l'acteur passé en paramètre de la base de donnée
        */
        public void Delete(Acteur item)
        {
            using BddprojetContext context = new();
            context.Acteurs.Remove(item);
            context.SaveChanges();
        }

        /*
         *Vérifie si l'acteur existe dans la base do données
         */
        public bool CompareTo(Acteur item)
        {
            using BddprojetContext context = new();
            Acteur? acteur = context.Acteurs.Where(a => a.Nom == item.Nom && a.Prenom == item.Prenom).FirstOrDefault();
            return acteur != null;
        }

        /*
        *Récupère l'acteur dans la base do données
        *dont les nom et prénom correspondent 
        *à ceux de l'acteur passé en paramètre
        */
        public Acteur GetCompareTo(Acteur item)
        {
            using BddprojetContext context = new();
            return context.Acteurs.Where(a => a.Nom == item.Nom && a.Prenom == item.Prenom).FirstOrDefault();
        }
    }
}
