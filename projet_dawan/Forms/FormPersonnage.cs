using projet_dawan.Models;
using projet_dawan_WinForm;
using SerieDLL_EF.Repository;

namespace projet_dawan.Forms
{
    public partial class FormPersonnage : Form
    {

        public FormPersonnage()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void labelNomPerso_Click(object sender, EventArgs e)
        {
            // retour form serie correspondant au personnage
            FormSerie serie = new(SerieRepository.GetById(1));

            serie.ShowDialog();
        }

        private void labelActeur_Click(object sender, EventArgs e)
        {
            // afficher form acteur correspondant à l'acteur du personnage
            FormActeur acteur = new();

            acteur.ShowDialog();
        }
    }
}
