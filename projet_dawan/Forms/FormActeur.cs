using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_dawan.Forms
{
    public partial class FormActeur : Form
    {
        public FormActeur()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        // actualiser la list box avec les series ou l'acteur apparait + OnClick une des series de la liste affiche form serie
    }
}
