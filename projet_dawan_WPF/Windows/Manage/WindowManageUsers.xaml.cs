using projet_dawan_WPF.Logic.Manage;
using System.Windows;

namespace projet_dawan_WPF.Windows.Manage
{
    /// <summary>
    /// Logique d'interaction pour WindowManageUsers.xaml
    /// </summary>
    public partial class WindowManageUsers : Window
    {
        private LogicManageUsers logic;
        public WindowManageUsers()
        {
            InitializeComponent();
            logic = new(this);
            logic.Load();
        }

        private void btnAdd_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            logic.BtnAdd_Click();
        }

        private void btnCancel_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            logic.BtnCancel_Click();
        }

        private void btnDelete_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            logic.BtnDelete_Click();
        }

        private void lstBoxUsers_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            logic.LstBoxUsers_SelectionChanged();
        }


    }
}
