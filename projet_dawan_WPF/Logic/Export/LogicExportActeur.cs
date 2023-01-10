using Azure.Identity;
using Microsoft.Win32;
using Newtonsoft.Json;
using projet_dawan_WPF.Windows.Export;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System;
using System.IO;
using System.Windows.Documents;

namespace projet_dawan_WPF.Logic.Export
{
    internal class LogicExportActeur
    {
        public WindowExportActeur Window { get; set; }

        public LogicExportActeur(WindowExportActeur window)
        {
            Window = window;
        }

        public void Load()
        {

        }
        public void BtnExport_Click()
        {
            if (Window.Owner.GetType() == typeof(WindowImportExport))
            {
                ActeurService service = new();
                Properties.Settings.Default.ExportActeur = service.GetAll();
                ExportPersonnage();
                OpenWindowPersonnage();
            }
        }

        private void OpenWindowPersonnage()
        {
            if ((bool)Window.checkBoxPerso.IsChecked)
            {
                WindowExportPersonnage window = new()
                {
                    Owner = Window
                };
                window.Closed += Close;
                window.ShowDialog();
            }
            else
            {
                Close();
            }
        }

        private void ExportPersonnage()
        {
            if ((bool)Window.checkBoxPerso.IsChecked)
            {
                PersonnageService service = new();
                foreach (Acteur acteur in Properties.Settings.Default.ExportActeur)
                {
                    acteur.ShouldExportPersonnage = true;
                    acteur.Personnages = service.GetByActeur(acteur.Id);
                }
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
