using projet_dawan.FormLogic;
using projet_dawan.Models;
using SerieDLL_EF.Repository;
using SerieDLL_EF.Service;

namespace projet_dawan
{
    public partial class FormSupprimerSeries : Form
    {
        private LogicSuprimerSerie suprimerSerie;
        public FormSupprimerSeries()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            suprimerSerie = new(this);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            suprimerSerie.BtnSupprimer_Click();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            suprimerSerie.BtnAnnuler_Click();
        }

        private void SupprimerSeries_Load(object sender, EventArgs e)
        {
            suprimerSerie.Load();
        }
    }
}
