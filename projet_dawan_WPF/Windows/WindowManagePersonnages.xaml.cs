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
    /// Logique d'interaction pour WindowsManagePersonnages.xaml
    /// </summary>
    public partial class WindowManagePersonnages : Window
    {
        private LogicManagePerso logic;
        public WindowManagePersonnages()
        {
            InitializeComponent();
            logic = new(this);
            logic.Load();
        }

        public void btnAjouter_Click(object sender, RoutedEventArgs e)
        {
            logic.BtnAjouter_Click();
        }

        public void btnAnnuler_Click(object sender, RoutedEventArgs e)
        {
            
        }

        public void btnSup_Click(object sender, RoutedEventArgs e)
        {
            logic.BtnSuppr_Click();
        }

        private void listBoxPerso_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            logic.ListBoxPerso_SelectedIndexChanged();
        }
    }
}
