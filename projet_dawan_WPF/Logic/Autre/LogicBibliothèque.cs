using projet_dawan_WPF.Windows.Autre;
using projet_dawan_WPF.Windows.Detail;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System.Collections.Generic;
using System.Windows;

namespace projet_dawan_WPF.Logic.Autre
{

    internal class LogicBibliothèque
    {
        public WindowBibliotheque Window { get; set; }
        private List<int> Ids = new List<int>();

        public LogicBibliothèque(WindowBibliotheque window)
        {
            Window = window;
        }

        public void Load(string text)
        {
            string[] items = new string[] { "Serie", "Episode", "Personnage", "Acteur" };
            foreach (string item in items)
            {
                Window.cmbFiltrer.Items.Add(item);
            }

            Window.cmbFiltrer.SelectedIndex = 0;
            Window.txtRechercher.Text = text;

            if (Properties.Settings.Default.UserRemain == null)
            {
                Window.btnAddWitch.IsEnabled = false;
            }
        }

        public void ChangeText()
        {
            Ids.Clear();
            Window.lstBxSerie.Items.Clear();
            Check();
        }

        public void CmbFiltrer_SelectedIndexChanged()
        {
            if (Window.cmbFiltrer.SelectedIndex != -1)
            {
                Window.lstBxSerie.Items.Clear();
                Ids.Clear();
                Check();
            }
        }

        public void Detail()
        {

            if (Window.cmbFiltrer.SelectedIndex != -1 && Window.lstBxSerie.SelectedIndex != -1)
            {
                switch (Window.cmbFiltrer.SelectedIndex)
                {
                    case 0:
                        SerieService serieService = new();
                        WindowSerie windowSerie = new(serieService.GetById(Ids[Window.lstBxSerie.SelectedIndex]))
                        {
                            Owner = Window
                        };
                        windowSerie.ShowDialog();
                        break;
                    case 1:
                        EpisodeService episodeService = new();
                        SaisonService saisonService = new();
                        WindowEpisode windowEpisode = new(saisonService.GetById(episodeService.GetById(Ids[Window.lstBxSerie.SelectedIndex]).SaisonId))
                        {
                            Owner = Window
                        };
                        windowEpisode.ShowDialog();
                        break;
                    case 2:
                        PersonnageService personnageService = new();
                        WindowCasting windowCasting = new(personnageService.GetBySerie(Ids[Window.lstBxSerie.SelectedIndex]))
                        {
                            Owner = Window
                        };
                        windowCasting.ShowDialog();
                        break;
                    case 3:
                        PersonnageService personnageServiceA = new();
                        WindowCasting form = new(personnageServiceA.GetByActeur(Ids[Window.lstBxSerie.SelectedIndex]))
                        {
                            Owner = Window
                        };
                        form.ShowDialog();
                        break;
                    default:
                        break;
                }

            }
        }

        public void ButtonAddWich_Click()
        {
            if (Window.lstBxSerie.SelectedIndex != -1 && Window.cmbFiltrer.SelectedIndex == 0)
            {
                SerieService serieService = new();
                Serie serie = serieService.GetById(Ids[Window.lstBxSerie.SelectedIndex]);
                Properties.Settings.Default.UserRemain.SetToWatchList(new() { serie });
                Properties.Settings.Default.Save();
                UserService service = new();
                service.Update(Properties.Settings.Default.UserRemain);
                Window.btnAddWitch.Content = "✔";
            }
        }

        public void BtnRetour_Click()
        {
            Window.Close();
        }
        private void Check()
        {
            List<string> list = new List<string>();
            switch (Window.cmbFiltrer.SelectedIndex)
            {
                case 0:
                    SerieService serieService = new();
                    List<Serie> series = serieService.GetByTxt(Window.txtRechercher.Text);
                    foreach (Serie serie in series)
                    {
                        list.Add(serie.Nom);
                        Ids.Add(serie.Id);
                    }
                    Populate(list);
                    break;
                case 1:
                    EpisodeService epService = new();
                    List<Episode> episodes = epService.GetByTxt(Window.txtRechercher.Text);
                    foreach (Episode episode in episodes)
                    {
                        list.Add(episode.Nom);
                        Ids.Add(episode.Id);
                    }
                    Populate(list);
                    break;
                case 2:
                    PersonnageService personnageService = new();
                    List<Personnage> personnages = personnageService.GetByTxt(Window.txtRechercher.Text);
                    foreach (Personnage personnage in personnages)
                    {
                        list.Add(personnage.Nom);
                        Ids.Add(personnage.Id);
                    }
                    Populate(list);
                    break;
                case 3:
                    ActeurService acteurService = new();
                    List<Acteur> acteurs = acteurService.GetByTxt(Window.txtRechercher.Text);
                    foreach (Acteur acteur in acteurs)
                    {
                        list.Add(acteur.Prenom + " " + acteur.Nom);
                        Ids.Add(acteur.Id);
                    }
                    Populate(list);
                    break;

                default:
                    MessageBox.Show("Pas de Filtre seléctionné");
                    break;
            }

        }
        private void Populate(List<string> list)
        {
            foreach (string item in list)
            {
                Window.lstBxSerie.Items.Add(item);
            }
        }
    }
}
