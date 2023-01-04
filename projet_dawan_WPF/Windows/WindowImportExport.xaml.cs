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
    /// Logique d'interaction pour WindowImportExport.xaml
    /// </summary>
    public partial class WindowImportExport :System.Windows.Window
    {
        public WindowImportExport()
        {
            InitializeComponent();
        }

        private void btnExport_Click(object sender, RoutedEventArgs e)
        {
            bool shouldPeso = (bool)checkBoxShouldPersonnage.IsChecked;
            bool eachPerso_Acteur=(bool) chackBoxPerso_Acteur.IsChecked;
            if(checkBoxSerie.IsChecked == true)
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
                    SerieService serieService= new SerieService();
                    PersonnageService personnageService=new PersonnageService();
                    List<Serie> list = serieService.GetAll();
                    foreach (Serie serie in list)
                    {
                        serie.ShouldSerializePersonnage = shouldPeso;
                        if(shouldPeso)
                        {
                            serie.Personnages = personnageService.GetBySerie(serie.Id);
                            if(eachPerso_Acteur)
                            {
                                ActeurService acteurService=new ActeurService();
                                foreach(Personnage personnage in serie.Personnages)
                                {
                                    personnage.ShouldSerializeActeurs = eachPerso_Acteur;
                                    personnage.Acteur=acteurService.GetById(personnage.ActeurId);
                                }
                            }
                        }
                        serie.ShouldSerializeSaisons = false;
                    }
                    File.WriteAllText(save.FileName, JsonConvert.SerializeObject(list, Formatting.Indented));

                }
            }
        }
    }
}
