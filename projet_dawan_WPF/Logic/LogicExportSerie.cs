using Microsoft.Win32;
using Newtonsoft.Json;
using projet_dawan_WPF.Windows;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace projet_dawan_WPF.Logic
{
    internal class LogicExportSerie
    {
        public WindowExportSerie Window { get; set; }

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
        }

        public void BtnExport_Click()
        {
            if (Window.checkBoxEp.IsEnabled)
            {
                SerieService service = new();
                Properties.Settings.Default.ExportSerie = service.GetAll();
            }
            else
            {
                List<Serie> list = new List<Serie>();
                foreach (Episode ep in Properties.Settings.Default.ExportEpisode)
                {
                    list.Add(ep.Saison.Serie);
                }
                Properties.Settings.Default.ExportSerie = list;
            }
            ExportPerso();
        }

        private void ExportPerso()
        {
            if ((bool)Window.checkBoxShouldPersonnage.IsChecked)
            {
                WindowExportPersonnage window = new()
                {
                    Owner = Window
                };
                window.Closed += FormExportPersoClose;
                window.Show();
            }
            else
            {
                ExportEpisode();
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
                    serie.ShouldSerializeSaison = true;
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
            Export();
        }

        private void Export()
        {
            SaveFileDialog save = new SaveFileDialog()
            {
                InitialDirectory = Directory.GetCurrentDirectory(),
                FileName = "exports.json",
                Filter = "File JSON|*json",
                Title = "Save WatchList"
            };

            if ((bool)save.ShowDialog())
            {
                File.WriteAllText(save.FileName, JsonConvert.SerializeObject(Properties.Settings.Default.ExportSerie, Formatting.Indented));
            }

            Window.Close();
        }

        private void FormExportPersoClose(object sender, EventArgs e)
        {
            if (Window.checkBoxEp.IsEnabled)
            {
                ExportEpisode();
            }
            else
            {
                Window.Close();
            }

        }
    }
}
