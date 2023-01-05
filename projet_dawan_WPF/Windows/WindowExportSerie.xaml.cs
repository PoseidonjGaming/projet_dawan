using Microsoft.Win32;
using Newtonsoft.Json;
using projet_dawan_WPF.Window;
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
            if(checkBoxEp.IsEnabled)
            {
                SerieService service = new();
                Properties.Settings.Default.ExportSerie = service.GetAll();
            }
            else
            {
                List<Serie> list=new List<Serie>();
                foreach(Episode ep in Properties.Settings.Default.ExportEpisode)
                {
                    list.Add(ep.Saison.Serie);
                }
                Properties.Settings.Default.ExportSerie = list;
            }
            ExportPerso();
        }

        private void FormExportPersoClose(object sender, EventArgs e)
        {
            if(checkBoxEp.IsEnabled)
            {
                ExportEpisode();
            }
            else
            {
                this.Close();
            }
            
        }

        private void ExportPerso()
        {
            if ((bool)checkBoxShouldPersonnage.IsChecked)
            {
                WindowExportPersonnage window = new()
                {
                    Owner = this
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
            if ((bool)checkBoxEp.IsChecked)
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

            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (Owner.GetType() == typeof(WindowExportEpisode))
            {
                checkBoxEp.IsEnabled = false;
            }
        }
    }
}
