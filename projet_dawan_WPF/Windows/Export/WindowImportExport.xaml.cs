using Microsoft.Win32;
using Newtonsoft.Json;
using projet_dawan_WPF.Logic.Export;
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

        private LogicImportExport logic;

        public WindowImportExport()
        {
            InitializeComponent();
            logic = new(this);
        }

        private void btnExport_Click(object sender, RoutedEventArgs e)
        {
            logic.BtnExport_Click();
        }

        
        private void btnImport_Serie_Click(object sender, RoutedEventArgs e)
        {
           logic.BtnImport_Serie_Click();
        }

        private void btnImport_Episodes_Click(object sender, RoutedEventArgs e)
        {
            logic.BtnImport_Episodes_Click() ;
        }

        private void btnImport_Personnages_Click(object sender, RoutedEventArgs e)
        {
            logic.BtnImport_Personnages_Click();
        }

        private void btnImport_Acteur_Click(object sender, RoutedEventArgs e)
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

                    int serieId=serieService.Import(newSerie).Id;
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
