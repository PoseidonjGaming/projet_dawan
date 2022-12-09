using projet_dawan.Models;
using SerieDLL_EF.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieDLL_EF.Service
{
    public class SaisonService: Service<Saison, SaisonRepository>
    {
        public SaisonService(SaisonRepository repo):base(repo)
        {

        }

        public List<Saison> GetSaisonsBySerie(int id)
        {
            return repo.GetSaisonsBySerie(id);
        }
    }
}
