using projet_dawan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieDLL_EF.Repository
{
    public class SaisonRepository
    {
        public static List<Saison> GetAll()
        {
            using(BddprojetContext context= new BddprojetContext())
            {
                return context.Saisons.ToList();
            }
        }

        public static List<Saison> GetSaisonsBySerie(int id)
        {
            using (BddprojetContext context = new BddprojetContext())
            {
                return context.Saisons.Where(sa=> sa.SerieId==id).ToList();
            }
        }
    }
}
