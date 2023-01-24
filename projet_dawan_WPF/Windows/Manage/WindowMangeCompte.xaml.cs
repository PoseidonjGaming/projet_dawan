using projet_dawan_WPF.Logic.Manage;
using projet_dawan_WPF.Windows.Autre;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
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
    /// Logique d'interaction pour WindowMangeUser.xaml
    /// </summary>
    public partial class WindowMangeCompte : Window
    {
        private LogicManageUser logic;
        
        public WindowMangeCompte()
        {
            InitializeComponent();
            logic = new(this);
        }

        private void btnModif_Click(object sender, RoutedEventArgs e)
        {
            logic.BtnModif_Click();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            logic.Load();
        }

        private void Close(object sender, EventArgs e)
        {
            txtBoxPassword.Password = string.Empty;
            txtBoxPasswordConfirm.Password = string.Empty;
        }
    }
}
