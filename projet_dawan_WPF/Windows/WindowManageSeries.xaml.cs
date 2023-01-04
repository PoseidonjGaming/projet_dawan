using projet_dawan_WPF.Logic;
using System.Windows;
using System.Windows.Controls;

namespace projet_dawan_WPF.Window
{
    /// <summary>
    /// Logique d'interaction pour WindowsManageSeries.xaml
    /// </summary>
    public partial class WindowManageSeries : System.Windows.Window
    {
        private LogicManageSerie logic;
        public WindowManageSeries()
        {
            InitializeComponent();
            logic = new(this);
            logic.Load();
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
