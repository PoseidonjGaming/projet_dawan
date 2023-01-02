using projet_dawan_WPF.Logic;
using System.Windows;

namespace projet_dawan_WPF.Windows
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            logic.Deco_Click();
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
            logic.gererPersonnagesToolStripMenuItem_Click();
        }
    }
}
