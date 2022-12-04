using projet_dawan.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_dawan_WinForm.Forms
{
    public partial class FormEpisode : Form
    {
        private Episode episode;
        private Saison saison;
        private Serie serie;
        public FormEpisode(Episode episode, Saison saison, Serie serie)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            this.episode = episode;
            this.saison = saison;
            this.serie= serie;
        }

        private void FormEpisode_Load(object sender, EventArgs e)
        {
            lblSerie.Text = serie.Nom;
            lblSaison.Text += saison.Numero.ToString();
            lblSaison.Location = new(lblSerie.Size.Width + 20, lblSaison.Location.Y);
            labelEpisode.Text = episode.Nom;
            labelEpisode.Location = new(lblSaison.Size.Width + lblSaison.Location.X + 20, labelEpisode.Location.Y);
            lblDateEpisode.Text += ": " + episode.DatePremDiff.ToString();
            linkLblBAEpisode.Text = serie.UrlBa;
            txtBoxResumeEpisode.Text = episode.Resume;
            //pictureBoxEpisode.ImageLocation = Directory.GetCurrentDirectory() + "\\Photo\\" + episode.SaisonId.SerieId.Affiche;
        }
    }
}
