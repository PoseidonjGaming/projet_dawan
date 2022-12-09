﻿using projet_dawan.Models;
using SerieDLL_EF.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieDLL_EF.Repository
{
    public class EpisodeRepository : IRepoCRUD<Episode>, IRepSpecials<Episode>
    {
        public List<Episode> GetAll()
        {
            using (BddprojetContext context = new BddprojetContext())
            {
                return context.Episodes.ToList();
            }
        }

        public Episode GetById(int id)
        {
            using (BddprojetContext context = new BddprojetContext())
            {
                return context.Episodes.Where(p => p.Id == id).SingleOrDefault();
            }
        }
        public List<Episode> GetBySaison(int saison_id)
        {
            using (BddprojetContext context = new BddprojetContext())
            {
                return context.Episodes.Where(e => e.SaisonId == saison_id).ToList();
            }
        }

        public List<Episode> GetByTxt(string txt)
        {
            using (BddprojetContext context = new())
            {
                return context.Episodes.Where(e=> e.Nom.Contains(txt)).ToList();
            }
        }

        public void Add(Episode item)
        {
            using (BddprojetContext context = new())
            {
                context.Episodes.Add(item);
                context.SaveChanges();
            }
        }

        public void Update(Episode item)
        {
            using (BddprojetContext context = new())
            {
                context.Episodes.Update(item);
                context.SaveChanges();
            }
        }

        public void Delete(Episode item)
        {
            using (BddprojetContext context = new())
            {
                context.Episodes.Remove(item);
                context.SaveChanges();
            }
        }




    }
}
