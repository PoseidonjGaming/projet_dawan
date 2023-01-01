using projet_dawan_WPF.Logic;
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
    /// Logique d'interaction pour WindowsManageSeries.xaml
    /// </summary>
    public partial class WindowManageSeries : Window
    {
        private LogicManageSerie logic;
        public WindowManageSeries()
        {
            InitializeComponent();
            logic = new(this);
            logic.Load();
        }

        private void btnParcourir_Click(object sender, RoutedEventArgs e)
        {
            logic.BtnParcourir_Click();
        }

        private void btnAjouter_Click(object sender, RoutedEventArgs e)
        {
            logic.BtnAjouter_Click();
        }

        private void btnAnnuler_Click(object sender, RoutedEventArgs e)
        {
            logic.BtnAnnuler_Click();
        }

        private void btnSup_Click(object sender, RoutedEventArgs e)
        {
            logic.BtnSup_Click();
        }

        private void lstBoxSerie_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            logic.LstBoxSerie_SelectedIndexChanged();
        }
    }
}
