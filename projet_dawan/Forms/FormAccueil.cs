using projet_dawan.FormLogic;
using projet_dawan.Forms;
using projet_dawan_WinForm;
using SerieDLL_EF.Models;
using SerieDLL_EF.Repository;
using SerieDLL_EF.Service;

namespace projet_dawan
{
    public partial class FormAccueil : Form
    {
        private LogicAccueil logicAccueil;
        public FormAccueil()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            logicAccueil = new(this);
        }

        private void toolStripAddSerie_Click(object sender, EventArgs e)
        {
        }

        private void toolStripDeleteSerie_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripBibli_Click(object sender, EventArgs e)
        {
            //affiche la page de la bibliothéque des séries de la base de données
            logicAccueil.Biblio_Click();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logicAccueil.Quitter_Click();
        }

        private void toolStripDeco_Click(object sender, EventArgs e)
        {
            logicAccueil.Deco_Click();

        }

        private void toolStripGerer_Click(object sender, EventArgs e)
        {
            logicAccueil.Gerer_Click();
            
        }

        private void watchlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
           logicAccueil.WatchList_Click();
        }

       

        private void PageAcceuil_Load(object sender, EventArgs e)
        {
            logicAccueil.Load();
        }

      

     

       

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
        }

       

      

        private void gererLesActeursToolStripMenuItem_Click(object sender, EventArgs e)
        {
                
        }

        private void ajouterEpisodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
