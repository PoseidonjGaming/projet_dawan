using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_dawan.Forms
{
    public partial class FormManageEpisode : Form
    {
        private EpisodeService service = new();
        private List<Episode> episodes = new List<Episode>();
        private List<Serie> serieList = new List<Serie>();
        private Saison saison = new();
        public FormManageEpisode()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void FormAjoutEpisode_Load(object sender, EventArgs e)
        {
            SerieService serieService = new();
            serieList = serieService.GetAll();
            foreach (Serie serie in serieList)
            {
                cmbSerie.Items.Add(serie.Nom);
            }
            if (serieList.Count > 0)
            {
                cmbSerie.SelectedIndex = 0;
            }
            SaisonService saisonService = new SaisonService();
            
            numSaison.Maximum = saisonService.GetSaisonsBySerie(serieList.FirstOrDefault().Id).MaxBy(e => e.Numero).Numero;
            Populate();
        }

        private void Populate()
        {
            lstBoxEpisode.Items.Clear();
            episodes.Clear();
            episodes = service.GetAll();
            foreach (Episode episode in episodes)
            {
                lstBoxEpisode.Items.Add(episode.Nom);
            }

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            SaisonService saisonService = new SaisonService();
            List<Saison> saisonList = saisonService.GetSaisonsBySerie(serieList[cmbSerie.SelectedIndex].Id);
            if (txtBoxNom.Text != string.Empty && txtBoxResume.Text != string.Empty
                && numSaison.Value != 0)
            {
                Saison saison = (Saison)saisonList.Where(e => e.Numero == numSaison.Value);
                saison.NbEpisode++;
                saisonService.Update(saison);
                Episode ep = new()
                {
                    Nom = txtBoxNom.Text,
                    Resume = txtBoxResume.Text,
                    DatePremDiff = datePremDiff.Value,
                    SaisonId = saison.Id
                };

            }

            if (checkBoxLastSeason.Checked)
            {
                Saison saison = new Saison
                {
                    NbEpisode = 0,
                    SerieId = serieList[cmbSerie.SelectedIndex].Id,
                    Numero = saisonList.Max(e => e.Numero)
                };
                saison.Numero++;
                saisonService.Add(saison);
            }
        }

        private void cmbSerie_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaisonService saisonService = new SaisonService();
            numSaison.Maximum = saisonService.GetSaisonsBySerie(serieList[cmbSerie.SelectedIndex].Id).MaxBy(e => e.Numero).Numero;
        }

        private void lstBoxEpisode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBoxEpisode.SelectedItems.Count != -1)
            {
                Episode ep = episodes[lstBoxEpisode.SelectedIndex];
                txtBoxNom.Text = ep.Nom;
                txtBoxResume.Text = ep.Resume;
                datePremDiff.Value = (DateTime)ep.DatePremDiff;
                SaisonService saisonService = new();
                saison = saisonService.GetById(episodes[lstBoxEpisode.SelectedIndex].SaisonId);
                numSaison.Value = saisonService.GetById(ep.SaisonId).Numero;
                cmbSerie.SelectedIndex = serieList.IndexOf(serieList.Where(s => s.Id == saison.SerieId).SingleOrDefault());
            }
        }

        private void btnSup_Click(object sender, EventArgs e)
        {
            if (lstBoxEpisode.SelectedIndex != -1)
            {
                var annuler = MessageBox.Show("Etes vous sur de vouloir annuler l'ajout ?", "Annuler ajout ?",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (annuler == DialogResult.Yes)
                {
                    EpisodeService service = new();
                    service.Delete(episodes[lstBoxEpisode.SelectedIndex]);
                }
                Populate();
            }
        }
    }
}
