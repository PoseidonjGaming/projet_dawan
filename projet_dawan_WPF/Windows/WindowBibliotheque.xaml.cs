using projet_dawan_WPF.Logic;
using System.Windows;
using System.Windows.Controls;

namespace projet_dawan_WPF.Windows
{
    /// <summary>
    /// Logique d'interaction pour WindowBibliotheque.xaml
    /// </summary>
    public partial class WindowBibliotheque : Window
    {
        private LogicBibliothèque logic;
        public WindowBibliotheque(string text, Window windows)
        {
            InitializeComponent();
            this.Owner = windows;
            logic = new(this);
            logic.Load(text);
        }

        private void txtRechercher_TextChanged(object sender, TextChangedEventArgs e)
        {
            logic.ChangeText();
        }

        private void cmbFiltrer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            logic.CmbFiltrer_SelectedIndexChanged();
        }

        private void btnRetour_Click(object sender, RoutedEventArgs e)
        {
            logic.BtnRetour_Click();
        }

        private void btnDetail_Click(object sender, RoutedEventArgs e)
        {
            logic.Detail();
        }
    }
}
