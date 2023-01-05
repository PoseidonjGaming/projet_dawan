using projet_dawan_WPF.Window;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace projet_dawan_WPF.Logic
{
    class LogicManageUsers
    {
        private UserService service = new();
        private List<UserApp> userList = new();
        private List<Roles> rolesList = new() { Roles.User, Roles.Admin, Roles.SuperAdmin };

        public WindowManageUsers Window { get; set; }

        public LogicManageUsers(WindowManageUsers window)
        {
            Window = window;
        }

        public void Load()
        {
            foreach (Roles role in rolesList)
            {
                Window.cmbBoxRoles.Items.Add(role.ToString());
            }

            userList = service.GetAll();
            foreach (UserApp user in userList)
            {
                Window.lstBoxUsers.Items.Add(user.Login);
            }
        }

        public void BtnAdd_Click()
        {
            if (Window.txtBoxLogin.Text != string.Empty && Window.txtBoxPWD.Text != string.Empty && Window.txtBoxPWDConfirm.Text != string.Empty)
            {
                if (Window.txtBoxPWD.Text == Window.txtBoxPWDConfirm.Text)
                {
                    if (Window.lstBoxUsers.SelectedIndex != -1)
                    {
                        UserApp user = userList[Window.lstBoxUsers.SelectedIndex];
                        if (user.Equals(Properties.Settings.Default.UserRemain))
                        {
                            MessageBox.Show("Vous devez être connecter à un autre compte pour pouvoir modifier ce compte");
                            return;
                        }

                        user.Login = Window.txtBoxLogin.Text;
                        user.Password = Window.txtBoxPWDConfirm.Text;
                        user.Roles = rolesList[Window.cmbBoxRoles.SelectedIndex];

                        service.Update(user);

                    }
                    else
                    {
                        UserApp user = new()
                        {
                            Login = Window.txtBoxLogin.Text,
                            Password = Window.txtBoxPWDConfirm.Text,
                            Roles = rolesList[Window.cmbBoxRoles.SelectedIndex],
                        };
                        service.Add(user);
                    }
                    Clear();
                    Populate();
                }
            }

        }

        public void BtnCancel_Click()
        {
            Clear();
        }

        public void BtnDelete_Click()
        {
            var annuler = MessageBox.Show("Etes vous sur de vouloir annuler l'ajout ?", "Annuler ajout ?",
               MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (annuler == MessageBoxResult.Yes)
            {
                service.Delete(userList[Window.lstBoxUsers.SelectedIndex]);
            }
            Populate();
        }

        public void LstBoxUsers_SelectionChanged()
        {
            if (Window.lstBoxUsers.SelectedIndex != -1)
            {
                Window.txtBoxLogin.Text = userList[Window.lstBoxUsers.SelectedIndex].Login;
                Window.cmbBoxRoles.SelectedIndex = Window.cmbBoxRoles.Items.IndexOf(rolesList.Find(r => r.ToString() == userList[Window.lstBoxUsers.SelectedIndex].Roles.ToString()).ToString());
            }
        }

        private void Populate()
        {
            Clear();
            Window.lstBoxUsers.Items.Clear();
            userList = service.GetAll();
            foreach (UserApp user in userList)
            {
                Window.lstBoxUsers.Items.Add(user.Login);
            }
        }

        private void Clear()
        {
            Window.txtBoxLogin.Clear();
            Window.txtBoxPWD.Clear();
            Window.txtBoxPWDConfirm.Clear();
            Window.cmbBoxRoles.SelectedIndex = -1;
            Window.lstBoxUsers.SelectedIndex = -1;
        }

    }
}
