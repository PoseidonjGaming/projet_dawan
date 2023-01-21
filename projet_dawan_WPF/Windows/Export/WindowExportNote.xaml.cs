using projet_dawan_WPF.Logic.Export;
using System.Windows;

namespace projet_dawan_WPF.Windows.Export
{
    /// <summary>
    /// Logique d'interaction pour WindowExportNote.xaml
    /// </summary>
    public partial class WindowExportNote : Window
    {
        private LogicExportNote logic;
        public WindowExportNote()
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
