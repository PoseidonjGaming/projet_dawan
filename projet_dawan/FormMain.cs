using projet_dawan.DAO;
using projet_dawan.Model;
using projet_dawan.Repository;

namespace projet_dawan
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Orm orm = new SaisonRepository();
            
            PersonnageDAO dao = new(Properties.Settings.Default.Connection);
            ActeurDAO daoActeur = new(Properties.Settings.Default.Connection);
            SerieDAO daoSerie = new(Properties.Settings.Default.Connection);
            Personnage perso=new("Baron Zemo",daoActeur.GetById(18),daoSerie.GetById(3));
            
            dao.Add(perso);

        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            PageAcceuil acceuil = new();

            acceuil.ShowDialog();
        }
    }
}