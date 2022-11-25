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
    public partial class AjouterSeries : Form
    {
        public AjouterSeries()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // vérifier si les champs sont valides puis ajouter la serie à la base de données
            Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            var annuler = MessageBox.Show("Etes vous sur de vouloir annuler l'ajout ?", "Annuler ajout ?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (annuler == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
