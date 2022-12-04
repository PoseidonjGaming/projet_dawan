using projet_dawan.Models;
using SerieDLL_EF.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieDLL_EF.Repository
{
    public class SerieRepository
    {
        public static List<Serie> GetAll()
        {
            using(BddprojetContext context= new())
            {
                return context.Series.ToList();
            }
        }
    }
}
