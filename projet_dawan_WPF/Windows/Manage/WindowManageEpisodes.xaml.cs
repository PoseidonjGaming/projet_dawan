using projet_dawan_WPF.Logic.Manage;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace projet_dawan_WPF.Windows.Manage
{
    /// <summary>
    /// Logique d'interaction pour WindowManageEpisodes.xaml
    /// </summary>
    public partial class WindowManageEpisodes : System.Windows.Window
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
            logic.TextBox_MouseWheel(e.Delta);
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

        private void lstBoxEpisode_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            logic.LstBoxEpisode_SelectedIndexChanged();
        }


    }
}
