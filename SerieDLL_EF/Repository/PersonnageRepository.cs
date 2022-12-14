using SerieDLL_EF.Interface;
using SerieDLL_EF.Models;

namespace SerieDLL_EF.Repository
{
    //Cette classe implémente les interfaces IRepoCRUD et IRepSpecials pour gérer la table personnage
    public class PersonnageRepository : IRepoCRUD<Personnage>, IRepSpecials<Personnage>
    {
        public List<Personnage> GetAll()
        {
            using BddprojetContext context = new BddprojetContext();
            return context.Personnages.ToList();
        }

        public Personnage GetById(int id)
        {
            using BddprojetContext context = new BddprojetContext();
            return context.Personnages.Where(p => p.Id == id).ToList()[0];
        }

        public List<Personnage> GetBySerie(int serie_id)
        {
            using BddprojetContext context = new BddprojetContext();
            return context.Personnages.Where(p => p.SerieId == serie_id).ToList();
        }

        public List<Personnage> GetByTxt(string txt)
        {
            using BddprojetContext context = new BddprojetContext();
            return context.Personnages.Where(p => p.Nom.Contains(txt)).ToList();
        }

        public List<Personnage> GetByActeur(int acteur_id)
        {
            using BddprojetContext context = new BddprojetContext();
            return context.Personnages.Where(p => p.ActeurId == acteur_id).ToList();
        }

        public static List<Personnage> Export(int serie_id)
        {
            List<Personnage> list = new List<Personnage>();
            using (BddprojetContext context = new BddprojetContext())
            {
                list = context.Personnages.Where(p => p.SerieId == serie_id).ToList();
            }

            foreach (Personnage person in list)
            {
                ActeurRepository repo = new ActeurRepository();
                person.Acteur = repo.Export(person.ActeurId);
            }

            return list;
        }

        public void Add(Personnage item)
        {
            using BddprojetContext context = new BddprojetContext();
            context.Personnages.Add(item);
            context.SaveChanges();
        }

        public void Update(Personnage item)
        {
            using BddprojetContext context = new BddprojetContext();
            context.Personnages.Update(item);
            context.SaveChanges();
        }

        public void Delete(Personnage item)
        {
            using BddprojetContext context = new BddprojetContext();
            context.Personnages.Remove(item);
            context.SaveChanges();
        }
    }
}
