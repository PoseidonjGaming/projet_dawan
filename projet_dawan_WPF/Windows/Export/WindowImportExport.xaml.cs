using Microsoft.Win32;
using Newtonsoft.Json;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
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

        private SerieService serieService = new();
        private PersonnageService personnageService = new();
        private ActeurService acteurService = new();
        private EpisodeService episodeService = new();


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
                Export(seriesList, "exportSerie", "Séries");

            }
            if (checkBoxExportEpisodes.IsChecked == true)
            {
                WindowExportEpisode windowExportEpisode = new()
                {
                    Owner = this
                };
                windowExportEpisode.Closed += EpisodeClose;
                windowExportEpisode.ShowDialog();
                Export(episodeList, "exportsEpisode", "Episodes");
            }
            if (checkBoxExportPersonnages.IsChecked == true)
            {
                WindowExportPersonnage windowExportPersonnage = new()
                {
                    Owner = this
                };
                windowExportPersonnage.Closed += PersonnagesClose;
                windowExportPersonnage.ShowDialog();
                Export(personnagesList, "exportsPersonnage", "Personnages");
            }
            if (checkBoxActeurs.IsChecked == true)
            {
                WindowExportActeur windowExportActeur = new()
                {
                    Owner = this
                };
                windowExportActeur.Closed += ActeurClose;
                windowExportActeur.ShowDialog();
                Export(acteurList, "exportsActeurs", "Acteurs");
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

        private void btnImport_Serie_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == true)
            {
                try
                {
                    seriesList = JsonConvert.DeserializeObject<List<Serie>>(File.ReadAllText(fileDialog.FileName));
                    ImportSerie();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.InnerException.Message);
                }
            }
        }

        private void ImportSerie()
        {

            foreach (Serie newSerie in seriesList)
            {
                if (!serieService.CompareTo(newSerie))
                {
                    personnagesList = newSerie.Personnages;
                    newSerie.Personnages = new();
                    if (!serieService.CompareTo(newSerie))
                    {
                        serieService.Add(newSerie);
                    }
                    if (personnagesList.Count > 0)
                    {

                        foreach (Personnage personnage in personnagesList)
                        {
                            personnage.SerieId = serieService.GetCompareTo(newSerie).Id;
                        }
                        
                        ImportPersonnages();

                    }


                }
            }
        }

        private void ImportPersonnages()
        {
            foreach (Personnage personnage in personnagesList)
            {
                if (personnage.Acteur != null)
                {
                    acteurList = new() { personnage.Acteur };
                    personnage.Acteur = null;
                    ImportActeur();
                    personnage.ActeurId = acteurService.GetCompareTo(acteurList[0]).Id;
                    personnageService.Add(personnage);
                }
            }

        }

        private void ImportActeur()
        {
            foreach (Acteur acteur in acteurList)
            {
                if (!acteurService.CompareTo(acteur))
                {
                    acteurService.Add(acteur);
                }
            }
        }

    }
}
