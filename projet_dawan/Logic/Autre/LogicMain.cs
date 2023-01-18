using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System.Security.Cryptography;

namespace projet_dawan.Logic.Autre
{
    internal class LogicMain
    {
        public FormMain Form { get; set; }

        public LogicMain(FormMain form)
        {
            Form = form;
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
                Login = Form.txtBoxLogin.Text,
                Password = Form.txtBoxPwd.Text
            };
            user = service.GetUser(user);
            Properties.Settings.Default.UserRemain = user;
            if (Form.checkBox1.Checked)
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
                    var bits = user.Password.Length * 6;
                    var byte_size = (bits + 7) / 8;
                    var bytesarray = new byte[byte_size];
                    crypto.GetBytes(bytesarray);
                    Properties.Settings.Default.token = Convert.ToBase64String(bytesarray);
                }
                Form.Close();
            }

        }


    }
}
