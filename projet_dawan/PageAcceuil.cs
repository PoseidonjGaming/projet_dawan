using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_dawan
{
    public partial class PageAcceuil : Form
    {
        public PageAcceuil()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void toolStripAddSerie_Click(object sender, EventArgs e)
        {
            // ajouter If pour vérifier si le compte à les droits
            AjouterSeries add = new();

            add.ShowDialog();
        }

        private void toolStripDeleteSerie_Click(object sender, EventArgs e)
        {
            // ajouter If pour vérifier si le compte à les droits
            SupprimerSeries supr = new();

            supr.ShowDialog();
        }
    }
}
