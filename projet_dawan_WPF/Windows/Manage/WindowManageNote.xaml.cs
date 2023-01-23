using projet_dawan_WPF.Logic.Manage;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
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

namespace projet_dawan_WPF.Windows.Manage
{
    /// <summary>
    /// Logique d'interaction pour WindowManageNote.xaml
    /// </summary>
    public partial class WindowManageNote : Window
    {
        private LogicManageNote logic;
       
        public WindowManageNote()
        {
            InitializeComponent();
            logic = new(this);
            
        }

        private void btnAjouter_Click(object sender, RoutedEventArgs e)
        {
            logic.BtnAjouter_Click();
        }

        private void btnAnnuler_Click(object sender, RoutedEventArgs e)
        {
            logic.BtnAnnuler_Click();
        }

        private void btnSup_Click(object sender, RoutedEventArgs e)
        {
            logic.BtnSup_Click();
        }

        private void lstBoxNote_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            logic.LstBoxNote_SelectionChanged();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           logic.Load();
        }
        
        private void txtBoxNote_KeyDown(object sender, KeyEventArgs e)
        {
            logic.TxtBoxNote_KeyDown(e.Key);
        }

        private void txtBoxNote_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            logic.TxtBoxNote_MouseWheel(e.Delta);
        }
    }
}
