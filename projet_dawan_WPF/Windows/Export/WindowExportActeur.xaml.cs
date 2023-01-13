using projet_dawan_WPF.Logic.Export;
using System.Windows;

namespace projet_dawan_WPF.Windows.Export
{
    /// <summary>
    /// Logique d'interaction pour WindowExportActeur.xaml
    /// </summary>
    public partial class WindowExportActeur : System.Windows.Window
    {
        private LogicExportActeur logic;
        public WindowExportActeur()
        {
            InitializeComponent();
            logic = new(this);
        }

        private void btnExport_Click(object sender, RoutedEventArgs e)
        {
            logic.BtnExport_Click();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            logic.Load();
        }
    }
}
