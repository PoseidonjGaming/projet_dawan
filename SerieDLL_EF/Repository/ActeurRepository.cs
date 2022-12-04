using projet_dawan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SerieDLL_EF.Repository
{
    public static class ActeurRepository
    {
        public static List<Acteur> GetAll()
        {
            using (BddprojetContext context = new BddprojetContext())
            {
                return context.Acteurs.ToList();
            }
        }

        public static Acteur GetById(int id)
        {
            using (BddprojetContext context = new BddprojetContext())
            {
                return context.Acteurs.Where(p => p.Id == id).ToList()[0];
            }
        }

        public static Acteur Export(int acteur_id)
        {
            using (BddprojetContext context = new BddprojetContext())
            {
                return context.Acteurs.Where(a => a.Id == acteur_id).ToList()[0];
            }
        }
    }
}
