using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieDLL_EF.Interface
{
    public interface IRepSpecials<T> where T:class
    {
        List<T> GetByTxt(string txt);
    }
}
