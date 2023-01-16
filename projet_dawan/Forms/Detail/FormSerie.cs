using projet_dawan.Logic.Detail;
using SerieDLL_EF.Models;

namespace projet_dawan_WinForm
{
    public partial class FormSerie : Form
    {
        private LogicSerie logicSerie;

        public FormSerie(Serie serie)
        {
            InitializeComponent();
            logicSerie = new(this);
            logicSerie.Load(serie);

        }

        private void btnCasting_Click(object sender, EventArgs e)
        {
            logicSerie.BtnCasting_Click();
        }

        private void lstBoxSaison_SelectedIndexChanged(object sender, EventArgs e)
        {
            logicSerie.LstBoxSaison_SelectedIndexChanged();
        }



        private void buttonToWatch_Click(object sender, EventArgs e)
        {
            logicSerie.ButtonToWatch_Click();
        }

        public Label GetLabelNom()
        {
            return lblSerie;
        }

        public Label GetLabelDateSerie()
        {
            return lblDateSerie;
        }

        public LinkLabel GetLinkLabelUrlBa()
        {
            return linkLblBASerie;
        }

        public TextBox GetTextBoxRsume()
        {
            return txtBoxResumeSerie;
        }

        public PictureBox GetPictureBoxAffiche()
        {
            return pictureBoxSerie;
        }

        public ListBox GetListBoxSaison()
        {
            return lstBoxSaison;
        }
    }
}