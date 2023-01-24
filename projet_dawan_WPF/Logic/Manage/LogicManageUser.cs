using projet_dawan_WPF.Windows.Autre;
using projet_dawan_WPF.Windows.Manage;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace projet_dawan_WPF.Logic.Manage
{
    public class LogicManageUser
    {
        public WindowMangeCompte Window { get; set; }
        private UserApp user;
        private readonly UserService service;

        public LogicManageUser(WindowMangeCompte window)
        {
            Window = window;
            user = Properties.Settings.Default.UserRemain;
            service = new();
        }

        public void Load()
        {
            Window.txtBoxLogin.Text = user.Login;
        }

        public void BtnModif_Click()
        {
            if (Window.txtBoxLogin.Text != string.Empty)
            {
                if (Window.txtBoxPassword.Password != string.Empty && Window.txtBoxPasswordConfirm.Password != string.Empty
                    && Window.txtBoxPasswordConfirm.Password == Window.txtBoxPassword.Password)
                {
                    if (service.HashPassword(Window.txtBoxPassword.Password) != user.Password
                        && service.HashPassword(Window.txtBoxPasswordConfirm.Password) != user.Password)
                    {
                        user.Password = Window.txtBoxPassword.Password;
                        user.Login = Window.txtBoxLogin.Text;
                        service.Update(user);
                        Properties.Settings.Default.UserRemain = null;
                        WindowConnection window = new()
                        {
                            Owner = Window
                        };
                        window.Closed += Close;
                        window.ShowDialog();
                    }
                }
            }
        }

        private void Close(object sender, EventArgs e)
        {
            Window.txtBoxPassword.Password = string.Empty;
            Window.txtBoxPasswordConfirm.Password = string.Empty;
        }
    }
}
