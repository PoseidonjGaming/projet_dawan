using Microsoft.Win32;
using Newtonsoft.Json;
using projet_dawan_WPF.Logic.Export;
using SerieDLL_EF.Models;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace projet_dawan_WPF.Windows.Export
{
    /// <summary>
    /// Logique d'interaction pour WindowImportExport.xaml
    /// </summary>
    public partial class WindowImportExport : Window
    {

        private LogicImportExport logic;

        public WindowImportExport()
        {
            InitializeComponent();
            logic = new(this);
        }

        private void btnExport_Click(object sender, RoutedEventArgs e)
        {
            logic.BtnExport_Click();
        }


        private void btnImport_Serie_Click(object sender, RoutedEventArgs e)
        {
            logic.BtnImport_Serie_Click();
        }

        private void btnImport_Episodes_Click(object sender, RoutedEventArgs e)
        {
            logic.BtnImport_Episodes_Click();
        }

        private void btnImport_Personnages_Click(object sender, RoutedEventArgs e)
        {
            logic.BtnImport_Personnages_Click();
        }

        private void btnImport_Acteur_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new();
            if (fileDialog.ShowDialog() == true)
            {
                try
                {
                    Properties.Settings.Default.ExportActeur = JsonConvert.DeserializeObject<List<Acteur>>(File.ReadAllText(fileDialog.FileName));
                    ImportActeur();
                }
                catch
                {

                }
            }
        }

        private void ImportSerie()
        {

        }

        private void ImportPersonnages()
        {


        }

        private void ImportActeur()
        {

        }

        private void ImportEpisode()
        {

        }

        private void ImportSaison()
        {

        }


    }
}
