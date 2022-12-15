using SerieDLL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieDLL.Interface
{
    public interface IEpisodeDAO
    {
        List<Episode> GetEpisodes(int id);
    }
}
