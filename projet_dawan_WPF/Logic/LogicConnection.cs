using projet_dawan_WPF.Window;
using projet_dawan_WPF.Windows.Autre;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System;
using System.Security.Cryptography;

namespace projet_dawan_WPF.Logic
{
    internal class LogicMain
    {
        public WindowConnection Window { get; set; }

        public LogicMain(WindowConnection form)
        {
            Window = form;
        }

        public void Load()
        {
            if (Properties.Settings.Default.UserRemain != null)
            {
                UserService service = new UserService();
                UserApp user = service.GetById(Properties.Settings.Default.UserRemain.Id);

                Login(user);
            }
        }

        public void BtnConnexion_Click()
        {
            UserService service = new();
            UserApp user = new()
            {
                Login = Window.txtLogin.Text,
                Password = Window.txtPwd.Password
            };

            user=service.GetUser(user);

            Properties.Settings.Default.UserRemain = user;
            if ((bool)Window.checkBoxCo.IsChecked)
            {
                Properties.Settings.Default.Save();
            }
            Login(user);
        }

        private void Login(UserApp user)
        {
            if (user != null)
            {
                using (var crypto = new RNGCryptoServiceProvider())
                {
                    var bits = (user.Password.Length * 6);
                    var byte_size = ((bits + 7) / 8);
                    var bytesarray = new byte[byte_size];
                    crypto.GetBytes(bytesarray);
                    Properties.Settings.Default.token = Convert.ToBase64String(bytesarray);
                }
                Window.Close();
            }

        }


    }
}
