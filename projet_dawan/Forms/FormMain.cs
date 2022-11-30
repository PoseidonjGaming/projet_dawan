using Microsoft.VisualBasic.ApplicationServices;
using projet_dawan.DAO;
using projet_dawan.Model;
using projet_dawan.Repository;
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
            UserAppDAO dao = new(Properties.Settings.Default.Connection);

            UserApp? user = dao.GetByLogin(textBox2.Text);

            if (checkBox1.Checked)
            {
                Properties.Settings.Default.UserRemain = user;
                Properties.Settings.Default.Save();

            }

            Login(user, UserApp.HashPassword(textBox1.Text) );


        }
        private void pageAcceuil_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Properties.Settings.Default.token != string.Empty)
            {
                this.Close();
            }
            else
            {
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                this.Show();
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.UserRemain != null)
            {

                UserApp user = Properties.Settings.Default.UserRemain;
                
                Login(user, user.Password);
            }
        }

        private void Login(UserApp? user, string password)
        {
            if (user != null)
            {
                if (user.Password == password)
                {
                    using (var crypto = new RNGCryptoServiceProvider())
                    {
                        var bits = (password.Length * 6);
                        var byte_size = ((bits + 7) / 8);
                        var bytesarray = new byte[byte_size];
                        crypto.GetBytes(bytesarray);
                        Properties.Settings.Default.token = Convert.ToBase64String(bytesarray);
                    }
                }

                FormAccueil pageAcceuil = new FormAccueil();
                pageAcceuil.FormClosing += pageAcceuil_FormClosing;
                this.Hide();
                pageAcceuil.ShowDialog();
            }
        }
    }
}