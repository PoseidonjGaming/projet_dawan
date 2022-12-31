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
    /// Logique d'interaction pour WindowManageActeur.xaml
    /// </summary>
    
    public partial class WindowManageActeur : Window
    {
        private LogicManageActeur logic;

        public WindowManageActeur()
        {
            InitializeComponent();
            logic = new(this);
            logic.Load();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            logic.Add_Cick();
        }

        private void btnSup_Click(object sender, RoutedEventArgs e)
        {
            logic.Sup_Click();
        }

        private void lstBoxActeur_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            logic.SelectIndexChanged();
        }
    }
}
