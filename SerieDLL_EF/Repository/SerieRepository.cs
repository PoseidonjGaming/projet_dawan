using SerieDLL_EF.BDD;
using SerieDLL_EF.Interface;
using SerieDLL_EF.Models;

namespace SerieDLL_EF.Repository
{
    public class SerieRepository : IRepoCRUD<Serie>, IRepSpecials<Serie>
    {
       
        //Cette classe implémente les interfaces IRepoCRUD et IRepSpecials pour gérer la table serie
        public List<Serie> GetAll()
        {
            using BddprojetContext context = new();
            return context.Series.ToList();
        }

        public Serie GetById(int id)
        {
            using BddprojetContext context = new();
            return context.Series.Where(s => s.Id == id).SingleOrDefault();
        }

        public List<Serie> GetByTxt(string txt)
        {
            using BddprojetContext context = new();
            return context.Series.Where(s => s.Nom.Contains(txt)).ToList();
        }

        public List<Serie> ExportWatchList(List<int> ids)
        {
            List<Serie> list = new();
            using BddprojetContext context = new();
            foreach (int id in ids)
            {
                list.Add(GetById(id));
            }
            return list;


        }

        public void Add(Serie item)
        {
            using BddprojetContext context = new();
            context.Series.Add(item);
            context.SaveChanges();
        }

        public void Update(Serie item)
        {
            using BddprojetContext context = new();
            context.Series.Update(item);
            context.SaveChanges();
        }

        public void Delete(Serie item)
        {
            using BddprojetContext context = new();
            context.Series.Remove(item);
            context.SaveChanges();
        }

        public bool CompareTo(Serie item)
        {
            using BddprojetContext context = new();
            Serie? serie = context.Series.Where(s => s.Nom == item.Nom &&
            s.Affiche == item.Affiche && s.DateDiff == item.DateDiff && s.Resume == item.Resume
            ).FirstOrDefault();

            return serie != null;
        }

        public Serie GetCompareTo(Serie item)
        {
            using BddprojetContext context = new();
            return context.Series.Where(s => s.Nom == item.Nom && item.Affiche == item.Affiche
            && s.DateDiff == item.DateDiff && s.Resume == item.Resume).FirstOrDefault();
        }

        public List<Serie> LastAdd()
        {
            using BddprojetContext context = new();
            var list = context.Series;
            if (list.Count()>4)
            {
                return list.OrderByDescending(s => s.Id).Take(4).ToList();
            }
            else
            {
                return list.OrderByDescending(s => s.Id).ToList();
            }
            
        }
    }
}
