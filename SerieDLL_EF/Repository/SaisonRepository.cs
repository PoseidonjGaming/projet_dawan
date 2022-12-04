using projet_dawan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieDLL_EF.Repository
{
    public static class SaisonRepository
    {
        public static List<Saison> GetAll()
        {
            using (BddprojetContext context = new BddprojetContext())
            {
                return context.Saisons.ToList();
            }
        }


        public static List<Saison> GetSaisonsBySerie(int id)
        {
            using (BddprojetContext context = new BddprojetContext())
            {
                return context.Saisons.Where(sa => sa.SerieId == id).ToList();
            }
        }

        public static List<Saison> Export(int serie_id)
        {
            List<Saison> list = new();
            using (BddprojetContext context = new BddprojetContext())
            {
                list = context.Saisons.Where(sa=> sa.SerieId==serie_id).ToList();
            }

            foreach (Saison saison in list)
            {
                saison.Episodes=EpisodeRepository.GetBySaison(saison.Id);
            }

            return list;
        }
    }
}
