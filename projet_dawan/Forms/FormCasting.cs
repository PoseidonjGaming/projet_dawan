using projet_dawan.Forms;
using projet_dawan.Models;
using SerieDLL_EF.Repository;
using SerieDLL_EF.Service;

namespace projet_dawan.Forms
{  
    public partial class FormCasting : Form
    {
        private Serie Serie = new();
        private List<Personnage> castList = new List<Personnage>();
        private PersonnageService servicePerso = new(new PersonnageRepository());
        public FormCasting(Serie serie)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Serie = serie;
            castList = servicePerso.GetBySerie(Serie.Id);
        }

        private void FormCasting_Load(object sender, EventArgs e)
        {
            labelCasting.Text = "Casting " + Serie.Nom;
            Service<Acteur, ActeurRepository> acteurService = new Service<Acteur, ActeurRepository>(new ActeurRepository());

            foreach (Personnage personnage in servicePerso.GetBySerie(Serie.Id))
            {
                castList.Add(personnage);
                listBoxCasting.Items.Add(personnage.Nom);
            }

            listBoxCasting.SelectedIndex = 0;
            Personnage perso = castList[listBoxCasting.SelectedIndex];
            Acteur acteur = acteurService.GetById(perso.ActeurId);
            Populate(perso, acteur);

        }

        private void listBoxCasting_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCasting.SelectedIndex != -1)
            {
                Service<Acteur, ActeurRepository> acteurService = new Service<Acteur, ActeurRepository>(new ActeurRepository());
                Personnage perso = castList[listBoxCasting.SelectedIndex];
                Acteur acteur = acteurService.GetById(perso.ActeurId);
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
