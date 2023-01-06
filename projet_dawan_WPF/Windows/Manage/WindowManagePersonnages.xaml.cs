using projet_dawan_WPF.Logic;
using System.Windows;
using System.Windows.Controls;

namespace projet_dawan_WPF.Window.Manage
{
    /// <summary>
    /// Logique d'interaction pour WindowsManagePersonnages.xaml
    /// </summary>
    public partial class WindowManagePersonnages : System.Windows.Window
    {
        private LogicManagePerso logic;
        public WindowManagePersonnages()
        {
            InitializeComponent();
            logic = new(this);
            logic.Load();
        }

        public void btnAjouter_Click(object sender, RoutedEventArgs e)
        {
            logic.BtnAjouter_Click();
        }

        public void btnAnnuler_Click(object sender, RoutedEventArgs e)
        {
            logic.BtnAnnuler_Click();
        }

        public void btnSup_Click(object sender, RoutedEventArgs e)
        {
            logic.BtnSuppr_Click();
        }

        private void listBoxPerso_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            logic.ListBoxPerso_SelectedIndexChanged();
        }
    }
}
