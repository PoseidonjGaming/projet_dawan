using Microsoft.Win32;
using Newtonsoft.Json;
using projet_dawan_WPF.Windows.Autre;
using projet_dawan_WPF.Windows.Export;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Documents;

namespace projet_dawan_WPF.Logic.Export
{
    internal class LogicExportSerie
    {
        public WindowExportSerie Window { get; set; }
        private readonly SerieService service = new();

        public LogicExportSerie(WindowExportSerie window)
        {
            Window = window;
        }

        public void Load()
        {
            if (Window.Owner.GetType() == typeof(WindowExportEpisode))
            {
                Window.checkBoxEp.IsEnabled = false;
            }
            else if (Window.Owner.GetType() == typeof(WindowExportPersonnage))
            {
                Window.checkBoxShouldPersonnage.IsEnabled = false;
            }
        }

        public void BtnExport_Click()
        {
            if (Window.Owner.GetType() == typeof(WindowImportExport))
            {
                Properties.Settings.Default.ExportSerie = service.GetAll();
                ExportSaison();
                ExportPerso();
            }
            else if(Window.Owner.GetType() == typeof(WindowExportPersonnage))
            {
                ExportSaison();
                Window.Close();
            }
        }

        private void ExportPerso()
        {
            if ((bool)Window.checkBoxShouldPersonnage.IsChecked)
            {
                PersonnageService personnageService = new();
                foreach (Serie serie in Properties.Settings.Default.ExportSerie)
                {
                    serie.ShouldExportPersonnage = true;
                    serie.Personnages = personnageService.GetBySerie(serie.Id);
                }
                WindowExportPersonnage window = new()
                {
                    Owner = Window
                };
                window.ShowDialog();
                Window.Close();
            }
        }

        private void Window_Close(object sender, EventArgs e)
        {
            Window.Close();
        }


        private void ExportEpisode()
        {
            if ((bool)Window.checkBoxEp.IsChecked)
            {
                EpisodeService episodeService = new();
                foreach (Saison saison in Properties.Settings.Default.ExportSaison)
                {
                    saison.ShouldExportSerie = false;
                    saison.ShouldExportEpisode = true;
                    saison.Episodes = episodeService.GetBySaison(saison.Id);
                }
            }

        }

        private void ExportSaison()
        {
            SaisonService saisonService = new();
            foreach (Serie serie in Properties.Settings.Default.ExportSerie)
            {
                serie.ShouldExportSaison = true;
                serie.Saisons = saisonService.GetSaisonsBySerie(serie.Id);
                Properties.Settings.Default.ExportSaison = serie.Saisons;
                ExportEpisode();
                serie.Saisons = Properties.Settings.Default.ExportSaison;

            }
        }

    }
}
