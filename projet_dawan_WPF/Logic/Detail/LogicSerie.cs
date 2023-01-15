using projet_dawan_WPF.Logic.Autre;
using projet_dawan_WPF.Windows.Detail;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System;
using System.Collections.Generic;
using System.Windows.Media.Imaging;

namespace projet_dawan_WPF.Logic.Detail
{
    internal class LogicSerie
    {
        private Serie Serie = new();
        public WindowSerie Window { get; set; }

        public LogicSerie(WindowSerie window)
        {
            Window = window;
            Saisons = new();

        }

        public void Load(Serie serie)
        {
            Serie = serie;
            Window.lblSerie.Content = Serie.Nom;
            Window.lblDateSerie.Content = "Diffusé à partir du" + Serie.DateDiff.ToString();
            Window.linkLblBASerie.Content = Serie.UrlBa;
            Window.txtBoxResumeSerie.Text = Serie.Resume;
            try
            {
                Window.affiche.Source = new BitmapImage(new Uri(Serie.Affiche));
            }
            catch
            {

            }
            SaisonService service = new();
            Serie.Saisons = service.GetSaisonsBySerie(Serie.Id);
            foreach (Saison saison in Serie.Saisons)
            {
                Window.lstBoxSaison.Items.Add(saison.Numero.ToString());
            }

            if (Properties.Settings.Default.UserRemain.ToWatchList.Contains(Serie.Id))
            {

                Window.buttonToWatch.Content = "✔";
            }
            else
            {
                Window.buttonToWatch.Content = " Ajouter à la liste à regarder";
            }
        }

        public void BtnCasting_Click()
        {
            PersonnageService service = new();
            WindowCasting casting = new(service.GetBySerie(Serie.Id))
            {
                Owner = Window
            };
            casting.ShowDialog();
        }

        public void LstBoxSaison_SelectedIndexChanged()
        {
            if (Window.lstBoxSaison.SelectedIndex != -1)
            {
                Saison saison = Serie.Saisons[Window.lstBoxSaison.SelectedIndex];
                saison.Serie = Serie;
                WindowEpisode window = new(saison)
                {
                    Owner = Window
                };
                window.Closed += OpenForm;
                Window.Hide();
                window.ShowDialog();
            }
        }

        public void ButtonToWatch_Click()
        {
            if (!Properties.Settings.Default.UserRemain.ToWatchList.Contains(Serie.Id))
            {

                Properties.Settings.Default.UserRemain.SetToWatchList(new() { Serie });
                Properties.Settings.Default.Save();
                UserService service = new();
                service.Update(Properties.Settings.Default.UserRemain);
                Window.buttonToWatch.Content = "✔";
            }
            else
            {
                Properties.Settings.Default.UserRemain.UnsetToWatchlist(new() { Serie });
                Properties.Settings.Default.Save();
                Window.buttonToWatch.Content = " Ajouter à la liste à regarder";
            }
        }

        private void OpenForm(object sender, EventArgs e)
        {
            Window.Show();
        }
    }
}
