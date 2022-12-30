using projet_dawan_WPF.Windows;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Media.Imaging;

namespace projet_dawan_WPF.Logic
{
    internal class LogicEpisodes
    {
        private Saison saison;
        private List<Episode> episodes = new List<Episode>();
        private EpisodeService service = new();
        public WindowEpisode Window { get; set; }

        public LogicEpisodes(WindowEpisode window)
        {
            Window = window;
        }

        public void Load(Saison saison)
        {
            this.saison = saison;
            episodes = service.GetBySaison(saison.Id);
            SerieService serieService = new();
            Serie serie = serieService.GetById(saison.SerieId);

            BitmapImage bitImg = new BitmapImage();
            bitImg.BeginInit();
            bitImg.UriSource = new(Directory.GetCurrentDirectory() + "\\Photo\\" + serie.Affiche);
            bitImg.EndInit();
            Window.pictureBoxSaison.Source = bitImg;
            Window.lblEpisode.Content = serie.Nom;
            Window.lblSaison.Content += saison.Numero.ToString();
            foreach (Episode episode in service.GetBySaison(saison.Id))
            {
                episodes.Add(episode);
                Window.lstBoxEpisode.Items.Add(episode.Nom);
            }
            if (Window.lstBoxEpisode.Items.Count > 0)
            {
                Populate(episodes[0]);
            }
        }

        public void LstBoxEpisode_SelectedIndexChanged()
        {
            if (Window.lstBoxEpisode.SelectedIndex != -1)
            {
                Episode ep = episodes[Window.lstBoxEpisode.SelectedIndex];
                Populate(ep);
            }
        }

        public void Casting_Click()
        {
            SerieService serieService = new();
            SaisonService saisonService = new();
            PersonnageService personnage = new();
            WindowCasting casting = new(personnage.GetBySerie(serieService.GetById(saisonService.GetById(episodes[Window.lstBoxEpisode.SelectedIndex].SaisonId).SerieId).Id));
            casting.ShowDialog();
        }

        private void Populate(Episode ep)
        {
            Window.txtBoxResumeSaison.Text = ep.Resume;
            Window.lblDateSaison.Content= "Episode diffusé le " + ep.DatePremDiff.Value.ToShortDateString();
            Window.lblTitreEp.Content = "Détail l'épisode: " + ep.Nom;
        }

        private void OpenForm(object sender, EventArgs e)
        {
            Window.Show();
        }
    }
}
