using projet_dawan_WPF.Logic.Manage;
using System.Windows;
using System.Windows.Controls;

namespace projet_dawan_WPF.Windows.Manage
{
    /// <summary>
    /// Logique d'interaction pour WindowManageActeur.xaml
    /// </summary>

    public partial class WindowManageActeur : System.Windows.Window
    {
        private LogicManageActeur logic;

        public WindowManageActeur()
        {
            InitializeComponent();
            logic = new(this);
            logic.Load();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            logic.Add_Cick();
        }

        private void btnSup_Click(object sender, RoutedEventArgs e)
        {
            logic.Sup_Click();
        }

        private void lstBoxActeur_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            logic.SelectIndexChanged();
        }

        private void btnNewActeur_Click(object sender, RoutedEventArgs e)
        {
            logic.BtnNewActeur_Click();
        }
    }
}
