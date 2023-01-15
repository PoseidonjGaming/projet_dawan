using projet_dawan_WPF.Logic.Autre;
using projet_dawan_WPF.Windows.Detail;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System;
using System.Collections.Generic;
using System.Windows.Media.Imaging;

namespace projet_dawan_WPF.Logic.Detail
{
    internal class LogicEpisodes
    {
        private Saison Saison;
        private readonly EpisodeService service;
        public WindowEpisode Window { get; set; }

        public LogicEpisodes(WindowEpisode window)
        {
            Window = window;
            service = new();
            service=new();
        }

        public void Load(Saison saison)
        {
            Saison = saison;
            Saison.Episodes = service.GetBySaison(saison.Id);
            SerieService serieService = new();
            Saison.Serie = serieService.GetById(saison.SerieId);

            BitmapImage bitImg = new();
            try
            {
                bitImg.BeginInit();
                bitImg.UriSource = new(Saison.Serie.Affiche);
                bitImg.EndInit();
            }
            catch
            {

            }

            Window.pictureBoxSaison.Source = bitImg;
            Window.lblEpisode.Content = Saison.Serie.Nom;
            Window.lblSaison.Content += saison.Numero.ToString();
            foreach (Episode episode in Saison.Episodes)
            {
                Window.lstBoxEpisode.Items.Add(episode.Nom);
            }
            if (Window.lstBoxEpisode.Items.Count > 0)
            {
                Populate(Saison.Episodes[0]);
            }
        }

        public void LstBoxEpisode_SelectedIndexChanged()
        {
            if (Window.lstBoxEpisode.SelectedIndex != -1)
            {
                Episode ep = Saison.Episodes[Window.lstBoxEpisode.SelectedIndex];
                Populate(ep);
            }
        }

        public void Casting_Click()
        {
            
            PersonnageService personnage = new();
            WindowCasting casting = new(personnage.GetBySerie(Saison.SerieId))
            {
                Owner = Window
            };
            casting.ShowDialog();
        }

        private void Populate(Episode ep)
        {
            Window.txtBoxResumeSaison.Text = ep.Resume;
            Window.lblDateSaison.Content = "Episode diffusé le " + ep.DatePremDiff.ToShortDateString();
            Window.lblTitreEp.Content = "Détail l'épisode: " + ep.Nom;
        }

        
    }
}
