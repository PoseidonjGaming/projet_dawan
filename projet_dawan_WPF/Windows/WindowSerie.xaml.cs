using Microsoft.EntityFrameworkCore.Metadata.Internal;
using projet_dawan_WPF.Logic;
using SerieDLL_EF.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Logique d'interaction pour WindowSerie.xaml
    /// </summary>
    public partial class WindowSerie : Window
    {
        private LogicSerie logic;
        public WindowSerie(Serie serie)
        {
            InitializeComponent();
            logic = new(this);
            logic.Load(serie);
        }

        private void buttonToWatch_Click(object sender, RoutedEventArgs e)
        {
            logic.ButtonToWatch_Click();
        }

        private void btnCasting_Click(object sender, RoutedEventArgs e)
        {
            logic.BtnCasting_Click();
        }

        private void lstBoxSaison_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            logic.LstBoxSaison_SelectedIndexChanged();
        }
    }
}
