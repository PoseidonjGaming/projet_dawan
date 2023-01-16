using projet_dawan_WPF.Windows.Autre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_dawan_WPF.Logic.Autre
{
    public class LogicNote
    {
        public WindowNote Window { get; set; }

        public LogicNote(WindowNote window)
        {
            Window = window;
        }
    }
}
