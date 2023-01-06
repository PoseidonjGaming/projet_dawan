using Microsoft.Win32;
using Newtonsoft.Json;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System.IO;
using System.Windows;

namespace projet_dawan_WPF.Windows.Export
{
    /// <summary>
    /// Logique d'interaction pour WindowExportActeur.xaml
    /// </summary>
    public partial class WindowExportActeur : System.Windows.Window
    {
        public WindowExportActeur()
        {
            InitializeComponent();
        }

        private void btnExport_Click(object sender, RoutedEventArgs e)
        {
            ActeurService service = new();
            Properties.Settings.Default.ExportActeur = service.GetAll();
            ExportPersonnage();
            Export();
        }

        private void ExportPersonnage()
        {
            if ((bool)checkBoxPerso.IsChecked)
            {
                PersonnageService service = new();
                foreach (Acteur acteur in Properties.Settings.Default.ExportActeur)
                {
                    acteur.ShouldExportPersonnage = true;
                    acteur.Personnages = service.GetByActeur(acteur.Id);
                }

                WindowExportPersonnage window = new()
                {
                    Owner = this
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
