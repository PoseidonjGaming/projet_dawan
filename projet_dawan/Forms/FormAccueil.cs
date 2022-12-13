using projet_dawan.FormLogique;
using projet_dawan.Forms;
using projet_dawan.Models;
using projet_dawan_WinForm;
using SerieDLL_EF.Models;
using SerieDLL_EF.Repository;
using SerieDLL_EF.Service;

namespace projet_dawan
{
    public partial class FormAccueil : Form
    {
        Accueil Accueil;
        public FormAccueil()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Accueil = new(this);
        }

        private void toolStripAddSerie_Click(object sender, EventArgs e)
        {
            // affiche la page pour ajouter des séries à la base de données
            // ajouter If pour vérifier si le compte à les droits
            FormAjoutSerie add = new(new Serie());

            add.ShowDialog();
        }

        private void toolStripDeleteSerie_Click(object sender, EventArgs e)
        {
            // affiche la page pour supprimer des séries à la base de données
            // ajouter If pour vérifier si le compte à les droits
            FormSupprimerSeries supr = new();

            supr.ShowDialog();
        }

        private void toolStripBibli_Click(object sender, EventArgs e)
        {
            //affiche la page de la bibliothéque des séries de la base de données
            Accueil.Biblio_Click();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Accueil.Quitter_Click();
        }

        private void toolStripDeco_Click(object sender, EventArgs e)
        {
            Accueil.Deco_Click();

        }

        private void toolStripGerer_Click(object sender, EventArgs e)
        {
            Accueil.Gerer_Click();
        }

        private void watchlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // affiche la watchlist liée au compte actuel
            Accueil.WatchList_Click();
        }

       

        private void PageAcceuil_Load(object sender, EventArgs e)
        {
            Accueil.Load();   
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Accueil.Search_Clock();
        }

       

        

        private void gererLesActeursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Accueil.GererLesActeurs_Click();
        }
    }
}
