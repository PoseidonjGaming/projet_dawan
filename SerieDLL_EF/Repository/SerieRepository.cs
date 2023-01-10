using SerieDLL_EF.Interface;
using SerieDLL_EF.Models;

namespace SerieDLL_EF.Repository
{
    public class SerieRepository : BaseRepo ,IRepoCRUD<Serie>, IRepSpecials<Serie>
    {
        public SerieRepository(string cnx):base(cnx)
        {

        }
        //Cette classe implémente les interfaces IRepoCRUD et IRepSpecials pour gérer la table serie
        public List<Serie> GetAll()
        {
            using BddprojetContext context = new(Cnx);
            return context.Series.ToList();
        }

        public Serie GetById(int id)
        {
            using BddprojetContext context = new(Cnx);
            return context.Series.Where(s => s.Id == id).SingleOrDefault();
        }

        public List<Serie> GetByTxt(string txt)
        {
            using BddprojetContext context = new(Cnx);
            return context.Series.Where(s => s.Nom.Contains(txt)).ToList();
        }

        public List<Serie> ExportWatchList(List<int> ids)
        {
            List<Serie> list = new();
            using BddprojetContext context = new(Cnx);
            foreach (int id in ids)
            {
                list.Add(GetById(id));
            }
            return list;


        }

        public void Add(Serie item)
        {
            using BddprojetContext context = new(Cnx);
            context.Series.Add(item);
            context.SaveChanges();
        }

        public void Update(Serie item)
        {
            using BddprojetContext context = new(Cnx);
            context.Series.Update(item);
            context.SaveChanges();
        }

        public void Delete(Serie item)
        {
            using BddprojetContext context = new(Cnx);
            context.Series.Remove(item);
            context.SaveChanges();
        }

        public bool CompareTo(Serie item)
        {
            using BddprojetContext context = new(Cnx);
            Serie? serie = context.Series.Where(s => s.Nom == item.Nom &&
            s.Affiche == item.Affiche && s.DateDiff == item.DateDiff && s.Resume == item.Resume
            ).FirstOrDefault();

            return serie != null;
        }

        public Serie GetCompareTo(Serie item)
        {
            using BddprojetContext context = new(Cnx);
            return context.Series.Where(s => s.Nom == item.Nom && item.Affiche == item.Affiche
            && s.DateDiff == item.DateDiff && s.Resume == item.Resume).FirstOrDefault();
        }
    }
}
