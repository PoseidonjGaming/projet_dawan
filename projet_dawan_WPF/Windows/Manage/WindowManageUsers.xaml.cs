using projet_dawan_WPF.Logic;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Security.Cryptography;
using System.Windows;
using System.Windows.Documents;

namespace projet_dawan_WPF.Window.Manage
{
    /// <summary>
    /// Logique d'interaction pour WindowManageUsers.xaml
    /// </summary>
    public partial class WindowManageUsers : System.Windows.Window
    {
        private LogicManageUsers logic;
        public WindowManageUsers()
        {
            InitializeComponent();
            logic = new(this);
            logic.Load();
        }

        private void btnAdd_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            logic.BtnAdd_Click();
        }

        private void btnCancel_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            logic.BtnCancel_Click();
        }

        private void btnDelete_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            logic.BtnDelete_Click();
        }

        private void lstBoxUsers_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            logic.LstBoxUsers_SelectionChanged();
        }

       
    }
}
