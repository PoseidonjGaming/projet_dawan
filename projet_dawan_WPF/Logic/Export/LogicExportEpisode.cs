using projet_dawan_WPF.Logic.Autre;
using projet_dawan_WPF.Windows.Export;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;

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
            if (Window.Owner.GetType() == typeof(WindowImportExport))
            {
                EpisodeService service = new();
                Properties.Settings.Default.ExportEpisode = service.GetAll();
                ExportSaison();
                OpenWindowExportSerie();
                Window.Close();
            }
        }

        private void ExportSaison()
        {
            if ((bool)Window.checkBoxSerie.IsChecked)
            {
                SaisonService service = new();
                foreach (Episode episode in Properties.Settings.Default.ExportEpisode)
                {
                    episode.ShouldExportSaisons = true;
                    episode.Saison = service.GetById(episode.SaisonId);
                    episode.Saison.ShouldExportEpisode = false;
                    Properties.Settings.Default.ExportSaison = new() { episode.Saison };
                    ExportSerie();
                    episode.Saison = Properties.Settings.Default.ExportSaison[0];
                }

            }

        }

        private void ExportSerie()
        {
            Properties.Settings.Default.ExportSerie = new();
            SerieService service = new();
            foreach (Saison saison in Properties.Settings.Default.ExportSaison)
            {
                saison.ShouldExportSerie = true;
                saison.Serie = service.GetById(saison.SerieId);
            }
        }

        private void OpenWindowExportSerie()
        {
            if ((bool)Window.checkBoxSerie.IsChecked)
            {
                WindowExportSerie window = new()
                {
                    Owner = Window
                };
                window.ShowDialog();
            }

        }
    }
}
