using projet_dawan.Forms;
using projet_dawan.Models;
using projet_dawan_WinForm;
using SerieDLL_EF.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace projet_dawan.FormLogic
{
   
    internal class LogicBibliothèque
    {
        public FormBibliotheque Form { get; set; }
        private List<int> Ids = new List<int>();

        public LogicBibliothèque(FormBibliotheque form)
        {
            Form = form;
        }

        public void Load(string text)
        {
            Form.cmbFiltrer.Items.AddRange(new string[] { "Serie", "Episode", "Personnage", "Acteur" });
            Form.cmbFiltrer.SelectedIndex = 0;
            Form.txtRechercher.Text = text;
        }

        public void ChangeText()
        {
            Ids.Clear();
            Form.lstBxSerie.Items.Clear();
            Check();
        }

        public void CmbFiltrer_SelectedIndexChanged()
        {
            if (Form.cmbFiltrer.SelectedIndex != -1)
            {
                Form.lstBxSerie.Items.Clear();
                Ids.Clear();
                Check();
            }
        }

        public void Detail()
        {

            if (Form.lstBxSerie.SelectedIndex != -1)
            {
                switch (Form.cmbFiltrer.SelectedIndex)
                {
                    case 0:
                        SerieService serieService = new();
                        FormSerie formSerie = new(serieService.GetById(Ids[Form.lstBxSerie.SelectedIndex]));
                        formSerie.ShowDialog(Form);
                        break;
                    case 1:
                        EpisodeService episodeService = new();
                        SaisonService saisonService = new();
                        FormEpisode formEpisode = new(saisonService.GetById(episodeService.GetById(Ids[Form.lstBxSerie.SelectedIndex]).SaisonId));
                        formEpisode.ShowDialog(Form);
                        break;
                    case 2:
                        PersonnageService personnageService = new();
                        FormCasting formCasting = new(personnageService.GetBySerie(Ids[Form.lstBxSerie.SelectedIndex]));
                        formCasting.ShowDialog(Form);
                        break;
                    case 3:
                        PersonnageService personnageServiceA = new();
                        FormCasting form = new(personnageServiceA.GetByActeur(Ids[Form.lstBxSerie.SelectedIndex]));
                        form.ShowDialog(Form);
                        break;
                    default:
                        break;
                }

            }
        }

        public void ButtonAddWich_Click()
        {
            if (Form.lstBxSerie.SelectedIndex != -1)
            {
                SerieService serieService = new();
                Serie serie = serieService.GetById(Ids[Form.lstBxSerie.SelectedIndex]);
                Properties.Settings.Default.UserRemain.SetToWatchList(new() { serie });
                Properties.Settings.Default.Save();
                UserService service = new();
                service.Update(Properties.Settings.Default.UserRemain);
            }
        }
        private void Check()
        {
            List<string> list = new List<string>();
            switch (Form.cmbFiltrer.SelectedIndex)
            {
                case 0:
                    SerieService serieService = new();
                    List<Serie> series = serieService.GetByTxt(Form.txtRechercher.Text);
                    foreach (Serie serie in series)
                    {
                        list.Add(serie.Nom);
                        Ids.Add(serie.Id);
                    }
                    Populate(list);
                    break;
                case 1:
                    EpisodeService epService = new();
                    List<Episode> episodes = epService.GetByTxt(Form.txtRechercher.Text);
                    foreach (Episode episode in episodes)
                    {
                        list.Add(episode.Nom);
                        Ids.Add(episode.Id);
                    }
                    Populate(list);
                    break;
                case 2:
                    PersonnageService personnageService = new();
                    List<Personnage> personnages = personnageService.GetByTxt(Form.txtRechercher.Text);
                    foreach (Personnage personnage in personnages)
                    {
                        list.Add(personnage.Nom);
                        Ids.Add(personnage.Id);
                    }
                    Populate(list);
                    break;
                case 3:
                    ActeurService acteurService = new();
                    List<Acteur> acteurs = acteurService.GetByTxt(Form.txtRechercher.Text);
                    foreach (Acteur acteur in acteurs)
                    {
                        list.Add(acteur.Prenom + " " + acteur.Nom);
                        Ids.Add(acteur.Id);
                    }
                    Populate(list);
                    break;

                default:
                    MessageBox.Show("Pas de Filtre seléctionné");
                    break;
            }
            
        }
        private void Populate(List<string> list)
        {
            foreach (string item in list)
            {
                Form.lstBxSerie.Items.Add(item);
            }
        }
    }
}
