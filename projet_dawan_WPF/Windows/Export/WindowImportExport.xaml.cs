using Microsoft.Win32;
using Newtonsoft.Json;
using projet_dawan_WPF.Logic.Export;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Printing;
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
            logic.BtnImport_Episodes_Click() ;
        }

        private void btnImport_Personnages_Click(object sender, RoutedEventArgs e)
        {
            logic.BtnImport_Personnages_Click();
        }

        private void btnImport_Acteur_Click(object sender, RoutedEventArgs e)
        {
            logic.BtnImport_Acteur_Click();
        }

        


    }
}
