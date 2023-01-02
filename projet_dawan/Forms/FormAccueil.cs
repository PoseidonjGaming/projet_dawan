using projet_dawan.FormLogic;

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
            logicAccueil.ToolStripAddSerie_Click();

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
            logicAccueil.Search_Click();
        }

        private void gererLesActeursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logicAccueil.GererLesActeurs_Click();
        }



        private void seConnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logicAccueil.SeConnecterToolStripMenuItem_Click();
        }



        private void ajouterEpisodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logicAccueil.ManageEpisodeToolStripMenuItem_Click();
        }



        private void gererPersonnagesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            logicAccueil.gererPersonnagesToolStripMenuItem_Click();
        }


        public ToolStripMenuItem getSeConnecter()
        {
            return seConnecterToolStripMenuItem;
        }

        public GroupBox GetGroupBox()
        {
            return groupBox1;
        }

        public TextBox GetTextBoxRechercher()
        {
            return txtRechercher;
        }

    }
}
