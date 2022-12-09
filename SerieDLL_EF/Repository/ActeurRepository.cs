﻿using projet_dawan.Models;
using SerieDLL_EF.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SerieDLL_EF.Repository
{
    public class ActeurRepository : IRepoCRUD<Acteur>, IRepSpecials<Acteur>
    {
        public List<Acteur> GetAll()
        {
            using (BddprojetContext context = new BddprojetContext())
            {
                return context.Acteurs.ToList();
            }
        }

        public Acteur GetById(int id)
        {
            using (BddprojetContext context = new BddprojetContext())
            {
                return context.Acteurs.Where(p => p.Id == id).ToList()[0];
            }
        }
        public List<Acteur> GetByTxt(string txt)
        {
            using (BddprojetContext context = new BddprojetContext())
            {
                return context.Acteurs.Where(a => a.Nom.Contains(txt) || a.Prenom.Contains(txt)).ToList();
            }
        }

        public Acteur Export(int acteur_id)
        {
            using (BddprojetContext context = new BddprojetContext())
            {
                return context.Acteurs.Where(a => a.Id == acteur_id).ToList()[0];
            }
        }

        public void Add(Acteur item)
        {
            using (BddprojetContext context = new())
            {
                context.Acteurs.Add(item);
                context.SaveChanges();
            }
        }

        public void Update(Acteur item)
        {
            using (BddprojetContext context = new())
            {
                context.Acteurs.Update(item);
                context.SaveChanges();
            }
        }

        public void Delete(Acteur item)
        {
            using (BddprojetContext context = new())
            {
                context.Acteurs.Remove(item);
                context.SaveChanges();
            }
        }

    }
}
