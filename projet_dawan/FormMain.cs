using System.Configuration;
using projet_dawan.Repository;

namespace projet_dawan
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Orm orm = new SerieRepository();
            string query = orm.Select("*").From()
                .Join("serie","id","personnage","id").OrderBy("id", "desc").Build() ;
            MessageBox.Show(query);
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            // Ouvre la session et affiche la page d'acceuil si les logins sont correctes. Si ils sont mauvais retourne une exception "codes incorrectes".
            PageAcceuil acceuil = new();

            acceuil.ShowDialog();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Affiche la page création de compte.
            CreerCompte newCompte = new();

            newCompte.ShowDialog();
        }
    }
}