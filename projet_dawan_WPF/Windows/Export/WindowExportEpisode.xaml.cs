using projet_dawan_WPF.Logic.Export;
using System.Windows;

namespace projet_dawan_WPF.Windows.Export
{
    /// <summary>
    /// Logique d'interaction pour WindowExportEpisode.xaml
    /// </summary>
    public partial class WindowExportEpisode : System.Windows.Window
    {
        private LogicExportEpisode logic;
        public WindowExportEpisode()
        {
            InitializeComponent();
            logic = new(this);
        }

        private void btnExport_Click(object sender, RoutedEventArgs e)
        {
            logic.BtnExport_Click();
        }


    }
}
