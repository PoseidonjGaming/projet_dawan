using projet_dawan.Forms;
using projet_dawan.Models;
using projet_dawan_WinForm;
using SerieDLL_EF.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_dawan.FormLogic
{
    internal class Episodes
    {
        private Saison saison;
        private List<Episode> episodes = new List<Episode>();
        private EpisodeService service = new();
        public FormEpisode Form { get; set; }

        public Episodes(FormEpisode form)
        {
            Form = form;
        }

        public void Load(Saison saison)
        {
            this.saison = saison;
            episodes = service.GetBySaison(saison.Id);
            SerieService serieService = new();
            Serie serie = serieService.GetById(saison.SerieId);
            Form.pictureBoxSaison.ImageLocation = Directory.GetCurrentDirectory() + "\\Photo\\" + serie.Affiche;
            Form.lblSerie.Text = serie.Nom;
            Form.lblSaison.Text += saison.Numero.ToString();

            foreach (Episode episode in service.GetBySaison(saison.Id))
            {
                episodes.Add(episode);
                Form.lstBoxEpisode.Items.Add(episode.Nom);
            }
            if (Form.lstBoxEpisode.Items.Count > 0)
            {
                Populate(episodes[0]);
            }
        }
        
        public void LstBoxEpisode_SelectedIndexChanged()
        {
            if (Form.lstBoxEpisode.SelectedIndex != -1)
            {
                Episode ep = episodes[Form.lstBoxEpisode.SelectedIndex];
                Populate(ep);
            }
        }

        public void Casting_Click()
        {
            SerieService serieService = new();
            SaisonService saisonService = new();
            PersonnageService personnage= new ();
            FormCasting casting = new(personnage.GetBySerie(serieService.GetById(saisonService.GetById(episodes[Form.lstBoxEpisode.SelectedIndex].SaisonId).SerieId).Id));

            casting.ShowDialog();
        }

        private void Populate(Episode ep)
        {
            Form.txtBoxResumeSaison.Text = ep.Resume;
            Form.lblDateSaison.Text = "Episode diffusé le " + ep.DatePremDiff.Value.ToShortDateString();
            Form.lblTitreEp.Text = "Détail l'épisode: " + ep.Nom;
        }

        private void OpenForm(object sender, EventArgs e)
        {
            Form.Show();
        }
    }
}
