using Microsoft.Win32;
using Newtonsoft.Json;
using projet_dawan_WPF.Logic;
using projet_dawan_WPF.Window;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
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
