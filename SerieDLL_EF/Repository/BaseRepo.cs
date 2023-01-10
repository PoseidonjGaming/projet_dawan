using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieDLL_EF.Repository
{
    public abstract class BaseRepo
    {
        public string Cnx { get; set; }

        public BaseRepo(string cnx)
        {
            Cnx = cnx;
        }
    }
}
