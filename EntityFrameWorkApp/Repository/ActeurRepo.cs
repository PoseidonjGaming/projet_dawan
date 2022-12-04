using EntityFrameWorkApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkApp.Repository
{
    internal class ActeurRepo
    {
        public ActeurRepo() { }

        public List<Acteur> GetActeur()
        {
            using (BddprojetContext context = new BddprojetContext())
            {
                return context.Acteurs.ToList();
            }
        }

        public List<Acteur> GetActeurPerso()
        {
            List<Acteur> list = GetActeur();
            using (BddprojetContext context = new())
            {
                foreach (Acteur acteur in list)
                {
                    acteur.Personnages = context.Personnages.Where(p => p.ActeurId == acteur.Id).ToList();
                }
                return list;
            }
        }
    }
}
