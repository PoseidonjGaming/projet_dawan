using Microsoft.Win32;
using Newtonsoft.Json;
using projet_dawan_WPF.Window;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace projet_dawan_WPF.Windows
{
    /// <summary>
    /// Logique d'interaction pour WindowExportPersonnage.xaml
    /// </summary>
    public partial class WindowExportPersonnage : System.Windows.Window
    {
        public WindowExportPersonnage()
        {
            InitializeComponent();
        }

        private void btnExport_Click(object sender, RoutedEventArgs e)
        {
            PersonnageService service = new();
            if (Owner.GetType() == typeof(WindowAccueil))
            {
                MessageBox.Show("test");
                Properties.Settings.Default.ExportPersonnage=service.GetAll();
                ExportActeur();
                ExportSerie();
                Export();
            }
            else if(Owner.GetType()==typeof(WindowExportSerie))
            {
                foreach(Serie serie in Properties.Settings.Default.ExportSerie)
                {
                    Properties.Settings.Default.ExportPersonnage = service.GetBySerie(serie.Id);
                    
                    serie.Personnages = Properties.Settings.Default.ExportPersonnage;
                }
                ExportActeur();
                this.Close();
            }
            else if(Owner.GetType()==typeof(WindowExportActeur))
            {
                foreach (Acteur acteur in Properties.Settings.Default.ExportActeur)
                {
                    Properties.Settings.Default.ExportPersonnage = service.GetByActeur(acteur.Id);
                    ExportSerie();
                    acteur.Personnages = Properties.Settings.Default.ExportPersonnage;
                }
                this.Close();
            }
        }

        private void ExportActeur()
        {
            if ((bool)checkBoxPerso_Acteur.IsChecked)
            {
                ActeurService service = new();
                foreach (Personnage perso in Properties.Settings.Default.ExportPersonnage)
                {
                    perso.ShouldSerializeActeurs = true;
                    perso.Acteur = service.GetById(perso.ActeurId);
                    //perso.Acteur.ShouldExportPersonnage = false;
                }
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (Owner.GetType() == typeof(WindowExportSerie))
            {
                checkBoxPerso_Serie.IsEnabled = false;
            }
            else if (Owner.GetType() == typeof(WindowExportActeur))
            {
                checkBoxPerso_Acteur.IsEnabled = false;
            }
        }

        private void ExportSerie()
        {
            if ((bool)checkBoxPerso_Serie.IsChecked)
            {
                SerieService service= new();
                foreach(Personnage perso in Properties.Settings.Default.ExportPersonnage)
                {
                    perso.ShouldExportSerie= true;
                    perso.Serie=service.GetById(perso.SerieId);
                }
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
                File.WriteAllText(save.FileName, JsonConvert.SerializeObject(Properties.Settings.Default.ExportPersonnage, Formatting.Indented));
            }

            this.Close();
        }
    }
}
