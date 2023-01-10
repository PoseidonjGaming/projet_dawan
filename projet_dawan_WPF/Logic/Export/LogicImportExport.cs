using Microsoft.Data.SqlClient;
using Microsoft.Win32;
using Newtonsoft.Json;
using projet_dawan_WPF.Windows.Export;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace projet_dawan_WPF.Logic.Export
{
    internal class LogicImportExport
    {
        private List<Serie> seriesList = new();
        private List<Episode> episodeList = new();
        private List<Acteur> acteurList = new();
        private List<Personnage> personnagesList = new();
        private List<Saison> saisonList = new();

        private SerieService serieService = new();
        private PersonnageService personnageService = new();
        private ActeurService acteurService = new();
        private EpisodeService episodeService = new();
        private SaisonService saisonService = new();

        public WindowImportExport Window { get; set; }

        public LogicImportExport(WindowImportExport window)
        {
            Window = window;
        }

        public void BtnExport_Click()
        {
            if (Window.checkBoxExportSeries.IsChecked == true)
            {
                WindowExportSerie windowExportSerie = new()
                {
                    Owner = Window
                };
                windowExportSerie.Closed += SerieClose;
                windowExportSerie.ShowDialog();
                Export(seriesList, "exportSerie", "Séries");

            }
            if (Window.checkBoxExportEpisodes.IsChecked == true)
            {
                WindowExportEpisode windowExportEpisode = new()
                {
                    Owner = Window
                };
                windowExportEpisode.Closed += EpisodeClose;
                windowExportEpisode.ShowDialog();
                Export(episodeList, "exportsEpisode", "Episodes");
            }
            if (Window.checkBoxExportPersonnages.IsChecked == true)
            {
                WindowExportPersonnage windowExportPersonnage = new()
                {
                    Owner = Window
                };
                windowExportPersonnage.Closed += PersonnagesClose;
                windowExportPersonnage.ShowDialog();
                Export(personnagesList, "exportsPersonnage", "Personnages");
            }
            if (Window.checkBoxActeurs.IsChecked == true)
            {
                WindowExportActeur windowExportActeur = new()
                {
                    Owner = Window
                };
                windowExportActeur.Closed += ActeurClose;
                windowExportActeur.ShowDialog();
                Export(acteurList, "exportsActeurs", "Acteurs");
            }
        }

        public void BtnImport_Serie_Click()
        {
            OpenFileDialog fileDialog = new();
            if (fileDialog.ShowDialog() == true)
            {
                try
                {
                    seriesList = (List<Serie>)JsonConvert.DeserializeObject(File.ReadAllText(fileDialog.FileName));
                    ImportSerie();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.InnerException.Message);
                }
            }
        }

        public void BtnImport_Episodes_Click()
        {
            OpenFileDialog fileDialog = new();
            if (fileDialog.ShowDialog() == true)
            {
                try
                {
                    episodeList = (List<Episode>)JsonConvert.DeserializeObject(File.ReadAllText(fileDialog.FileName));
                    ImportEpisode();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void BtnImport_Personnages_Click()
        {
            OpenFileDialog fileDialog = new();
            if (fileDialog.ShowDialog() == true)
            {
                try
                {
                    personnagesList = (List<Personnage>)JsonConvert.DeserializeObject(File.ReadAllText(fileDialog.FileName));
                    ImportPersonnages();
                }
                catch
                {

                }
            }
        }

        public void BtnImport_Acteur_Click()
        {
            OpenFileDialog fileDialog = new();
            if (fileDialog.ShowDialog() == true)
            {
                try
                {
                    acteurList = JsonConvert.DeserializeObject<List<Acteur>>(File.ReadAllText(fileDialog.FileName));
                    ImportActeur();
                }
                catch
                {

                }
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

        private static void Export<T>(List<T> list, string defaultFileName, string title)
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

        private void ImportSerie()
        {
            foreach (Serie newSerie in seriesList)
            {
                if (!serieService.CompareTo(newSerie))
                {
                    personnagesList = newSerie.Personnages;
                    newSerie.Personnages = new();
                    saisonList = newSerie.Saisons;
                    newSerie.Saisons = new();

                    int serieId = serieService.Import(newSerie).Id;
                    if (personnagesList.Count > 0)
                    {

                        foreach (Personnage personnage in personnagesList)
                        {
                            personnage.SerieId = serieId;
                            personnage.Serie = null;
                        }
                        ImportPersonnages();
                    }
                    if (saisonList.Count > 0)
                    {
                        foreach (Saison saison in saisonList)
                        {
                            saison.SerieId = serieService.GetCompareTo(newSerie).Id;
                            saison.Serie = null;
                            ImportSaison();
                        }
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

                }
                if (personnage.Serie != null)
                {
                    seriesList = new() { personnage.Serie };
                    personnage.Serie = null;
                    ImportSerie();
                    personnage.SerieId = serieService.GetCompareTo(seriesList[0]).Id;

                }
                if (!personnageService.CompareTo(personnage))
                {
                    personnageService.Add(personnage);
                }

            }

        }

        private void ImportActeur()
        {
            foreach (Acteur acteur in acteurList)
            {
                personnagesList = acteur.Personnages;
                acteur.Personnages = new();
                if (!acteurService.CompareTo(acteur))
                {
                    acteurService.Add(acteur);
                }
                if (personnagesList.Count > 0)
                {
                    foreach (Personnage personnage in personnagesList)
                    {
                        personnage.ActeurId = acteurService.GetCompareTo(acteur).Id;
                    }
                    ImportPersonnages();
                }

            }
        }

        private void ImportEpisode()
        {
            foreach (Episode episode in episodeList)
            {
                if (episode.Saison != null)
                {
                    saisonList = new() { episode.Saison };
                    ImportSaison();
                }
                if (!episodeService.CompareTo(episode))
                {
                    episodeService.Add(episode);
                }

            }
        }

        private void ImportSaison()
        {
            foreach (Saison saison in saisonList)
            {

                if (saison.Serie != null)
                {
                    seriesList = new() { saison.Serie };
                    ImportSerie();
                    saison.SerieId = serieService.GetCompareTo(saison.Serie).Id;
                }
                if (!saisonService.CompareTo(saison))
                {
                    saison.Serie = null;
                    saisonService.Add(saison);
                    saison.Serie = serieService.GetById(saison.SerieId);
                }
                episodeList = saison.Episodes;
                saison.Episodes = new();
                if (episodeList.Count > 0)
                {
                    foreach (Episode episode in episodeList)
                    {
                        episode.SaisonId = saisonService.GetCompareTo(saison).Id;
                        episode.Saison = saison;
                    }
                    ImportEpisode();
                }
            }
        }

    }
}
