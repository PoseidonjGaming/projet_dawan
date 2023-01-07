using Microsoft.Win32;
using Newtonsoft.Json;
using projet_dawan_WPF.Windows.Autre;
using projet_dawan_WPF.Windows.Export;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System;
using System.IO;

namespace projet_dawan_WPF.Logic.Export
{
    internal class LogicExportSerie
    {
        public WindowExportSerie Window { get; set; }
        private readonly SerieService service = new();

        public LogicExportSerie(WindowExportSerie window)
        {
            Window = window;
        }

        public void Load()
        {
            if (Window.Owner.GetType() == typeof(WindowExportEpisode))
            {
                Window.checkBoxEp.IsEnabled = false;
            }
            else if (Window.Owner.GetType() == typeof(WindowExportPersonnage))
            {
                Window.checkBoxShouldPersonnage.IsEnabled = false;
            }
        }

        public void BtnExport_Click()
        {
            PersonnageService Personnageservice = new();
            if (Window.Owner.GetType() == typeof(WindowImportExport))
            {
                Properties.Settings.Default.ExportSerie = service.GetAll();
                ExportEpisode();
                ExportPerso();
                WindowExportPersonnage windowExportPersonnage = new()
                {
                    Owner = Window
                };
                windowExportPersonnage.ShowDialog();
                Window.Close();
            }
            else if (Window.Owner.GetType() == typeof(WindowExportEpisode))
            {
                foreach (Episode episode in Properties.Settings.Default.ExportEpisode)
                {
                    Properties.Settings.Default.ExportSerie = new() { episode.Saison.Serie };
                    ExportPerso();
                    episode.Saison.Serie = Properties.Settings.Default.ExportSerie[0];
                }

                WindowExportPersonnage window = new()
                {
                    Owner = Window
                };
                window.Closed += FormExportPersoClose;
                window.Show();


            }
            else if (Window.Owner.GetType() == typeof(WindowExportPersonnage))
            {
                foreach (Acteur acteur in Properties.Settings.Default.ExportActeur)
                {
                    foreach (Personnage perso in acteur.Personnages)
                    {
                        Properties.Settings.Default.ExportSerie = new() { perso.Serie };
                        ExportEpisode();
                        perso.Serie = Properties.Settings.Default.ExportSerie[0];
                    }
                }

                Window.Close();
            }
        }

        private void ExportPerso()
        {
            PersonnageService service = new();
            if ((bool)Window.checkBoxShouldPersonnage.IsChecked)
            {
                foreach (Serie serie in Properties.Settings.Default.ExportSerie)
                {
                    serie.ShouldExportPersonnage = true;
                    serie.Personnages = service.GetBySerie(serie.Id);
                }
            }

        }

        private void ExportEpisode()
        {
            if ((bool)Window.checkBoxEp.IsChecked)
            {
                SaisonService service = new();
                EpisodeService episodeService = new();
                foreach (Serie serie in Properties.Settings.Default.ExportSerie)
                {
                    serie.ShouldExportSaison = true;
                    serie.Saisons = service.GetSaisonsBySerie(serie.Id);
                    foreach (Saison saison in serie.Saisons)
                    {
                        saison.Episodes = episodeService.GetBySaison(saison.Id);
                        saison.ShouldExportSerie = false;
                        saison.ShouldExportEpisode = true;
                        foreach (Episode ep in saison.Episodes)
                        {
                            ep.ShouldExportSaisons = false;
                        }
                    }
                }
            }
        }


        private void FormExportPersoClose(object sender, EventArgs e)
        {
            Window.Close();
        }
    }
}
