using projet_dawan.FormLogic;
using projet_dawan.Forms;
using projet_dawan.Models;
using projet_dawan_WinForm;
using SerieDLL_EF.Repository;
using SerieDLL_EF.Service;

namespace projet_dawan
{
    public partial class FormBibliotheque : Form
    {
        private LogicBibliothèque bibli;
        public FormBibliotheque(string text)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            bibli = new(this);
            bibli.Load(text);


            txtRechercher.Text = text;

            bibli = new(this);
            bibli.Load(text);


        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            bibli.BtnRetour_Click();
        }



        private void txtRechercher_TextChanged(object sender, EventArgs e)
        {
            bibli.ChangeText();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            bibli.Detail();
        }

        private void buttonAddWich_Click(object sender, EventArgs e)
        {
           bibli.ButtonAddWich_Click();
        }






      
        private void cmbFiltrer_SelectedIndexChanged(object sender, EventArgs e)
        {
            bibli.CmbFiltrer_SelectedIndexChanged();
        }


    }
}
