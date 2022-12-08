using projet_dawan.Models;
using SerieDLL_EF.Repository;
using SerieDLL_EF.Service;

namespace projet_dawan
{
    public partial class FormSupprimerSeries : Form
    {
        private List<Serie> SerieList = new List<Serie>();
        public FormSupprimerSeries()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            // supprimer la serie selectionner. Ajouter messagebox pour demander une validation
            if (cmbBxSerie.SelectedIndex != -1)
            {
                var annuler = MessageBox.Show("Etes vous sur de vouloir annuler l'ajout ?", "Annuler ajout ?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (annuler == DialogResult.Yes)
                {
                }
            }
            Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            var annuler = MessageBox.Show("Etes vous sur de vouloir annuler la suppression ?", "Annuler suppression ?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (annuler == DialogResult.Yes)
            {
                Close();
            }
        }

        private void SupprimerSeries_Load(object sender, EventArgs e)
        {
            Service<Serie> service=new(new SerieRepository());
            foreach (Serie serie in service.GetAll())
            {
                cmbBxSerie.Items.Add(serie.Nom);
                SerieList.Add(serie);
            }
        }
    }
}
