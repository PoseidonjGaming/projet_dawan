using SerieDLL_EF.Interface;
using SerieDLL_EF.Models;

namespace SerieDLL_EF.Repository
{
    /*
     * Les Répositories sont les classes qui gèrent la bdd.
     * Dans notre cas, elles implèment les interfaces du dossier Interface, pour plus de simplicité
     * Cette classe implémente les interfaces IRepoCRUD et IRepSpecials pour gérer la table acteur
     */
    public class ActeurRepository : IRepoCRUD<Acteur>, IRepSpecials<Acteur>
    {
        public List<Acteur> GetAll()
        {
            using BddprojetContext context = new BddprojetContext();
            return context.Acteurs.ToList();
        }

        public Acteur GetById(int id)
        {
            using BddprojetContext context = new BddprojetContext();
            return context.Acteurs.Where(p => p.Id == id).ToList()[0];
        }
        public List<Acteur> GetByTxt(string txt)
        {
            using BddprojetContext context = new BddprojetContext();
            return context.Acteurs.Where(a => a.Nom.Contains(txt) || a.Prenom.Contains(txt)).ToList();
        }

        public Acteur Export(int acteur_id)
        {
            using BddprojetContext context = new BddprojetContext();
            return context.Acteurs.Where(a => a.Id == acteur_id).ToList()[0];
        }

        public void Add(Acteur item)
        {
            using BddprojetContext context = new();
            context.Acteurs.Add(item);
            context.SaveChanges();
        }

        public void Update(Acteur item)
        {
            using BddprojetContext context = new();
            context.Acteurs.Update(item);
            context.SaveChanges();
        }

        public void Delete(Acteur item)
        {
            using BddprojetContext context = new();
            context.Acteurs.Remove(item);
            context.SaveChanges();
        }

        public bool CompareTo(Acteur item)
        {
            using BddprojetContext context = new();
            Acteur? acteur = context.Acteurs.Where(a => a.Nom == item.Nom && a.Prenom == item.Prenom).FirstOrDefault();
            return acteur != null;
        }

        public Acteur GetCompareTo(Acteur item)
        {
            using BddprojetContext context = new();
            return context.Acteurs.Where(a => a.Nom == item.Nom && a.Prenom == item.Prenom).FirstOrDefault();
        }

    }
}
