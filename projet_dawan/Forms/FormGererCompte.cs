using projet_dawan.Models;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            user.Password= "password";
            user.Roles = Roles.User;
            UserService service = new();
            user.Password= service.HashPassword(user.Password);
            service.Add(user);
        }
    }
}
