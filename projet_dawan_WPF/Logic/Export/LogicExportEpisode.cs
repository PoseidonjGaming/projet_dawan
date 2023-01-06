using Microsoft.Win32;
using Newtonsoft.Json;
using projet_dawan_WPF.Windows.Export;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System.IO;

namespace projet_dawan_WPF.Logic.Export
{
    internal class LogicExportEpisode
    {
        public WindowExportEpisode Window { get; set; }

        public LogicExportEpisode(WindowExportEpisode window)
        {
            Window = window;
        }

        public void BtnExport_Click()
        {
            EpisodeService service = new();
            Properties.Settings.Default.ExportEpisode = service.GetAll();
            ExportSaison();
            ExportSerie();
            Export();
        }

        private void ExportSaison()
        {
            SaisonService service = new();
            foreach (Episode episode in Properties.Settings.Default.ExportEpisode)
            {
                episode.ShouldExportSaisons = true;
                episode.Saison = service.GetById(episode.SaisonId);
            }
        }

        private void ExportSerie()
        {
            if ((bool)Window.checkBoxSerie.IsChecked)
            {
                SerieService service = new();
                foreach (Episode episode in Properties.Settings.Default.ExportEpisode)
                {
                    episode.Saison.ShouldExportEpisode = false;
                    episode.Saison.ShouldExportSerie = true;
                    episode.Saison.Serie = service.GetById(episode.Saison.SerieId);
                }

                WindowExportSerie window = new()
                {
                    Owner = Window
                };
                window.ShowDialog();
            }

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
                File.WriteAllText(save.FileName, JsonConvert.SerializeObject(Properties.Settings.Default.ExportEpisode, Formatting.Indented));
            }
        }
    }
}
