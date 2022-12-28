using SerieDLL_EF.Repository;
using System.Security.Cryptography;
using SerieDLL_EF.Service;
using projet_dawan.FormLogic;

namespace projet_dawan
{
    public partial class FormMain : Form
    {

        private LogicMain logicMain;
        public FormMain()
        {
            InitializeComponent();
            logicMain = new(this);

        }




        private void btnConnexion_Click(object sender, EventArgs e)
        {
            logicMain.BtnConnexion_Click();

        }



        private void FormMain_Load(object sender, EventArgs e)
        {
            logicMain.Load();
        }

      
    }
}