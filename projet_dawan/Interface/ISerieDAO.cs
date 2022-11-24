using projet_dawan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_dawan.Interface
{
    public interface ISerieDAO
    {
        void Add(Serie serie);
        void Update(Serie serie);
        void Delete(int id);
        List<Serie> GetAll();
        Serie GetById(int id);
    }
}
