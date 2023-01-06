using Microsoft.Win32;
using Newtonsoft.Json;
using projet_dawan_WPF.Windows.Export;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System.IO;

namespace projet_dawan_WPF.Logic.Export
{
    internal class LogicExportActeur
    {
        public WindowExportActeur Window { get; set; }

        public LogicExportActeur(WindowExportActeur window)
        {
            Window = window;
        }

        public void BtnExport_Click()
        {
            ActeurService service = new();
            Properties.Settings.Default.ExportActeur = service.GetAll();
            ExportPersonnage();
            Export();
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

        private void Export()
        {
            SaveFileDialog save = new SaveFileDialog()
            {
                InitialDirectory = Directory.GetCurrentDirectory(),
                FileName = "exports.json",
                Filter = "File JSON|*json",
                Title = "Save WatchList"
            };

            if ((bool)save.ShowDialog())
            {
                File.WriteAllText(save.FileName, JsonConvert.SerializeObject(Properties.Settings.Default.ExportActeur, Formatting.Indented));
            }
        }
    }
}
