﻿using Microsoft.Win32;
using Newtonsoft.Json;
using projet_dawan_WPF.Windows.Export;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
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
            if (Window.Owner.GetType() == typeof(WindowExportPersonnage))
            {

            }
        }
        public void BtnExport_Click()
        {
            if (Window.Owner.GetType() == typeof(WindowExportPersonnage))
            {

            }
            else if(Window.Owner.GetType() == typeof(WindowImportExport))
            {
                ActeurService service = new();
                Properties.Settings.Default.ExportActeur = service.GetAll();
                ExportPersonnage();
                Window.Close();
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

                WindowExportPersonnage window = new()
                {
                    Owner = Window
                };
                window.ShowDialog();
            }
        }

        
    }
}
