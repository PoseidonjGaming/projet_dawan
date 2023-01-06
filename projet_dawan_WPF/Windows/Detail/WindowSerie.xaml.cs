using projet_dawan_WPF.Logic;
using SerieDLL_EF.Models;
using System.Windows;
using System.Windows.Controls;

namespace projet_dawan_WPF.Windows.Detail
{
    /// <summary>
    /// Logique d'interaction pour WindowSerie.xaml
    /// </summary>
    public partial class WindowSerie : System.Windows.Window
    {
        private LogicSerie logic;
        public WindowSerie(Serie serie)
        {
            InitializeComponent();
            logic = new(this);
            logic.Load(serie);
        }

        private void buttonToWatch_Click(object sender, RoutedEventArgs e)
        {
            logic.ButtonToWatch_Click();
        }

        private void btnCasting_Click(object sender, RoutedEventArgs e)
        {
            logic.BtnCasting_Click();
        }

        private void lstBoxSaison_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            logic.LstBoxSaison_SelectedIndexChanged();
        }
    }
}
