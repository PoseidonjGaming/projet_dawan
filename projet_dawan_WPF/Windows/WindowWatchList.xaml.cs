using projet_dawan_WPF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace projet_dawan_WPF.Windows
{
    /// <summary>
    /// Logique d'interaction pour WindowWatchList.xaml
    /// </summary>
    public partial class WindowWatchList : Window
    {
        private LogicWatchList logic;
        public WindowWatchList()
        {
            InitializeComponent();
            logic = new(this);
            logic.Load();
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            logic.Import();
        }

        private void btnExportList_Click(object sender, RoutedEventArgs e)
        {
            logic.BtnExportList_Click();
        }

        private void btnClearAll_Click(object sender, RoutedEventArgs e)
        {
            logic.BtnClearAll_Click();
        }
    }
}
