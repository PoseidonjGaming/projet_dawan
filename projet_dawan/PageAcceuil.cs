using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projet_dawan.DAO;

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
            // affiche la page pour ajouter des séries à la base de données
            // ajouter If pour vérifier si le compte à les droits
            AjouterSeries add = new();

            add.ShowDialog();
        }

        private void toolStripDeleteSerie_Click(object sender, EventArgs e)
        {
            // affiche la page pour supprimer des séries à la base de données
            // ajouter If pour vérifier si le compte à les droits
            SupprimerSeries supr = new();

            supr.ShowDialog();
        }

        private void toolStripBibli_Click(object sender, EventArgs e)
        {
            // affiche la page de la bibliothéque des séries de la base de données
            PageBibliotheque bibli = new();

            bibli.ShowDialog();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var quitter = MessageBox.Show("Etes vous sur de vouloir quitter l'application ?", "Quitter ?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (quitter == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void toolStripDeco_Click(object sender, EventArgs e)
        {
            var deconnecter = MessageBox.Show("Etes vous sur de vouloir vous déconnecter de ce compte ?", "Se déconnecter ?", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (deconnecter == DialogResult.Yes)
            {
                Close();
            }
            
        }

        private void toolStripGerer_Click(object sender, EventArgs e)
        {
            // affiche la page de gestion du compte
            GererCompte compte = new();

            compte.ShowDialog();
        }

        private void watchlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // affiche la watchlist liée au compte actuel
            Watchlist watchlist = new();

            watchlist.ShowDialog();
        }

        private void btnNew1_Click(object sender, EventArgs e)
        {
            // affiche la dernière serie dans la base de données
            PageTestSerie pageSerie = new();

            pageSerie.ShowDialog();
        }
    }
}
