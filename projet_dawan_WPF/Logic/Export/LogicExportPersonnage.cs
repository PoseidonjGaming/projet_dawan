using Microsoft.Win32;
using Newtonsoft.Json;
using projet_dawan_WPF.Windows.Autre;
using projet_dawan_WPF.Windows.Export;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System;
using System.IO;
using System.Windows;

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
        }

        public void BtnExport_Click()
        {
            if (Window.Owner.GetType() == typeof(WindowExportSerie))
            {
                if (Window.Owner.Owner.GetType() == typeof(WindowExportEpisode))
                {
                    foreach(Episode episode in Properties.Settings.Default.ExportEpisode)
                    {
                        Properties.Settings.Default.ExportPersonnage = episode.Saison.Serie.Personnages;
                        ExportActeur();
                        episode.Saison.Serie.Personnages = Properties.Settings.Default.ExportPersonnage;
                    }
                }
                else if(Window.Owner.Owner.GetType()==typeof(WindowImportExport))
                {
                    foreach(Serie serie in Properties.Settings.Default.ExportSerie)
                    {
                        foreach(Personnage perso in serie.Personnages)
                        {
                            perso.ShouldExportSerie= false;
                        }
                        Properties.Settings.Default.ExportPersonnage = serie.Personnages;
                        ExportActeur();
                        serie.Personnages=Properties.Settings.Default.ExportPersonnage;
                    }
                }
            }
            Window.Close();
        }

        private void ExportActeur()
        {
            if ((bool)Window.checkBoxPerso_Acteur.IsChecked)
            {
                ActeurService service = new();
                foreach(Personnage perso in Properties.Settings.Default.ExportPersonnage)
                {
                    perso.ShouldExportActeur = true;
                    perso.Acteur = service.GetById(perso.ActeurId);
                }
            }
        }

        private void ExportSerie()
        {
           
        }


        private void Close(object sender, EventArgs e)
        {
            Window.Close();
        }
    }
}
