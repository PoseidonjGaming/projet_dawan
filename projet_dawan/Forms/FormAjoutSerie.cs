using SerieDLL_EF.Models;
using SerieDLL_EF.Repository;
using SerieDLL_EF.Service;

namespace projet_dawan
{
    public partial class FormAjoutSerie : Form
    {
        SerieService serieService = new();
        public FormAjoutSerie()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // vérifier si les champs sont valides puis ajouter la serie à la base de données
            if (txtNomSerie.Text != null && txtResume.Text != null)
            {
                Serie serie = new Serie { Nom = txtNomSerie.Text, DateDiff = dateTimeSortie.Value, 
                    Resume = txtResume.Text, UrlBa = txtUrlBa.Text };
                serieService.Add(serie);
            }
            else
            {
                MessageBox.Show("Champ Obligatoir Incorrecte");
            }
            Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            var annuler = MessageBox.Show("Etes vous sur de vouloir annuler l'ajout ?", "Annuler ajout ?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (annuler == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
