using projet_dawan_WPF.Windows;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_dawan_WPF.Logic
{
    internal class LogicCasting
    {
        public WindowCasting Window { get; set; }
        private List<Personnage> castList = new List<Personnage>();
        private Serie serie;

        public LogicCasting(WindowCasting window)
        {
            Window = window;
        }

        public void Load(List<Personnage> list)
        {
            SerieService serieService = new SerieService();
            castList = list;
            serie = serieService.GetById(castList[0].SerieId);
            Window.lblCasting.Content = "Casting " + serie.Nom;
            ActeurService acteurService = new();

            foreach (Personnage personnage in castList)
            {
                Window.lstBoxCasting.Items.Add(personnage.Nom);
            }

            Window.lstBoxCasting.SelectedIndex = 0;
            Personnage perso = castList[Window.lstBoxCasting.SelectedIndex];
            Acteur acteur = acteurService.GetById(perso.ActeurId);
            Populate(perso, acteur);
        }

        public void ListBoxCasting_SelectedIndexChanged()
        {
            if (Window.lstBoxCasting.SelectedIndex != -1)
            {
                ActeurService acteurService = new();
                Personnage perso = castList[Window.lstBoxCasting.SelectedIndex];
                Acteur acteur = acteurService.GetById(perso.ActeurId);
                Populate(perso, acteur);
            }
        }

        private void Populate(Personnage perso, Acteur acteur)
        {
            Window.lblNomPerso.Content = perso.Nom;
            Window.lblActeur.Content= acteur.Nom + " " + acteur.Prenom;
        }
    }
}
