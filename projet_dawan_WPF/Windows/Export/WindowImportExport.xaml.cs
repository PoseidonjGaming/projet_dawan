using Microsoft.Win32;
using Newtonsoft.Json;
using SerieDLL_EF.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Printing;
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
    /// Logique d'interaction pour WindowImportExport.xaml
    /// </summary>
    public partial class WindowImportExport : Window
    {
        private List<Serie> seriesList = new();
        private List<Episode> episodeList = new();
        private List<Acteur> acteurList = new();
        private List<Personnage> personnagesList = new();
        public WindowImportExport()
        {
            InitializeComponent();
        }

        private void btnExport_Click(object sender, RoutedEventArgs e)
        {
            if (checkBoxExportSeries.IsChecked == true)
            {
                WindowExportSerie windowExportSerie = new()
                {
                    Owner = this
                };
                windowExportSerie.Closed += SerieClose;
                windowExportSerie.ShowDialog();
                Export<Serie>(seriesList, "exportSerie", "Séries");

            }
            if (checkBoxExportEpisodes.IsChecked == true)
            {
                WindowExportEpisode windowExportEpisode = new()
                {
                    Owner = this
                };
                windowExportEpisode.Closed += EpisodeClose;
                windowExportEpisode.ShowDialog();
                Export<Episode>(episodeList, "exportsEpisode", "Episodes");
            }
            if (checkBoxExportPersonnages.IsChecked == true)
            {
                WindowExportPersonnage windowExportPersonnage = new()
                {
                    Owner = this
                };
                windowExportPersonnage.Closed += PersonnagesClose;
                windowExportPersonnage.ShowDialog();
                Export<Personnage>(personnagesList, "exportsPersonnage", "Personnages");
            }
            if (checkBoxActeurs.IsChecked == true)
            {
                WindowExportActeur windowExportActeur = new()
                {
                    Owner = this
                };
                windowExportActeur.Closed += ActeurClose;
                windowExportActeur.ShowDialog();
                Export<Acteur>(acteurList, "exportsActeurs", "Acteurs");
            }
        }

        private void SerieClose(object sender, EventArgs e)
        {
            seriesList = Properties.Settings.Default.ExportSerie;
        }

        private void EpisodeClose(object sender, EventArgs e)
        {
            episodeList = Properties.Settings.Default.ExportEpisode;
        }

        private void PersonnagesClose(object sender, EventArgs e)
        {
            personnagesList = Properties.Settings.Default.ExportPersonnage;
        }

        private void ActeurClose(object sender, EventArgs e)
        {
            acteurList = Properties.Settings.Default.ExportActeur;
        }

        private void Export<T>(List<T> list, string defaultFileName, string title)
        {
            SaveFileDialog save = new SaveFileDialog()
            {
                InitialDirectory = Directory.GetCurrentDirectory(),
                FileName = defaultFileName + ".json",
                Filter = "File JSON|*json",
                Title = "Exportation des " + title
            };

            if ((bool)save.ShowDialog())
            {
                File.WriteAllText(save.FileName, JsonConvert.SerializeObject(list, Formatting.Indented));
            }
        }
    }
}
