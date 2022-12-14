using projet_dawan.Models;
using SerieDLL_EF.Repository;
using System.Security.Cryptography;
using SerieDLL_EF.Service;
using projet_dawan.FormLogic;

namespace projet_dawan
{
    public partial class FormMain : Form
    {
        private LogicMain main;
        public FormMain()
        {
            InitializeComponent();
            main = new(this);
        }




        private void btnConnexion_Click(object sender, EventArgs e)
        {
            main.BtnConnexion_Click();
        }
        

        private void FormMain_Load(object sender, EventArgs e)
        {
            main.Load();
        }

        
    }
}