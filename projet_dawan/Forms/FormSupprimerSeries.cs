using projet_dawan.FormLogic;
using projet_dawan.Models;
using SerieDLL_EF.Repository;
using SerieDLL_EF.Service;

namespace projet_dawan
{
    public partial class FormSupprimerSeries : Form
    {
<<<<<<< HEAD
        private LogicSuprimerSerie logic;
=======
        private LogicSuprimerSerie suprimerSerie;
>>>>>>> f984640f1965c9eef8b8e8c88742c195a1fc19ce
        public FormSupprimerSeries()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
<<<<<<< HEAD
            logic = new(this);
=======
            suprimerSerie = new(this);
>>>>>>> f984640f1965c9eef8b8e8c88742c195a1fc19ce
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            logic.BtnSupprimer_Click();
=======
            suprimerSerie.BtnSupprimer_Click();
>>>>>>> f984640f1965c9eef8b8e8c88742c195a1fc19ce
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
           logic.BtnAnnuler_Click();
=======
            suprimerSerie.BtnAnnuler_Click();
>>>>>>> f984640f1965c9eef8b8e8c88742c195a1fc19ce
        }

        private void SupprimerSeries_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            logic.Load();
=======
            suprimerSerie.Load();
>>>>>>> f984640f1965c9eef8b8e8c88742c195a1fc19ce
        }
    }
}
