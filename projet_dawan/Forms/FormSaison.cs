using projet_dawan.Forms;
using projet_dawan.Models;
using projet_dawan_WinForm.Forms;
using SerieDLL_EF.Repository;

namespace projet_dawan_WinForm
{
    public partial class FormSaison : Form
    {
        private Saison saison;
        private List<Episode> episodes = new List<Episode>();
        public FormSaison(Saison saison)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            this.saison = saison;
        }

        private void FormSaison_Load(object sender, EventArgs e)
        {
            //Serie serie = saison.SerieId;
            //pictureBoxSaison.ImageLocation = Directory.GetCurrentDirectory() + "\\Photo\\" + serie.Affiche;
            //txtBoxResumeSaison.Text = serie.Resume;
            //lblDateSaison.Text= serie.DateDiff.ToString();
            //linkLblBASaison.Text = serie.UrlBa;

            //foreach (Episode episode in EpisodeRepository.GetBySaison(saison.Id))
            //{
            //    episodes.Add(episode);
            //    lstBoxEpisode.Items.Add(episode.Nom);
            //}
        }

        private void lstBoxEpisode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstBoxEpisode.SelectedIndex != -1)
            {
                Episode episode = episodes[lstBoxEpisode.SelectedIndex];
                FormEpisode formEpisode = new(episode);
                formEpisode.FormClosed += OpenForm;
                this.Hide();
                formEpisode.ShowDialog(this);
            }
        }

        private void OpenForm(object sender, EventArgs e)
        {
            this.Show();
        }

        private void btnCasting_Click(object sender, EventArgs e)
        {
            // retour form casting correspondant au personnage présent dans la série
            FormCasting casting = new();

            casting.ShowDialog();
        }
    }
}
