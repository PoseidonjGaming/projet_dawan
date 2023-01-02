using projet_dawan_WPF.Window;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System.Collections.Generic;
using System.Windows;

namespace projet_dawan_WPF.Logic
{

    internal class LogicBibliothèque
    {
        public WindowBibliotheque Window { get; set; }
        private List<int> Ids = new List<int>();

        public LogicBibliothèque(WindowBibliotheque form)
        {
            Window = form;
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

            if (Window.cmbFiltrer.SelectedIndex != -1)
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
            //if (Windows.GetListBoxSerie().SelectedIndex != -1)
            //{
            //    SerieService serieService = new();
            //    Serie serie = serieService.GetById(Ids[Windows.GetListBoxSerie().SelectedIndex]);
            //    Properties.Settings.Default.UserRemain.SetToWatchList(new() { serie });
            //    Properties.Settings.Default.Save();
            //    UserService service = new();
            //    service.Update(Properties.Settings.Default.UserRemain);
            //}
        }

        public void BtnRetour_Click()
        {
            projet_dawan_WPF.Window.Close();
        }
        private void Check()
        {
            List<string> list = new List<string>();
            switch (projet_dawan_WPF.Window.cmbFiltrer.SelectedIndex)
            {
                case 0:
                    SerieService serieService = new();
                    List<Serie> series = serieService.GetByTxt(projet_dawan_WPF.Window.txtRechercher.Text);
                    foreach (Serie serie in series)
                    {
                        list.Add(serie.Nom);
                        Ids.Add(serie.Id);
                    }
                    Populate(list);
                    break;
                case 1:
                    EpisodeService epService = new();
                    List<Episode> episodes = epService.GetByTxt(projet_dawan_WPF.Window.txtRechercher.Text);
                    foreach (Episode episode in episodes)
                    {
                        list.Add(episode.Nom);
                        Ids.Add(episode.Id);
                    }
                    Populate(list);
                    break;
                case 2:
                    PersonnageService personnageService = new();
                    List<Personnage> personnages = personnageService.GetByTxt(projet_dawan_WPF.Window.txtRechercher.Text);
                    foreach (Personnage personnage in personnages)
                    {
                        list.Add(personnage.Nom);
                        Ids.Add(personnage.Id);
                    }
                    Populate(list);
                    break;
                case 3:
                    ActeurService acteurService = new();
                    List<Acteur> acteurs = acteurService.GetByTxt(projet_dawan_WPF.Window.txtRechercher.Text);
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
                projet_dawan_WPF.Window.lstBxSerie.Items.Add(item);
            }
        }
    }
}
