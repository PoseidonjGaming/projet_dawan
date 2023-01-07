﻿using Microsoft.Win32;
using Newtonsoft.Json;
using projet_dawan_WPF.Windows.Autre;
using projet_dawan_WPF.Windows.Export;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System;
using System.IO;

namespace projet_dawan_WPF.Logic.Export
{
    internal class LogicExportPersonnage
    {
        public WindowExportPersonnage Window { get; set; }

        public LogicExportPersonnage(WindowExportPersonnage window)
        {
            Window = window;
        }

        public void Load()
        {
            if (Window.Owner.GetType() == typeof(WindowExportSerie))
            {
                Window.checkBoxPerso_Serie.IsEnabled = false;
            }
            else if (Window.Owner.GetType() == typeof(WindowExportActeur))
            {
                Window.checkBoxPerso_Acteur.IsEnabled = false;
            }
        }

        public void BtnExport_Click()
        {
            PersonnageService service = new();
            if (Window.Owner.GetType() == typeof(WindowImportExport))
            {
                Properties.Settings.Default.ExportPersonnage = service.GetAll();
                ExportActeur();
                ExportSerie();
                Window.Close();
            }
            else if (Window.Owner.GetType() == typeof(WindowExportSerie))
            {
                if (Window.Owner.Owner.GetType() == typeof(WindowExportEpisode))
                {
                    foreach (Episode ep in Properties.Settings.Default.ExportEpisode)
                    {
                        Properties.Settings.Default.ExportPersonnage = ep.Saison.Serie.Personnages;
                        ExportActeur();
                        ep.Saison.Serie.Personnages = Properties.Settings.Default.ExportPersonnage;
                    }

                    Window.Close();

                }
                else if (Window.Owner.Owner.GetType() == typeof(WindowImportExport))
                {
                    foreach (Serie serie in Properties.Settings.Default.ExportSerie)
                    {
                        Properties.Settings.Default.ExportPersonnage = serie.Personnages;
                        ExportActeur();
                        serie.Personnages = Properties.Settings.Default.ExportPersonnage;
                    }
                    Window.Close();
                }

            }
            else if (Window.Owner.GetType() == typeof(WindowExportActeur))
            {
                foreach (Acteur acteur in Properties.Settings.Default.ExportActeur)
                {
                    Properties.Settings.Default.ExportPersonnage = acteur.Personnages;
                    ExportSerie();
                    acteur.Personnages = Properties.Settings.Default.ExportPersonnage;
                }
                WindowExportSerie window = new()
                {
                    Owner = Window,
                };
                window.Closed += Close;
                window.ShowDialog();

            }
        }

        private void ExportActeur()
        {
            if ((bool)Window.checkBoxPerso_Acteur.IsChecked)
            {
                ActeurService service = new();
                foreach (Personnage perso in Properties.Settings.Default.ExportPersonnage)
                {
                    perso.ShouldExportActeur = true;
                    perso.Acteur = service.GetById(perso.ActeurId);
                    perso.Acteur.ShouldExportPersonnage = false;
                }
            }
        }

        private void ExportSerie()
        {
            if ((bool)Window.checkBoxPerso_Serie.IsChecked)
            {
                SerieService service = new();
                foreach (Personnage perso in Properties.Settings.Default.ExportPersonnage)
                {
                    perso.ShouldExportSerie = true;
                    perso.Serie = service.GetById(perso.SerieId);
                }
            }
        }


        private void Close(object sender, EventArgs e)
        {
            Window.Close();
        }
    }
}
