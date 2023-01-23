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
    public partial class WindowMangeUser : Window
    {
        private UserApp user;
        private UserService service;
        public WindowMangeUser()
        {
            InitializeComponent();
            user = Properties.Settings.Default.UserRemain;
            service = new();
        }

        private void btnModif_Click(object sender, RoutedEventArgs e)
        {
            if (txtBoxLogin.Text != string.Empty)
            {
                if (txtBoxPassword.Password != string.Empty && txtBoxPasswordConfirm.Password != string.Empty
                    && txtBoxPasswordConfirm.Password == txtBoxPassword.Password)
                {
                    if (service.HashPassword(txtBoxPassword.Password) != user.Password 
                        && service.HashPassword(txtBoxPasswordConfirm.Password) != user.Password)
                    {
                        user.Password = txtBoxPassword.Password;
                        user.Login=txtBoxLogin.Text;
                        service.Update(user);
                        Properties.Settings.Default.UserRemain = null;
                        WindowConnection window = new()
                        {
                            Owner= this
                        };
                        window.Closed += Close;
                        window.ShowDialog();
                    }
                }
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtBoxLogin.Text = user.Login;
        }

        private void Close(object sender, EventArgs e)
        {
            txtBoxPassword.Password = string.Empty;
            txtBoxPasswordConfirm.Password = string.Empty;
        }
    }
}
