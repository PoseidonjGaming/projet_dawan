using projet_dawan.FormLogic;
using SerieDLL_EF.Models;
using SerieDLL_EF.Repository;
using SerieDLL_EF.Service;
using System.Security.Policy;

namespace projet_dawan
{
    public partial class FormManageSerie : Form
    {
        private LogicManageSerie manageSerie;
        public FormManageSerie()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            manageSerie = new(this);
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // vérifier si les champs sont valides puis ajouter la serie à la base de données
            manageSerie.BtnAjouter_Click();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
           manageSerie.BtnAnnuler_Click();
        }

        private void btnSup_Click(object sender, EventArgs e)
        {
           manageSerie.BtnSup_Click();  
        }

        private void FormAjoutSerie_Load(object sender, EventArgs e)
        {
            manageSerie.Load();
        }

        private void btnParcourir_Click(object sender, EventArgs e)
        {
            manageSerie.BtnParcourir_Click();
        }

        private void lstBoxSerie_SelectedIndexChanged(object sender, EventArgs e)
        {
           manageSerie.LstBoxSerie_SelectedIndexChanged();
        }
    }
}
