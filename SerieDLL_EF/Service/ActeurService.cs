using projet_dawan.Models;
using SerieDLL_EF.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieDLL_EF.Service
{
    public class ActeurService
    {
        private ActeurRepository repo;
        public ActeurService()
        {
            repo = new ActeurRepository();
        }

        public List<Acteur> GetAll()
        {
            return repo.GetAll();
        }

        public Acteur GetById(int id)
        {
            return repo.GetById(id);
        }

        public Acteur Export(int id)
        {
            return repo.Export(id);
        }

        public void Add(Acteur acteur)
        {
            repo.Add(acteur);
        }

        public void Update(Acteur acteur)
        {
            repo.Update(acteur);
        }

        public void Delete(Acteur acteur)
        {
            repo.Delete(acteur);
        }
    }
}
