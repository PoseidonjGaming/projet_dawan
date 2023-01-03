using SerieDLL_EF.Service;

namespace projet_dawan_WPF.Window
{
    /// <summary>
    /// Logique d'interaction pour WindowManageUsers.xaml
    /// </summary>
    public partial class WindowManageUsers : System.Windows.Window
    {
        private UserService service;
        public WindowManageUsers()
        {
            InitializeComponent();

            cmbBoxRoles.Items.Add("User");
            cmbBoxRoles.Items.Add("Admin");
            cmbBoxRoles.Items.Add("SuperAdmin");
        }

        private void btnAdd_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }

        private void lstBoxUsers_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}
