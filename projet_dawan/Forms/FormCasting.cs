using projet_dawan.Forms;
using projet_dawan.Models;
using SerieDLL_EF.Repository;
using SerieDLL_EF.Service;

namespace projet_dawan.Forms
{  
    public partial class FormCasting : Form
    {
        private List<Personnage> castList = new List<Personnage>();
        private Serie serie;
        public FormCasting(List<Personnage> list)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            SerieService serieService= new SerieService();
            castList = list;
            serie = serieService.GetById(castList[0].SerieId);
        }

        private void FormCasting_Load(object sender, EventArgs e)
        {
            labelCasting.Text = "Casting " + serie.Nom;
            ActeurService acteurService = new ();

            foreach (Personnage personnage in castList)
            {
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
                ActeurService acteurService = new();
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
