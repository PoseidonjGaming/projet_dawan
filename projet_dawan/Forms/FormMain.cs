using projet_dawan.Models;
using SerieDLL_EF.Repository;
using System.Security.Cryptography;
using SerieDLL_EF.Service;
using projet_dawan.FormLogic;

namespace projet_dawan
{
    public partial class FormMain : Form
    {
<<<<<<< HEAD
        private LogicMain logicMain;
        public FormMain()
        {
            InitializeComponent();
            logicMain = new(this);
=======
        private LogicMain main;
        public FormMain()
        {
            InitializeComponent();
            main = new(this);
>>>>>>> f984640f1965c9eef8b8e8c88742c195a1fc19ce
        }




        private void btnConnexion_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            logicMain.BtnConnexion_Click();
=======
            main.BtnConnexion_Click();
>>>>>>> f984640f1965c9eef8b8e8c88742c195a1fc19ce
        }
        


        private void FormMain_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            logicMain.Load();
        }

     
=======
            main.Load();
        }

        
>>>>>>> f984640f1965c9eef8b8e8c88742c195a1fc19ce
    }
}