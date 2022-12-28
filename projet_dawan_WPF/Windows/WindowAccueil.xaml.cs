using projet_dawan_WPF.Logic;
using System;
using System.Collections.Generic;
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
    }
}
