using Azure.Core;
using projet_dawan;
using projet_dawan.FormLogic;
using projet_dawan.Forms;
using SerieDLL_EF.Models;
using SerieDLL_EF.Repository;
using SerieDLL_EF.Service;

namespace projet_dawan_WinForm
{
    public partial class FormEpisode : Form
    {
        private LogicEpisodes logicEpisodes;

        public FormEpisode(Saison saison)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            logicEpisodes = new(this);
            logicEpisodes.Load(saison);
        }

        private void lstBoxEpisode_SelectedIndexChanged(object sender, EventArgs e)
        {
            logicEpisodes.LstBoxEpisode_SelectedIndexChanged();
        }


        private void btnCasting_Click(object sender, EventArgs e)
        {
            logicEpisodes.Casting_Click();
        }

        public PictureBox GetPictureBoxSaison()
        {
            return pictureBoxSaison;
        }

        public Label GetLabelSerie()
        {
            return lblEpisode;
        }

        public Label GetLabelSaison()
        {
            return lblSaison;
        }

        public Label GetLabelDateSaison()
        {
            return lblDateSaison;
        }

        public Label GetLabelTitreEp()
        {
            return lblTitreEp;
        }

        public ListBox GetListBoxEpisode()
        {
            return lstBoxEpisode;
        }

        public TextBox GetTextBoxResumeSaison()
        {
            return txtBoxResumeSaison;
        }

    }
}
