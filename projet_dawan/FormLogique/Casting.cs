using projet_dawan.Forms;
using projet_dawan.Models;
using SerieDLL_EF.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_dawan.FormLogique
{
    internal class Casting
    {
        public FormCasting Form{ get; set; }
        private List<Personnage> castList = new List<Personnage>();
        private Serie serie;
        public Casting(FormCasting form)
        {
            Form = form;
        }

        public void Load(List<Personnage> list)
        {
            SerieService serieService = new SerieService();
            castList = list;
            serie = serieService.GetById(castList[0].SerieId);
            Form.labelCasting.Text = "Casting " + serie.Nom;
            ActeurService acteurService = new();

            foreach (Personnage personnage in castList)
            {
                Form.listBoxCasting.Items.Add(personnage.Nom);
            }

            Form.listBoxCasting.SelectedIndex = 0;
            Personnage perso = castList[Form.listBoxCasting.SelectedIndex];
            Acteur acteur = acteurService.GetById(perso.ActeurId);
            Populate(perso, acteur);
        }

        public void ListBoxCasting_SelectedIndexChanged()
        {
            if (Form.listBoxCasting.SelectedIndex != -1)
            {
                ActeurService acteurService = new();
                Personnage perso = castList[Form.listBoxCasting.SelectedIndex];
                Acteur acteur = acteurService.GetById(perso.ActeurId);
                Populate(perso, acteur);
            }
        }

        private void Populate(Personnage perso, Acteur acteur)
        {
            Form.labelNomPerso.Text = perso.Nom;
            Form.labelActeur.Text = acteur.Nom + " " + acteur.Prenom;
        }
    }
}
