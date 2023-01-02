using projet_dawan.Forms;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;

namespace projet_dawan.FormLogic
{
    internal class LogicCasting
    {
        public FormCasting Form { get; set; }
        private List<Personnage> castList = new List<Personnage>();
        private Serie serie;
        public LogicCasting(FormCasting form)
        {
            Form = form;
        }

        public void Load(List<Personnage> list)
        {
            SerieService serieService = new SerieService();
            castList = list;
            serie = serieService.GetById(castList[0].SerieId);
            Form.GetLabelCasting().Text = "Casting " + serie.Nom;
            ActeurService acteurService = new();

            foreach (Personnage personnage in castList)
            {
                Form.GetListBoxCasting().Items.Add(personnage.Nom);
            }

            Form.GetListBoxCasting().SelectedIndex = 0;
            Personnage perso = castList[Form.GetListBoxCasting().SelectedIndex];
            Acteur acteur = acteurService.GetById(perso.ActeurId);
            Populate(perso, acteur);
        }

        public void ListBoxCasting_SelectedIndexChanged()
        {
            if (Form.GetListBoxCasting().SelectedIndex != -1)
            {
                ActeurService acteurService = new();
                Personnage perso = castList[Form.GetListBoxCasting().SelectedIndex];
                Acteur acteur = acteurService.GetById(perso.ActeurId);
                Populate(perso, acteur);
            }
        }

        private void Populate(Personnage perso, Acteur acteur)
        {
            Form.GetLabelNomPerso().Text = perso.Nom;
            Form.GetLabelActeur().Text = acteur.Nom + " " + acteur.Prenom;
        }
    }
}
