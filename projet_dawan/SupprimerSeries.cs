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
    public partial class SupprimerSeries : Form
    {
        public SupprimerSeries()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            // supprimer la serie selectionner. Ajouter messagebox pour demander une validation
            Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            var annuler = MessageBox.Show("Etes vous sur de vouloir annuler la suppression ?", "Annuler suppression ?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (annuler == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
