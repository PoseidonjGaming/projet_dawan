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
    /// Logique d'interaction pour WindowManageEpisodes.xaml
    /// </summary>
    public partial class WindowManageEpisodes : Window
    {
        private LogicManageEpisode logic;
        public WindowManageEpisodes()
        {
            InitializeComponent();
            logic = new(this);
            logic.Load();
        }

        private void btnAddNum_Click(object sender, RoutedEventArgs e)
        {
            logic.BtnAddNum_Click();
            
        }

        private void btnSupNum_Click(object sender, RoutedEventArgs e)
        {
            logic.BtnSupNum_Click();
        }

        private void TextBox_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            
        }

        private void btnAjouter_Click(object sender, RoutedEventArgs e)
        {
            logic.BtnAjouter_Click();
        }

        private void btnAnnuler_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnSup_Click(object sender, RoutedEventArgs e)
        {
            logic.BtnSup_Click();
        }

        private void lstBoxEpisode_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            logic.LstBoxEpisode_SelectedIndexChanged();
        }

        
    }
}
