using projet_dawan.Forms;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_dawan.FormLogic
{
    internal class LogicManageEpisode
    {
        private EpisodeService service = new();
        private List<Episode> episodes = new List<Episode>();
        private List<Serie> serieList = new List<Serie>();
        private Saison saison = new();

        public FormManageEpisode Form { get; set; }

        public LogicManageEpisode(FormManageEpisode form)
        {
            Form= form;
        }

        public void Load()
        {
            SerieService serieService = new();
            serieList = serieService.GetAll();
            foreach (Serie serie in serieList)
            {
                Form.GetComboBoxSerie().Items.Add(serie.Nom);
            }
            if (serieList.Count > 0)
            {
                Form.GetComboBoxSerie().SelectedIndex = 0;
            }
            SaisonService saisonService = new SaisonService();

            Form.GetNumericSaison().Maximum = saisonService.GetSaisonsBySerie(serieList.FirstOrDefault().Id).MaxBy(e => e.Numero).Numero;
            Populate();
        }

        public void BtnAjouter_Click()
        {
            SaisonService saisonService = new SaisonService();
            List<Saison> saisonList = saisonService.GetSaisonsBySerie(serieList[Form.GetComboBoxSerie().SelectedIndex].Id);
            if (Form.GetTextBoxNom().Text != string.Empty && Form.GetTextBoxResume().Text != string.Empty
                && Form.GetNumericSaison().Value != 0)
            {
                Saison saison = (Saison)saisonList.Where(e => e.Numero == Form.GetNumericSaison().Value);
                saison.NbEpisode++;
                saisonService.Update(saison);
                Episode ep = new()
                {
                    Nom = Form.GetTextBoxNom().Text,
                    Resume = Form.GetTextBoxNom().Text,
                    DatePremDiff = Form.GetDateTimeDatePremDiff().Value,
                    SaisonId = saison.Id
                };

            }

            if (Form.GetCheckBoxLasEp().Checked)
            {
                Saison saison = new Saison
                {
                    NbEpisode = 0,
                    SerieId = serieList[Form.GetComboBoxSerie().SelectedIndex].Id,
                    Numero = saisonList.Max(e => e.Numero)
                };
                saison.Numero++;
                saisonService.Add(saison);
            }
        }

        public void CmbSerie_SelectedIndexChanged()
        {
            SaisonService saisonService = new SaisonService();
            Form.GetNumericSaison().Maximum = saisonService.GetSaisonsBySerie(serieList[Form.GetComboBoxSerie().SelectedIndex].Id).MaxBy(e => e.Numero).Numero;
        }


        public void LstBoxEpisode_SelectedIndexChanged()
        {
            if (Form.GetListBoxEpisode().SelectedItems.Count != -1)
            {
                Episode ep = episodes[Form.GetListBoxEpisode().SelectedIndex];
                Form.GetTextBoxNom().Text = ep.Nom;
                Form.GetTextBoxResume().Text = ep.Resume;
                Form.GetDateTimeDatePremDiff().Value = (DateTime)ep.DatePremDiff;
                SaisonService saisonService = new();
                saison = saisonService.GetById(episodes[Form.GetListBoxEpisode().SelectedIndex].SaisonId);
                Form.GetNumericSaison().Value = saisonService.GetById(ep.SaisonId).Numero;
                Form.GetComboBoxSerie().SelectedIndex = serieList.IndexOf(serieList.Where(s => s.Id == saison.SerieId).SingleOrDefault());
            }
        }

        public void BtnSup_Click()
        {
            if (Form.GetListBoxEpisode().SelectedIndex != -1)
            {
                var annuler = MessageBox.Show("Etes vous sur de vouloir annuler l'ajout ?", "Annuler ajout ?",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (annuler == DialogResult.Yes)
                {
                    EpisodeService service = new();
                    service.Delete(episodes[Form.GetListBoxEpisode().SelectedIndex]);
                }
                Populate();
            }
        }


        private void Populate()
        {
            Form.GetListBoxEpisode().Items.Clear();
            episodes.Clear();
            episodes = service.GetAll();
            foreach (Episode episode in episodes)
            {
                Form.GetListBoxEpisode().Items.Add(episode.Nom);
            }

        }
    }
}
