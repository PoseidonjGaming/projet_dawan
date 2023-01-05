using Microsoft.Win32;
using Newtonsoft.Json;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
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
    /// Logique d'interaction pour WindowExportSerie.xaml
    /// </summary>
    public partial class WindowExportSerie : System.Windows.Window
    {
        public WindowExportSerie()
        {
            InitializeComponent();
        }

        private void btnExport_Click(object sender, RoutedEventArgs e)
        {
            SerieService service = new();
            Properties.Settings.Default.Export = service.GetAll();
            ExportPerso();
        }

        private void FormExportPersoClose(object sender, EventArgs e)
        {
            ExportEpisode();
        }

        private void ExportPerso()
        {
            if ((bool)checkBoxShouldPersonnage.IsChecked)
            {
                WindowExportPersonnage window = new();
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
            if ((bool)checkBoxEp.IsChecked)
            {
                SaisonService service = new();
                EpisodeService episodeService = new();
                foreach (Serie serie in Properties.Settings.Default.Export)
                {
                    serie.ShouldSerializeSaison = true;
                    serie.Saisons = service.GetSaisonsBySerie(serie.Id);
                    foreach (Saison saison in serie.Saisons)
                    {
                        saison.Episodes = episodeService.GetBySaison(saison.Id);
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
                File.WriteAllText(save.FileName, JsonConvert.SerializeObject(Properties.Settings.Default.Export, Formatting.Indented));
            }

            this.Close();
        }
    }
}
