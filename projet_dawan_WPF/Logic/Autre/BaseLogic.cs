using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_dawan_WPF.Logic.Autre
{
    public class BaseLogic
    {
        public string Cnx { get; set; }

        public BaseLogic()
        {
            Cnx=Properties.Settings.Default.Cnx;
        }
    }
}
