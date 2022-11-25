using projet_dawan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_dawan.Interface
{
    public interface IEpisodeDAO
    {
        void Add(Episode episode);
        void Update(Episode episode);
        void Delete(int id);
        List<Episode> GetAll();
        Episode GetById(int id);
    }
}
