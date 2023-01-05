using Microsoft.Win32;
using Newtonsoft.Json;
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
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace projet_dawan_WPF.Windows
{
    /// <summary>
    /// Logique d'interaction pour WindowExportEpisode.xaml
    /// </summary>
    public partial class WindowExportEpisode : System.Windows.Window
    {
        public WindowExportEpisode()
        {
            InitializeComponent();
        }

        private void btnExport_Click(object sender, RoutedEventArgs e)
        {
            EpisodeService episodeService = new();
            SaisonService saisonService = new();
            SerieService serieService = new();
            List<Episode> list = episodeService.GetAll();
            if ((bool)checkBoxSerie.IsChecked)
            {
                foreach (Episode ep in list)
                {
                    ep.ShouldExportSaisons = true;
                    ep.Saison = saisonService.GetById(ep.SaisonId);
                    ep.Saison.ShouldExportEpisode = false;
                    if ((bool)checkBoxSerie.IsChecked)
                    {

                        ep.Saison.ShouldExportSerie = true;
                        ep.Saison.Serie = serieService.GetById(ep.Saison.SerieId);
                        ep.Saison.Serie.ShouldSerializeSaison = false;
                    }
                }
                Properties.Settings.Default.ExportEpisode=list;
                WindowExportSerie window = new()
                {
                    Owner = this
                };
                window.Closed += WindowClose;
                window.ShowDialog();
            }
            else
            {
                Export(list);
            }
            
            
        }

        private void WindowClose(object sender, EventArgs e)
        {
            foreach (Episode ep in Properties.Settings.Default.ExportEpisode)
            {
                ep.Saison.Serie = Properties.Settings.Default.ExportSerie.Find(s => s.Id == ep.Saison.SerieId);
            }
            Export(Properties.Settings.Default.ExportEpisode);
           
        }

        private void Export(List<Episode> list)
        {
            EpisodeService service = new();
            SaveFileDialog save = new SaveFileDialog()
            {
                InitialDirectory = Directory.GetCurrentDirectory(),
                FileName = "exports.json",
                Filter = "File JSON|*json",
                Title = "Save WatchList"
            };

            if ((bool)save.ShowDialog())
            {
                File.WriteAllText(save.FileName, JsonConvert.SerializeObject(list, Formatting.Indented));
            }
        }
    }
}
