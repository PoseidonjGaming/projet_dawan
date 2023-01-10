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
        }

        public void BtnExport_Click()
        {
            if (Window.Owner.GetType() == typeof(WindowExportEpisode))
            {
                foreach(Episode episode in Properties.Settings.Default.ExportEpisode)
                {
                    Properties.Settings.Default.ExportSerie = new() { episode.Saison.Serie };
                    ExportPerso();
                    episode.Saison.Serie = Properties.Settings.Default.ExportSerie[0];
                }
                OpenWindowPersonnage();
                
            }
        }

        private void ExportPerso()
        {
            if((bool)Window.checkBoxShouldPersonnage.IsChecked)
            {
                PersonnageService service = new();
                foreach(Serie serie in Properties.Settings.Default.ExportSerie)
                {
                    serie.ShouldExportPersonnage = true;
                    serie.ShouldExportSaison = false;
                    serie.Personnages = service.GetBySerie(serie.Id);
                }
                

            }
        }

        private void ExportEpisode()
        {

        }

        private void ExportSaison()
        {
            
        }

        private void OpenWindowPersonnage()
        {
            WindowExportPersonnage window = new()
            {
                Owner = Window
            };
            window.Closed += Close;
            window.Show();
        }

        private void Close(object sender, EventArgs args)
        {
            Window.Close();
        }
    }
}
