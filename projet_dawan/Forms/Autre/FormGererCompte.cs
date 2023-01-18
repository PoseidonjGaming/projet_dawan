using Newtonsoft.Json;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;

namespace projet_dawan
{
    public partial class FormGererCompte : Form
    {

        public FormGererCompte()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void FormGererCompte_Load(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void UpdateForm()
        {
            UserApp user = Properties.Settings.Default.UserRemain;
            UserName.Text = user.Login;
            //Password.Text = user.Password;
            //ConfirmPassword.Text = user.Password;
        }

        private void ModifierLogin_Click(object sender, EventArgs e)
        {
            UserApp user = Properties.Settings.Default.UserRemain;

            if (UserName.Text != user.Login)
            {
                var modifier = MessageBox.Show("Etes vous sur de vouloir modifier le login utilisateur ?", "Modifier login ?",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (modifier == DialogResult.Yes)
                {
                    user.Login = UserName.Text;
                    UpdateForm();
                }
            }
        }

        private void ModifierPassword_Click(object sender, EventArgs e)
        {
            UserApp user = Properties.Settings.Default.UserRemain;

            if (Password.Text != user.Password)
            {
                if (Password.Text == ConfirmPassword.Text)
                {
                    var modifier = MessageBox.Show("Etes vous sur de vouloir modifier le mot de passe ?", "Modifier mot de passe ?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (modifier == DialogResult.Yes)
                    {
                        //user.Password = Password.Text;
                        //UpdateForm();
                    }
                }
                else
                {
                    var message = MessageBox.Show("Le mot de passe et la confimation du mot de passe ne corresponde pas.", "Erreur mot de passe",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                var message = MessageBox.Show("Mot de passe identique à l'ancien", "Erreur mot de passe",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
