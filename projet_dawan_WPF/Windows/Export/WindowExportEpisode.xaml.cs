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

namespace projet_dawan_WPF.Windows.Export
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
            EpisodeService service = new();
            Properties.Settings.Default.ExportEpisode = service.GetAll();
            ExportSaison();
            ExportSerie();
            Export();
        }

        private void ExportSaison()
        {
            SaisonService service= new();
            foreach (Episode episode in Properties.Settings.Default.ExportEpisode)
            {
                episode.ShouldExportSaisons = true;
                episode.Saison = service.GetById(episode.SaisonId);
            }
        }

        private void ExportSerie()
        {
            if((bool)checkBoxSerie.IsChecked)
            {
                SerieService service = new();
                foreach (Episode episode in Properties.Settings.Default.ExportEpisode)
                {
                    episode.Saison.ShouldExportEpisode = false;
                    episode.Saison.ShouldExportSerie = true;
                    episode.Saison.Serie=service.GetById(episode.Saison.SerieId);
                }

                WindowExportSerie window= new()
                {
                    Owner= this
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
