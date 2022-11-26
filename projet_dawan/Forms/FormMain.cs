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

        private void button1_Click(object sender, EventArgs e)
        {
            //Orm orm = new SaisonRepository();
            MessageBox.Show(Properties.Settings.Default.token);
            UserAppDAO dao = new(Properties.Settings.Default.Connection);

            UserApp user = dao.GetByLogin(textBox2.Text);
            /*user.Password=UserApp.HashPassword("P@ssw0rd");
            dao.Update(user);*/
            if(user != null)
            {
                if (user.Password == UserApp.HashPassword(textBox1.Text))
                {
                    using (var crypto = new RNGCryptoServiceProvider())
                    {
                        var bits = (textBox1.Text.Length * 6);
                        var byte_size = ((bits + 7) / 8);
                        var bytesarray = new byte[byte_size];
                        crypto.GetBytes(bytesarray);
                        Properties.Settings.Default.token = Convert.ToBase64String(bytesarray);

                    }


                }
            }
           
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.token!= string.Empty)
            {
                PageAcceuil pageAcceuil=new PageAcceuil();
                pageAcceuil.FormClosing += pageAcceuil_FormClosing;
                this.Hide();
                pageAcceuil.ShowDialog();
                
            }
        }
        private void pageAcceuil_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }
    }
}