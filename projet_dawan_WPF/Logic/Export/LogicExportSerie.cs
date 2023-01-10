﻿using Microsoft.Win32;
using Newtonsoft.Json;
using projet_dawan_WPF.Logic.Autre;
using projet_dawan_WPF.Windows.Autre;
using projet_dawan_WPF.Windows.Export;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Automation.Provider;
using System.Windows.Documents;

namespace projet_dawan_WPF.Logic.Export
{
    internal class LogicExportSerie : BaseLogic
    {
        public WindowExportSerie Window { get; set; }
        private readonly SerieService service;

        public LogicExportSerie(WindowExportSerie window)
        {
            Window = window;
            service = new(Cnx);
        }

        public void Load()
        {
            if (Window.Owner.GetType() == typeof(WindowExportEpisode))
            {
                Window.checkBoxEp.IsEnabled = false;
            }
            else if (Window.Owner.GetType() == typeof(WindowExportPersonnage))
            {
                Window.checkBoxPersonnage.IsEnabled = false;
            }
        }

        public void BtnExport_Click()
        {
            if (Window.Owner.GetType() == typeof(WindowExportEpisode))
            {
                foreach (Episode episode in Properties.Settings.Default.ExportEpisode)
                {
                    Properties.Settings.Default.ExportSerie = new() { episode.Saison.Serie };
                    ExportPerso();
                    episode.Saison.Serie = Properties.Settings.Default.ExportSerie[0];
                }
                OpenWindowPersonnage();
            }
            else if (Window.Owner.GetType() == typeof(WindowImportExport))
            {
                SerieService service = new(Cnx);
                Properties.Settings.Default.ExportSerie = service.GetAll();
                ExportSaison();
                ExportPerso();
                OpenWindowPersonnage();
            }
            else if (Window.Owner.GetType() == typeof(WindowExportPersonnage))
            {
                if (Window.Owner.Owner.GetType() == typeof(WindowImportExport))
                {
                    foreach (Personnage perso in Properties.Settings.Default.ExportPersonnage)
                    {
                        Properties.Settings.Default.ExportSerie = new() { perso.Serie };
                        ExportSaison();
                        perso.Serie = Properties.Settings.Default.ExportSerie[0];
                    }
                }
                else if (Window.Owner.Owner.GetType() == typeof(WindowExportActeur))
                {
                    foreach (Acteur acteur in Properties.Settings.Default.ExportActeur)
                    {
                        foreach (Personnage personnage in acteur.Personnages)
                        {
                            Properties.Settings.Default.ExportSerie = new() { personnage.Serie };
                            ExportSaison();
                            personnage.Serie = Properties.Settings.Default.ExportSerie[0];
                        }
                    }
                }

                Close();
            }
        }

        private void ExportPerso()
        {
            if ((bool)Window.checkBoxPersonnage.IsChecked)
            {
                PersonnageService service = new(Cnx);
                foreach (Serie serie in Properties.Settings.Default.ExportSerie)
                {
                    serie.ShouldExportPersonnage = true;
                    serie.Personnages = service.GetBySerie(serie.Id);
                }
            }
        }

        private void ExportEpisode()
        {
            EpisodeService service = new(Cnx);
            foreach (Saison saison in Properties.Settings.Default.ExportSaison)
            {
                saison.ShouldExportEpisode = true;
                saison.ShouldExportSerie = false;
                saison.Episodes = service.GetBySaison(saison.Id);
            }
        }

        private void ExportSaison()
        {
            if ((bool)Window.checkBoxEp.IsChecked)
            {
                SaisonService saisonService = new(Cnx);
                foreach (Serie serie in Properties.Settings.Default.ExportSerie)
                {
                    Properties.Settings.Default.ExportSaison = saisonService.GetSaisonsBySerie(serie.Id);
                    serie.ShouldExportSaison = true;
                    ExportEpisode();
                    serie.Saisons = Properties.Settings.Default.ExportSaison;
                }
            }
        }

        private void OpenWindowPersonnage()
        {
            if ((bool)Window.checkBoxPersonnage.IsChecked)
            {
                WindowExportPersonnage window = new()
                {
                    Owner = Window
                };
                window.Closed += Close;
                window.Show();
            }
            else
            {
                Close();
            }

        }

        private void Close(object sender, EventArgs args)
        {
            Window.Close();
        }
        private void Close()
        {
            Window.Close();
        }
    }
}
