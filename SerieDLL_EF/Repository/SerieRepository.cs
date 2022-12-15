using projet_dawan.Models;
using SerieDLL_EF.Interface;
using SerieDLL_EF.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieDLL_EF.Repository
{
    public class SerieRepository : IRepoCRUD<Serie>, IRepSpecials<Serie>
    {
        //Cette classe implémente les interfaces IRepoCRUD et IRepSpecials pour gérer la table serie
        public List<Serie> GetAll()
        {
            using BddprojetContext context = new BddprojetContext();
            return context.Series.ToList();
        }

        public Serie GetById(int id)
        {
            using BddprojetContext context = new BddprojetContext();
            return context.Series.Where(s => s.Id == id).SingleOrDefault();
        }

        public List<Serie> GetByTxt(string txt)
        {
            using BddprojetContext context = new BddprojetContext();
            return context.Series.Where(s => s.Nom.Contains(txt)).ToList();
        }

        public List<Serie> Export(List<int> ids)
        {
            List<Serie> list = new List<Serie>();
            using (BddprojetContext context = new())
            {
                list = context.Series.ToList();
            }
            foreach (Serie serie in list)
            {
                //serie.Saisons = SaisonRepository.Export(serie.Id);
                serie.Personnages = PersonnageRepository.Export(serie.Id);
            }
            return list;
        }

        public void Add(Serie item)
        {
            using BddprojetContext context = new BddprojetContext();
            context.Series.Add(item);
            context.SaveChanges();
        }

        public void Update(Serie item)
        {
            using BddprojetContext context = new BddprojetContext();
            context.Series.Update(item);
            context.SaveChanges();
        }

        public void Delete(Serie item)
        {
            using BddprojetContext context = new();
            context.Series.Remove(item);
            context.SaveChanges();
        }
    }
}
