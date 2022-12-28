using projet_dawan_WPF.Logic;
using System.Windows;
namespace projet_dawan_WPF.Windows
{
    /// <summary>
    /// Logique d'interaction pour WindowsConnection.xaml
    /// </summary>
    public partial class WindowConnection : Window
    {
        private LogicMain logic;
        public WindowConnection()
        {
            InitializeComponent();
            logic = new(this);
        }

        private void btnConnexion_Click(object sender, RoutedEventArgs e)
        {
            logic.BtnConnexion_Click();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            logic.Load();
        }
    }
}
