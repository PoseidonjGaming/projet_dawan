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
    public partial class FormAjoutEpisode : Form
    {
        private EpisodeService service = new();
        private List<Episode> episodes = new List<Episode>();
        private List<Serie> serieList = new List<Serie>();
        public FormAjoutEpisode()
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
        }

        private void Populate()
        {
            episodes = service.GetAll();
            foreach (Episode episode in episodes)
            {
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
    }
}
