using SerieDLL_EF.Interface;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieDLL_EF.Repository
{
    //Cette classe implémente les interfaces IRepoCRUD et IRepSpecials pour gérer la table saison
    public class SaisonRepository : IRepoCRUD<Saison>
    {
        public List<Saison> GetAll()
        {
            using BddprojetContext context = new BddprojetContext();
            return context.Saisons.ToList();
        }

        public Saison GetById(int id)
        {
            using BddprojetContext context = new BddprojetContext();
            return context.Saisons.Where(sa => sa.Id == id).SingleOrDefault();
        }


        public List<Saison> GetSaisonsBySerie(int id)
        {
            using BddprojetContext context = new BddprojetContext();
            return context.Saisons.Where(sa => sa.SerieId == id).ToList();
        }

        public  List<Saison> Export(int serie_id)
        {
            List<Saison> list = new();
            EpisodeService service = new EpisodeService(); ;
            using (BddprojetContext context = new BddprojetContext())
            {
                list = context.Saisons.Where(sa => sa.SerieId == serie_id).ToList();
            }

            foreach (Saison saison in list)
            {
                saison.Episodes = service.GetBySaison(saison.Id);
            }

            return list;
        }


        public void Add(Saison item)
        {
            using BddprojetContext context = new BddprojetContext();
            context.Saisons.Add(item);
            context.SaveChanges();
        }

        public void Update(Saison item)
        {
            using BddprojetContext context = new BddprojetContext();
            context.Saisons.Update(item);
            context.SaveChanges();
        }

        public void Delete(Saison item)
        {
            using BddprojetContext context = new BddprojetContext();
            context.Saisons.Remove(item);
            context.SaveChanges();
        }
    }
}
