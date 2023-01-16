using projet_dawan.Logic.Autre;

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