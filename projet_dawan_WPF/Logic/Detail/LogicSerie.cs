using projet_dawan_WPF.Logic.Autre;
using projet_dawan_WPF.Windows.Autre;
using projet_dawan_WPF.Windows.Detail;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System;
using System.Collections.Generic;
using System.Windows;
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

        }

        public void Load(Serie serie)
        {
            Serie = serie;
            Window.lblSerie.Content = Serie.Nom;
            Window.lblDateSerie.Content = "Diffusé à partir du" + Serie.DateDiff.Value.ToShortDateString();
            Window.linkLblBASerie.Content = Serie.UrlBa;
            Window.txtBoxResumeSerie.Text = Serie.Resume;
            Window.Title = Serie.Nom;
            NoteService noteService = new();
            double avg = noteService.GetNoteAverage(Serie.Id);
            if (!double.IsNaN(avg))
            {
                Window.lblAvg.Content += " " + avg + "/5";
            }
            else
            {
                Window.lblAvg.Content = "Il n'y a aucune note pour cette série";
            }
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

            if (Properties.Settings.Default.UserRemain != null)
            {
                if (Properties.Settings.Default.UserRemain.ToWatchList.Contains(Serie.Id))
                {

                    Window.menuItemToWatch.Header = "✔";
                }
                else
                {
                    Window.menuItemToWatch.Header = " Ajouter à la liste à regarder";
                }
            }
            else
            {
                Window.menuItemToWatch.IsEnabled = false;
                Window.menuItemNote.IsEnabled = false;
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
                Window.menuItemToWatch.Header = "✔";
            }
            else
            {
                Properties.Settings.Default.UserRemain.UnsetToWatchlist(new() { Serie });
                Properties.Settings.Default.Save();
                Window.menuItemToWatch.Header = " Ajouter à la liste à regarder";
            }
        }

        public void BtnNote_Click()
        {
            WindowNote window = new(Serie.Id)
            {
                Owner = Window
            };
            window.ShowDialog();
        }

        private void OpenForm(object sender, EventArgs e)
        {
            Window.Show();
        }
    }
}
