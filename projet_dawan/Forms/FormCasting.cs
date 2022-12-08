using projet_dawan.Forms;
using projet_dawan.Models;
using SerieDLL_EF.Repository;

namespace projet_dawan.Forms
{  
    public partial class FormCasting : Form
    {
        private Serie Serie = new();
        private List<Personnage> castList = new List<Personnage>();

        public FormCasting(Serie serie)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Serie = serie;
            castList = PersonnageRepository.GetBySerie(Serie.Id);
        }

        private void FormCasting_Load(object sender, EventArgs e)
        {
            labelCasting.Text = "Casting " + Serie.Nom;

            foreach (Personnage personnage in PersonnageRepository.GetBySerie(Serie.Id))
            {
                castList.Add(personnage);
                listBoxCasting.Items.Add(personnage.Nom);
            }

            listBoxCasting.SelectedIndex = 0;
            Personnage perso = castList[listBoxCasting.SelectedIndex];
            Acteur acteur = ActeurRepository.GetById(perso.ActeurId);
            Populate(perso, acteur);

        }

        private void listBoxCasting_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCasting.SelectedIndex != -1)
            {
                Personnage perso = castList[listBoxCasting.SelectedIndex];
                Acteur acteur = ActeurRepository.GetById(perso.ActeurId);
                Populate(perso, acteur);
            }
        }

        private void Populate(Personnage perso, Acteur acteur)
        {
            labelNomPerso.Text = perso.Nom;
            labelActeur.Text = acteur.Nom + " " + acteur.Prenom;
        }

        // ajouter information sur le perso et une image

    }
}
