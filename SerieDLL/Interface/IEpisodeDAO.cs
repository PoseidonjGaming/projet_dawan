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
        List<Episode> GetEpisodes(int id);
    }
}
