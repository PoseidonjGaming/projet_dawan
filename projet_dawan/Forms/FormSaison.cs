using projet_dawan.Models;
using projet_dawan_WinForm.Forms;
using SerieDLL_EF.Repository;
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
        private Serie serie;
        public FormSaison(Saison saison, Serie serie)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            this.saison = saison;
            this.serie = serie;
        }

        private void FormSaison_Load(object sender, EventArgs e)
        {
            pictureBoxSaison.ImageLocation = Directory.GetCurrentDirectory() + "\\Photo\\" + serie.Affiche;


            foreach (Episode episode in EpisodeRepository.GetBySaison(saison.Id))
            {
                episodes.Add(episode);
                lstBoxEpisode.Items.Add(episode.Nom);
            }

            Populate(episodes[0]);
            lstBoxEpisode.SelectedIndex = 0;
        }

        private void lstBoxEpisode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBoxEpisode.SelectedIndex != -1)
            {
                Episode episode = episodes[lstBoxEpisode.SelectedIndex];
                Populate(episode);
            }
        }

        private void OpenForm(object sender, EventArgs e)
        {
            this.Show();
        }

        private void Populate(Episode ep)
        {
            txtBoxResumeSaison.Text = ep.Resume;
            lblDateSaison.Text = "Date de première diffusion: " + ep.DatePremDiff.ToString();
            labelNomEp.Text = "Titre de l'épisode: \n" + ep.Nom;
            lblSaison.Text = "Saison numéro" + ep.SaisonId.ToString();
        }
    }
}
