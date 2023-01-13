using Microsoft.EntityFrameworkCore;
using SerieDLL_EF.Interface;
using SerieDLL_EF.Models;
using System.Formats.Asn1;
using System.Linq.Expressions;
using static System.Net.Mime.MediaTypeNames;

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
            using (BddprojetContext context = new())
            {
                return context.Acteurs.ToList();
            };

        }

        public Acteur GetById(int id)
        {
            using (BddprojetContext context = new())
            {
                return context.Acteurs.Where(a => a.Id == id).FirstOrDefault();
            };
        }

        public List<Acteur> GetByTxt(string txt)
        {
            using (BddprojetContext context = new())
            {
                return context.Acteurs.Where(a => a.Nom.Contains(txt) || a.Prenom.Contains(txt)).ToList();
            };
        }

        public bool CompareTo(Acteur item)
        {
            using (BddprojetContext context = new())
            {
                return context.Acteurs.Where(a => a.Nom == item.Nom && a.Prenom == item.Prenom).FirstOrDefault() != null;
            };
        }

        public Acteur? GetCompareTo(Acteur item)
        {
            using (BddprojetContext context = new())
            {
                return context.Acteurs.Where(a => a.Nom == item.Nom && a.Prenom == item.Prenom).FirstOrDefault();
            };
        }

        public void Add(Acteur item)
        {
            using (BddprojetContext context = new())
            {
                context.Acteurs.Add(item);
                context.SaveChanges();
            };
            
        }

        public void Update(Acteur item)
        {
            using (BddprojetContext context = new())
            {
                context.Acteurs.Update(item);
                context.SaveChanges();
            };
        }

        public void Delete(Acteur item)
        {
            using (BddprojetContext context = new())
            {
                context.Acteurs.Remove(item);
                context.SaveChanges();
            };
        }


    }
}
