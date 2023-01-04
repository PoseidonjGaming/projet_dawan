using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Security.Cryptography;
using System.Windows;
using System.Windows.Documents;

namespace projet_dawan_WPF.Window
{
    /// <summary>
    /// Logique d'interaction pour WindowManageUsers.xaml
    /// </summary>
    public partial class WindowManageUsers : System.Windows.Window
    {
        private UserService service = new();
        private List<UserApp> userList = new();
        private List<Roles> rolesList = new() { Roles.User, Roles.Admin, Roles.SuperAdmin };
        public WindowManageUsers()
        {
            InitializeComponent();

            foreach (Roles role in rolesList)
            {
                cmbBoxRoles.Items.Add(role.ToString());
            }

            userList = service.GetAll();
            foreach (UserApp user in userList)
            {
                lstBoxUsers.Items.Add(user.Login);
            }
        }

        private void btnAdd_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            
            if (txtBoxLogin.Text!=string.Empty && txtBoxPWD.Text!=string.Empty && txtBoxPWDConfirm.Text!=string.Empty)
            {
                if(txtBoxPWD.Text==txtBoxPWDConfirm.Text)
                {
                    if (lstBoxUsers.SelectedIndex != -1)
                    {
                        UserApp user = userList[lstBoxUsers.SelectedIndex];
                        if (user.Equals(Properties.Settings.Default.UserRemain))
                        {
                            MessageBox.Show("Vous devez être connecter à un autre compte pour pouvoir modifier ce compte");
                            return;
                        }
                        
                        user.Login = txtBoxLogin.Text;
                        user.Password = txtBoxPWDConfirm.Text;

                        service.Update(user);

                    }
                    else
                    {
                        UserApp user = new()
                        {
                            Login = txtBoxLogin.Text,
                            Password = txtBoxPWDConfirm.Text,
                            Roles = rolesList[cmbBoxRoles.SelectedIndex],
                        };
                        service.Add(user);
                    }
                    Clear();
                    Populate();
                }
            }
        }

        private void btnCancel_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Clear();
        }

        private void btnDelete_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var annuler = MessageBox.Show("Etes vous sur de vouloir annuler l'ajout ?", "Annuler ajout ?",
               MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (annuler == MessageBoxResult.Yes)
            {
                service.Delete(userList[lstBoxUsers.SelectedIndex]);
            }
            Populate();
        }

        private void lstBoxUsers_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (lstBoxUsers.SelectedIndex != -1)
            {
                txtBoxLogin.Text = userList[lstBoxUsers.SelectedIndex].Login;
                cmbBoxRoles.SelectedIndex = cmbBoxRoles.Items.IndexOf(rolesList.Find(r => r.ToString() == userList[lstBoxUsers.SelectedIndex].Roles.ToString()));
            }
        }

        private void Populate()
        {
            Clear();
            lstBoxUsers.Items.Clear();
            userList = service.GetAll();
            foreach (UserApp user in userList)
            {
                lstBoxUsers.Items.Add(user.Login);
            }
        }

        private void Clear()
        {
            txtBoxLogin.Clear();
            txtBoxPWD.Clear();
            txtBoxPWDConfirm.Clear();
            cmbBoxRoles.SelectedIndex = -1;
            lstBoxUsers.SelectedIndex = -1;
        }
    }
}
