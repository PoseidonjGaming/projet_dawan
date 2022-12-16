using SerieDLL_EF.Models;
using SerieDLL_EF.Repository;
using SerieDLL_EF.Service;
using System.Security.Policy;

namespace projet_dawan
{
    public partial class FormManageSerie : Form
    {
        private SerieService serieService = new();
        private List<Serie> serieList = new();
        public FormManageSerie()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // vérifier si les champs sont valides puis ajouter la serie à la base de données
            if (txtNomSerie.Text != string.Empty && txtResume.Text != string.Empty
                && txtPathAffiche.Text != string.Empty)
            {
                if(lstBoxSerie.SelectedIndex != -1)
                {
                    Serie serie = serieList[lstBoxSerie.SelectedIndex];
                    serie.Affiche=Path.GetFileName(txtNomSerie.Text);
                    serie.Nom=txtNomSerie.Text;
                    serie.Resume=txtResume.Text;
                    serie.UrlBa = txtUrlBa.Text;
                    serie.DateDiff = dateTimeSortie.Value;
                    serieService.Update(serie);
                }
                else
                {
                    Serie serie = new()
                    {
                        Nom = txtNomSerie.Text,
                        DateDiff = dateTimeSortie.Value,
                        Resume = txtResume.Text,
                        UrlBa = txtUrlBa.Text,
                        Affiche = Path.GetFileName(txtPathAffiche.Text)

                    };
                    serieService.Add(serie);
                }
                
            }
            else
            {
                MessageBox.Show("Champs Obligatoires Incorrects");
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            txtNomSerie.Clear();
            txtPathAffiche.Clear();
            txtUrlBa.Clear();
            txtResume.Clear();
            lstBoxSerie.SelectedIndex= -1;
            btnAjouter.Text = "Ajouter";
        }

        private void btnSup_Click(object sender, EventArgs e)
        {
            var annuler = MessageBox.Show("Etes vous sur de vouloir annuler l'ajout ?", "Annuler ajout ?",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (annuler == DialogResult.Yes)
            {
                SerieService service = new();
                service.Delete(serieList[lstBoxSerie.SelectedIndex]);
            }
            Populate();
        }

        private void FormAjoutSerie_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void Populate()
        {
            lstBoxSerie.Items.Clear();
            serieList = serieService.GetAll();
            foreach (Serie serie in serieList)
            {
                lstBoxSerie.Items.Add(serie.Nom);
            }
        }

        private void btnParcourir_Click(object sender, EventArgs e)
        {
            if (openFileDialogAffiche.ShowDialog() == DialogResult.OK)
            {
                txtPathAffiche.Text = openFileDialogAffiche.FileName;
            }
        }

        private void lstBoxSerie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstBoxSerie.SelectedIndex != -1)
            {
                Serie serie = serieList[lstBoxSerie.SelectedIndex];
                txtNomSerie.Text = serie.Nom;
                if(File.Exists(Directory.GetCurrentDirectory()+"\\Photo\\"+serie.Affiche))
                {
                    txtPathAffiche.Text += Directory.GetCurrentDirectory() + "\\Photo\\" + serie.Affiche;
                }
                else
                {
                    txtPathAffiche.Text =serie.Affiche;
                }

                txtResume.Text = serie.Resume;
                txtUrlBa.Text= serie.UrlBa;
                dateTimeSortie.Value= (DateTime)serie.DateDiff;
                btnAjouter.Text = "Modifier";
            }
        }
    }
}
