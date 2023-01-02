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

        private void button1_Click(object sender, EventArgs e)
        {
            UserApp user = new();
            user.Login = "TestUser";
            user.Password = "password";
            user.Roles = Roles.User;
            UserService service = new();
            user.Password = UserService.HashPassword(user.Password);
            service.Add(user);
        }
    }
}
