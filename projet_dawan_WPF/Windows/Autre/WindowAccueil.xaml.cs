using projet_dawan_WPF.Logic.Autre;
using System.Windows;
using System.Windows.Input;

namespace projet_dawan_WPF.Windows.Autre
{
    /// <summary>
    /// Logique d'interaction pour WindowAccueil.xaml
    /// </summary>
    public partial class WindowAccueil : Window
    {
        private LogicAccueil logic;
        public WindowAccueil()
        {
            InitializeComponent();
            logic = new(this);
            logic.Load();
        }
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            logic.Search_Click();
        }

        private void menuItemBibli_Click(object sender, RoutedEventArgs e)
        {
            logic.Biblio_Click();
        }

        private void menuItemActeurs_Click(object sender, RoutedEventArgs e)
        {
            logic.GererLesActeurs_Click();
        }

        private void menuItemSeConnecter_Click(object sender, RoutedEventArgs e)
        {
            logic.SeConnecterToolStripMenuItem_Click();
        }

        private void menuItemWatchlist_Click(object sender, RoutedEventArgs e)
        {
            logic.WatchList_Click();
        }

        private void menuItemSeries_Click(object sender, RoutedEventArgs e)
        {
            logic.ToolStripAddSerie_Click();
        }

        private void menuItemEpisodes_Click(object sender, RoutedEventArgs e)
        {
            logic.ManageEpisodeToolStripMenuItem_Click();
        }

        private void menuItemPersonnages_Click(object sender, RoutedEventArgs e)
        {
            logic.GererPersonnagesToolStripMenuItem_Click();
        }

        private void menuItemUsers_Click(object sender, RoutedEventArgs e)
        {
            logic.GererLesUsers_Click();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            logic.Quitter_Click();
        }

        private void menuItemImport_Export_Click(object sender, RoutedEventArgs e)
        {
            logic.MenuItemImport_Export_Click();
        }

        private void txtRechercher_KeyDown(object sender, KeyEventArgs e)
        {
            logic.TxtRechercher_KeyUp(e);
        }
    }
}
