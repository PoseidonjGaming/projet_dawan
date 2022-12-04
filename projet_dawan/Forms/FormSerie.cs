using projet_dawan.Forms;
using projet_dawan.Models;
using SerieDLL_EF.Repository;

namespace projet_dawan_WinForm
{
    public partial class FormSerie : Form
    {
        private Serie Serie = new();
        private List<Saison> Saisons = new List<Saison>();

        public FormSerie(Serie serie)
        {
            InitializeComponent();
            Serie = serie;
        }

        private void FormSerie_Load(object sender, EventArgs e)
        {

            lblSerie.Text = Serie.Nom;
            lblDateSerie.Text = Serie.DateDiff.ToString();
            linkLblBASerie.Text = Serie.UrlBa;
            txtBoxResumeSerie.Text = Serie.Resume;
            pictureBoxSerie.ImageLocation = Directory.GetCurrentDirectory() + "\\Photo\\" + Serie.Affiche;
            foreach (Saison saison in SaisonRepository.GetSaisonsBySerie(Serie.Id))
            {
                Saisons.Add(saison);
                lstBoxSaison.Items.Add(saison.Numero.ToString());
            }
        }

        private void btnCasting_Click(object sender, EventArgs e)
        {
            // retour form casting correspondant au personnage pr�sent dans la s�rie
            FormCasting casting = new();

            casting.ShowDialog();
        }

        private void lstBoxSaison_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBoxSaison.SelectedIndex != -1)
            {
                Saison saison = Saisons[lstBoxSaison.SelectedIndex];
                saison.Serie = Serie;
                FormEpisode formSaison = new(saison);
                formSaison.FormClosed += OpenForm;
                this.Hide();
                formSaison.ShowDialog(this);
            }
        }

        private void OpenForm(object sender, EventArgs e)
        {
            this.Show();
        }

        private void buttonToWatch_Click(object sender, EventArgs e)
        {
            List<Serie> series= new List<Serie>();
            series.Add(Serie);
            projet_dawan.Properties.Settings.Default.ToWatch= series;
            projet_dawan.Properties.Settings.Default.Save();
        }
    }
}