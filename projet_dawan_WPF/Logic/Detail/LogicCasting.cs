using projet_dawan_WPF.Logic.Autre;
using projet_dawan_WPF.Windows.Detail;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System.Collections.Generic;

namespace projet_dawan_WPF.Logic.Detail
{
    internal class LogicCasting
    {
        public WindowCasting Window { get; set; }
        private List<Personnage> castList;
        private Serie serie;

        public LogicCasting(WindowCasting window)
        {
            Window = window;
            castList = new();
            serie = new();
        }

        public void Load(List<Personnage> list)
        {
            SerieService serieService = new();
            castList = list;
            serie = serieService.GetById(castList[0].SerieId);
            Window.Title = "Casting de " + serie.Nom;
            Window.lblCasting.Content = "Casting " + serie.Nom;
            ActeurService acteurService = new();

            foreach (Personnage personnage in castList)
            {
                Window.lstBoxCasting.Items.Add(personnage.Nom);
            }

            Window.lstBoxCasting.SelectedIndex = 0;
            Personnage perso = castList[Window.lstBoxCasting.SelectedIndex];
            perso.Acteur = acteurService.GetById(perso.ActeurId);
            Populate(perso);
        }

        public void ListBoxCasting_SelectedIndexChanged()
        {
            if (Window.lstBoxCasting.SelectedIndex != -1)
            {
                ActeurService acteurService = new();
                Personnage perso = castList[Window.lstBoxCasting.SelectedIndex];
                perso.Acteur = acteurService.GetById(perso.ActeurId);
                Populate(perso);
            }
        }

        private void Populate(Personnage perso)
        {
            Window.lblNomPerso.Content = perso.Nom;
            Window.lblActeur.Content = perso.Acteur.Prenom + " " + perso.Acteur.Nom;
        }
    }
}
