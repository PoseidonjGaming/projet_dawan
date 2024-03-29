﻿using projet_dawan_WPF.Logic.Autre;
using projet_dawan_WPF.Windows.Export;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System;
using System.Collections.Generic;
using System.Windows.Documents;

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
            if (Window.Owner.GetType() == typeof(WindowImportExport))
            {
                PersonnageService service = new();
                Properties.Settings.Default.ExportPersonnage = service.GetAll();
                ExportActeur();
                ExportSerie();
                OpenWindowSerie();
            }
            else if (Window.Owner.GetType() == typeof(WindowExportSerie))
            {
                if (Window.Owner.Owner.GetType() == typeof(WindowExportEpisode))
                {
                    foreach (Episode episode in Properties.Settings.Default.ExportEpisode)
                    {
                        Properties.Settings.Default.ExportPersonnage = episode.Saison.Serie.Personnages;
                        ExportActeur();
                        episode.Saison.Serie.Personnages = Properties.Settings.Default.ExportPersonnage;
                    }
                }
                else if (Window.Owner.Owner.GetType() == typeof(WindowImportExport))
                {
                    foreach (Serie serie in Properties.Settings.Default.ExportSerie)
                    {
                        serie.Personnages = DownExportSerie(serie.Personnages);
                        Properties.Settings.Default.ExportPersonnage = serie.Personnages;
                        ExportActeur();
                        serie.Personnages = Properties.Settings.Default.ExportPersonnage;
                    }
                }
                else if(Window.Owner.Owner.GetType()==typeof(WindowExportNote))
                {
                    foreach(Note note in Properties.Settings.Default.ExportNote)
                    {
                        note.Serie.Personnages = DownExportSerie(note.Serie.Personnages);
                        Properties.Settings.Default.ExportPersonnage=note.Serie.Personnages;
                        ExportActeur();
                        note.Serie.Personnages = Properties.Settings.Default.ExportPersonnage;
                    }
                }
            }
            else if (Window.Owner.GetType() == typeof(WindowExportActeur))
            {
                PersonnageService service = new();
                foreach (Acteur acteur in Properties.Settings.Default.ExportActeur)
                {
                    foreach (Personnage perso in acteur.Personnages)
                    {
                        perso.ShouldExportActeur = false;
                    }
                    Properties.Settings.Default.ExportPersonnage = acteur.Personnages;
                    ExportSerie();
                    acteur.Personnages = Properties.Settings.Default.ExportPersonnage;
                }
                OpenWindowSerie();
            }
            Window.Close();
        }

        private List<Personnage> DownExportSerie(List<Personnage> list)
        {
            foreach (Personnage perso in list)
            {
                perso.ShouldExportSerie = false;
            }
            return list;
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

        private void OpenWindowSerie()
        {
            if ((bool)Window.checkBoxPerso_Serie.IsChecked)
            {
                WindowExportSerie window = new()
                {
                    Owner = Window
                };
                window.Closed += Close;
                window.ShowDialog();
            }
        }


        private void Close(object sender, EventArgs e)
        {
            Window.Close();
        }
    }
}
