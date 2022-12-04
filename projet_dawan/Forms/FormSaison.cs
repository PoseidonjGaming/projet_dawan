using projet_dawan.DAO;
using projet_dawan.Forms;
using projet_dawan.Model;
using projet_dawan_WinForm.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Serie serie = saison.SerieId;
            pictureBoxSaison.ImageLocation = Directory.GetCurrentDirectory() + "\\Photo\\" + serie.Affiche;
            txtBoxResumeSaison.Text = serie.Resume;
            lblDateSaison.Text= serie.DateDiff.ToShortDateString();
            linkLblBASaison.Text = serie.UrlBa;

            EpisodeDAO dao = new(projet_dawan.Properties.Settings.Default.Connection);
            foreach (Episode episode in dao.GetEpisodes(saison.Id))
            {
                episodes.Add(episode);
                lstBoxEpisode.Items.Add(episode.Nom);
            }
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
