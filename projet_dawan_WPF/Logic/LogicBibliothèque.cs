using projet_dawan_WPF.Windows;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System.Collections.Generic;
using System.Windows;

namespace projet_dawan_WPF.Logic
{

    internal class LogicBibliothèque
    {
        public WindowBibliotheque Windows { get; set; }
        private List<int> Ids = new List<int>();

        public LogicBibliothèque(WindowBibliotheque form)
        {
            Windows = form;
        }

        public void Load(string text)
        {
            string[] items = new string[] { "Serie", "Episode", "Personnage", "Acteur" };
            foreach (string item in items)
            {
                Windows.cmbFiltrer.Items.Add(item);
            }

            Windows.cmbFiltrer.SelectedIndex = 0;
            Windows.txtRechercher.Text = text;
        }

        public void ChangeText()
        {
            Ids.Clear();
            Windows.lstBxSerie.Items.Clear();
            Check();
        }

        public void CmbFiltrer_SelectedIndexChanged()
        {
            if (Windows.cmbFiltrer.SelectedIndex != -1)
            {
                Windows.lstBxSerie.Items.Clear();
                Ids.Clear();
                Check();
            }
        }

        public void Detail()
        {

            if (Windows.cmbFiltrer.SelectedIndex != -1)
            {
                switch (Windows.cmbFiltrer.SelectedIndex)
                {
                    case 0:
                        //SerieService serieService = new();
                        //FormSerie formSerie = new(serieService.GetById(Ids[Windows.GetListBoxSerie().SelectedIndex]));
                        //formSerie.ShowDialog(Windows);
                        break;
                    case 1:
                        EpisodeService episodeService = new();
                        //SaisonService saisonService = new();
                        //FormEpisode formEpisode = new(saisonService.GetById(episodeService.GetById(Ids[Windows.GetListBoxSerie().SelectedIndex]).SaisonId));
                        //formEpisode.ShowDialog(Windows);
                        break;
                    case 2:
                        PersonnageService personnageService = new();
                        //FormCasting formCasting = new(personnageService.GetBySerie(Ids[Windows.GetListBoxSerie().SelectedIndex]));
                        //formCasting.ShowDialog(Windows);
                        break;
                    case 3:
                        PersonnageService personnageServiceA = new();
                        //FormCasting form = new(personnageServiceA.GetByActeur(Ids[Windows.GetListBoxSerie().SelectedIndex]));
                        //form.ShowDialog(Windows);
                        break;
                    default:
                        break;
                }

            }
        }

        public void ButtonAddWich_Click()
        {
            //if (Windows.GetListBoxSerie().SelectedIndex != -1)
            //{
            //    SerieService serieService = new();
            //    Serie serie = serieService.GetById(Ids[Windows.GetListBoxSerie().SelectedIndex]);
            //    Properties.Settings.Default.UserRemain.SetToWatchList(new() { serie });
            //    Properties.Settings.Default.Save();
            //    UserService service = new();
            //    service.Update(Properties.Settings.Default.UserRemain);
            //}
        }

        public void BtnRetour_Click()
        {
            Windows.Close();
        }
        private void Check()
        {
            List<string> list = new List<string>();
            switch (Windows.cmbFiltrer.SelectedIndex)
            {
                case 0:
                    SerieService serieService = new();
                    List<Serie> series = serieService.GetByTxt(Windows.txtRechercher.Text);
                    foreach (Serie serie in series)
                    {
                        list.Add(serie.Nom);
                        Ids.Add(serie.Id);
                    }
                    Populate(list);
                    break;
                case 1:
                    EpisodeService epService = new();
                    List<Episode> episodes = epService.GetByTxt(Windows.txtRechercher.Text);
                    foreach (Episode episode in episodes)
                    {
                        list.Add(episode.Nom);
                        Ids.Add(episode.Id);
                    }
                    Populate(list);
                    break;
                case 2:
                    PersonnageService personnageService = new();
                    List<Personnage> personnages = personnageService.GetByTxt(Windows.txtRechercher.Text);
                    foreach (Personnage personnage in personnages)
                    {
                        list.Add(personnage.Nom);
                        Ids.Add(personnage.Id);
                    }
                    Populate(list);
                    break;
                case 3:
                    ActeurService acteurService = new();
                    List<Acteur> acteurs = acteurService.GetByTxt(Windows.txtRechercher.Text);
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
                Windows.lstBxSerie.Items.Add(item);
            }
        }
    }
}
