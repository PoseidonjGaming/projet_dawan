using projet_dawan.Models;
using SerieDLL_EF.Repository;
using System.Security.Cryptography;

namespace projet_dawan
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }




        private void btnConnexion_Click(object sender, EventArgs e)
        {

            UserApp? user = UserAppRepository.GetUser(textBoxLogin.Text, textBoxPassword.Text);

            if (checkBox1.Checked)
            {
                Properties.Settings.Default.UserRemain = user;
                Properties.Settings.Default.Save();

            }

            Login(user);


        }
        private void pageAcceuil_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Properties.Settings.Default.token != string.Empty)
            {
                this.Close();
            }
            else
            {
                textBoxPassword.Text = string.Empty;
                textBoxLogin.Text = string.Empty;
                this.Show();
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.UserRemain != null)
            {
                UserApp user = Properties.Settings.Default.UserRemain;
                
                Login(user);
            }
        }

        private void Login(UserApp? user)
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
                FormAccueil pageAcceuil = new FormAccueil();
                pageAcceuil.FormClosing += pageAcceuil_FormClosing;
                this.Hide();
                pageAcceuil.ShowDialog();
            }
        }
    }
}