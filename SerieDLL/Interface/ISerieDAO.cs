using SerieDLL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieDLL.Interface
{
    internal interface ISerieDAO
    {
        List<Serie> GetByTxt(string txt);
    }
}
