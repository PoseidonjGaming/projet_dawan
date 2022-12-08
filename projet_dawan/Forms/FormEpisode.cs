using projet_dawan.Forms;
using projet_dawan.Models;
using SerieDLL_EF.Repository;

namespace projet_dawan_WinForm
{
    public partial class FormEpisode : Form
    {
        private Saison saison;
        private List<Episode> episodes = new List<Episode>();
        public FormEpisode(Saison saison)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            this.saison = saison;
            episodes = EpisodeRepository.GetBySaison(saison.Id);
        }

        private void FormSaison_Load(object sender, EventArgs e)
        {
            Serie serie = saison.Serie;
            pictureBoxSaison.ImageLocation = Directory.GetCurrentDirectory() + "\\Photo\\" + serie.Affiche;
            lblSerie.Text = serie.Nom;
            lblSaison.Text += saison.Numero.ToString();





            foreach (Episode episode in EpisodeRepository.GetBySaison(saison.Id))
            {
                episodes.Add(episode);
                lstBoxEpisode.Items.Add(episode.Nom);
            }
            if (lstBoxEpisode.Items.Count > 0)
            {
                Populate(episodes[0]);
            }

        }

        private void lstBoxEpisode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBoxEpisode.SelectedIndex != -1)
            {
                Episode ep = episodes[lstBoxEpisode.SelectedIndex];
                Populate(ep);
            }
        }

        private void OpenForm(object sender, EventArgs e)
        {
            this.Show();
        }

        private void btnCasting_Click(object sender, EventArgs e)
        {
            // retour form casting correspondant au personnage présent dans la série
            //FormCasting casting = new();

            //casting.ShowDialog();
        }

        private void Populate(Episode ep)
        {
            txtBoxResumeSaison.Text = ep.Resume;
            lblDateSaison.Text = "Episode diffusé le " + ep.DatePremDiff.Value.ToShortDateString();
            lblTitreEp.Text = "Détail l'épisode: " + ep.Nom;
        }
    }
}
