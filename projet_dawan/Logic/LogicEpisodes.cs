using projet_dawan.Forms;
using projet_dawan_WinForm;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;

namespace projet_dawan.FormLogic
{
    internal class LogicEpisodes
    {
        private Saison saison;
        private List<Episode> episodes = new List<Episode>();
        private EpisodeService service = new();
        public FormEpisode Form { get; set; }

        public LogicEpisodes(FormEpisode form)
        {
            Form = form;
        }

        public void Load(Saison saison)
        {
            this.saison = saison;
            episodes = service.GetBySaison(saison.Id);
            SerieService serieService = new();
            Serie serie = serieService.GetById(saison.SerieId);
            Form.GetPictureBoxSaison().ImageLocation = Directory.GetCurrentDirectory() + "\\Photo\\" + serie.Affiche;
            Form.GetLabelSerie().Text = serie.Nom;
            Form.GetLabelSaison().Text += saison.Numero.ToString();

            foreach (Episode episode in service.GetBySaison(saison.Id))
            {
                episodes.Add(episode);
                Form.GetListBoxEpisode().Items.Add(episode.Nom);
            }
            if (Form.GetListBoxEpisode().Items.Count > 0)
            {
                Populate(episodes[0]);
            }
        }

        public void LstBoxEpisode_SelectedIndexChanged()
        {
            if (Form.GetListBoxEpisode().SelectedIndex != -1)
            {
                Episode ep = episodes[Form.GetListBoxEpisode().SelectedIndex];
                Populate(ep);
            }
        }

        public void Casting_Click()
        {
            SerieService serieService = new();
            SaisonService saisonService = new();
            PersonnageService personnage = new();
            FormCasting casting = new(personnage.GetBySerie(serieService.GetById(saisonService.GetById(episodes[Form.GetListBoxEpisode().SelectedIndex].SaisonId).SerieId).Id));

            casting.ShowDialog();
        }

        private void Populate(Episode ep)
        {
            Form.GetTextBoxResumeSaison().Text = ep.Resume;
            Form.GetLabelDateSaison().Text = "Episode diffusé le " + ep.DatePremDiff.Value.ToShortDateString();
            Form.GetLabelTitreEp().Text = "Détail l'épisode: " + ep.Nom;
        }

        private void OpenForm(object sender, EventArgs e)
        {
            Form.Show();
        }
    }
}
