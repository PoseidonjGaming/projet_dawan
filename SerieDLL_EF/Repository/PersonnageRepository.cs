using projet_dawan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieDLL_EF.Repository
{
    public static class PersonnageRepository
    {
        public static List<Personnage> GetAll()
        {
            using(BddprojetContext context=new BddprojetContext())
            {
                return context.Personnages.ToList();
            }
        }

        public static Personnage GetById(int id)
        {
            using(BddprojetContext context= new BddprojetContext())
            {
                return context.Personnages.Where(p => p.Id == id).ToList()[0];
            }
        }

        public static List<Personnage> GetBySerie(int serie_id)
        {
            using (BddprojetContext context = new BddprojetContext())
            {
                return context.Personnages.Where(p=> p.SerieId==serie_id).ToList();
            }
        }

        public static List<Personnage> Export(int serie_id)
        {
            List<Personnage> list=new List<Personnage>();
            using (BddprojetContext context = new BddprojetContext())
            {
                list= context.Personnages.Where(p => p.SerieId == serie_id).ToList();
            }

            foreach(Personnage person in list)
            {
                person.Acteur = ActeurRepository.Export(person.ActeurId);
            }

            return list;
        }
    }
}
