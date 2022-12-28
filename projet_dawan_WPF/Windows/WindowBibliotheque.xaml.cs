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
    /// Logique d'interaction pour WindowBibliotheque.xaml
    /// </summary>
    public partial class WindowBibliotheque : Window
    {
        private LogicBibliothèque logic;
        public WindowBibliotheque(string text, Window windows)
        {
            InitializeComponent();
            this.Owner= windows;
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
