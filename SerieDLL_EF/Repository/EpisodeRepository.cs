using projet_dawan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieDLL_EF.Repository
{
    public class EpisodeRepository
    {
        public static List<Episode> GetAll()
        {
            using(BddprojetContext context= new BddprojetContext())
            {
                return context.Episodes.ToList();
            }
        }
        public static List<Episode> GetBySaison(int saison_id)
        {
            using (BddprojetContext context = new BddprojetContext())
            {
                return context.Episodes.Where(e=> e.SaisonId== saison_id).ToList();
            }
        }
    }
}
