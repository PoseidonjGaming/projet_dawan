using projet_dawan.Models;
using SerieDLL_EF.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieDLL_EF.Repository
{
    public static class SerieRepository
    {
        public static List<Serie> GetAll()
        {
            using (BddprojetContext context = new BddprojetContext())
            {
                return context.Series.ToList();
            }
        }

        public static Serie GetById(int id)
        {
            using (BddprojetContext context = new BddprojetContext())
            {
                return context.Series.Where(s => s.Id == id).ToList()[0];
            }
        }

        public static List<Serie> GetByTxt(string txt)
        {
            using(BddprojetContext context=new BddprojetContext())
            {
                return context.Series.Where(s => s.Nom.Contains(txt)).ToList();
            }
        }

        public static List<Serie> Export(List<int> ids)
        {
            List<Serie> list = new List<Serie>();
            using(BddprojetContext context = new())
            {
                foreach (int id in ids)
                {
                    list.Add(GetById(id));
                }
            }
            foreach (Serie serie in list)
            {
                serie.Saisons = SaisonRepository.Export(serie.Id);
                serie.Personnages=PersonnageRepository.Export(serie.Id);
            }
            return list;
        }
    }
}
