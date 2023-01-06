using projet_dawan_WPF.Logic.Export;
using projet_dawan_WPF.Windows.Export;
using System.Windows;

namespace projet_dawan_WPF.Windows.Export
{
    /// <summary>
    /// Logique d'interaction pour WindowExportSerie.xaml
    /// </summary>
    public partial class WindowExportSerie : System.Windows.Window
    {
        private LogicExportSerie logic;
        public WindowExportSerie()
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
