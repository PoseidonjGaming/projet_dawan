using Microsoft.Win32;
using Newtonsoft.Json;
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
            PersonnageService personnageService = new();
            if (Owner.GetType() == typeof(WindowExportSerie))
            {
                foreach (Serie serie in Properties.Settings.Default.ExportSerie)
                {
                    serie.ShouldSerializePersonnage = true;
                    serie.Personnages = personnageService.GetBySerie(serie.Id);
                    serie.Personnages = ExportActeur(serie.Personnages.ToList());

                }
                this.Close();
            }
            else
            {
                List<Personnage> perso=personnageService.GetAll();
                perso=ExportActeur(perso.ToList());
                SaveFileDialog save = new SaveFileDialog()
                {
                    InitialDirectory = Directory.GetCurrentDirectory(),
                    FileName = "exports.json",
                    Filter = "File JSON|*json",
                    Title = "Save WatchList"
                };

                if ((bool)save.ShowDialog())
                {
                    File.WriteAllText(save.FileName, JsonConvert.SerializeObject(perso, Formatting.Indented));
                }

                this.Close();
            }
            
            
            
            
        }

        private List<Personnage> ExportActeur(List<Personnage> list)
        {
            if ((bool)chackBoxPerso_Acteur.IsChecked)
            {
                ActeurService acteurService = new();
                foreach (Personnage perso in list)
                {
                    perso.ShouldSerializeActeurs = true;
                    perso.Acteur = acteurService.GetById(perso.ActeurId);
                }
            }

            return list;
        }
    }
}
