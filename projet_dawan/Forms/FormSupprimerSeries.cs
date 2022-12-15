using projet_dawan.FormLogic;
using SerieDLL_EF.Repository;
using SerieDLL_EF.Service;

namespace projet_dawan
{
    public partial class FormSupprimerSeries : Form
    {
        private LogicSuprimerSerie logic;
        public FormSupprimerSeries()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            logic = new(this);

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            logic.BtnSupprimer_Click();

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
           logic.BtnAnnuler_Click();
        }

        private void SupprimerSeries_Load(object sender, EventArgs e)
        {
            logic.Load();
        }
    }
}
