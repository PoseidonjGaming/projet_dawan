using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System;
using System.Collections.Generic;
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
            ActeurService acteurService= new();
            PersonnageService personnageService = new();
            
            foreach (Serie serie in Properties.Settings.Default.Export)
            {
                serie.ShouldSerializePersonnage = true;
                serie.Personnages = personnageService.GetBySerie(serie.Id);
                if ((bool)chackBoxPerso_Acteur.IsChecked)
                {
                    foreach (Personnage perso in serie.Personnages)
                    {
                        perso.ShouldSerializeActeurs = true;
                        perso.Acteur = acteurService.GetById(perso.ActeurId);
                    }
                }
              
            }
            this.Close();
        }
    }
}
