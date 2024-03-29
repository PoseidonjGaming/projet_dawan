﻿using projet_dawan.Forms;
using projet_dawan_WinForm;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;

namespace projet_dawan.Logic.Autre
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
            Form.GetComboBoxFilter().Items.AddRange(new string[] { "Serie", "Episode", "Personnage", "Acteur" });
            Form.GetComboBoxFilter().SelectedIndex = 0;
            Form.GetTextBoxRechercher().Text = text;
        }

        public void ChangeText()
        {
            Ids.Clear();
            Form.GetListBoxSerie().Items.Clear();
            Check();
        }

        public void CmbFiltrer_SelectedIndexChanged()
        {
            if (Form.GetComboBoxFilter().SelectedIndex != -1)
            {
                Form.GetListBoxSerie().Items.Clear();
                Ids.Clear();
                Check();
            }
        }

        public void Detail()
        {

            if (Form.GetListBoxSerie().SelectedIndex != -1)
            {
                switch (Form.GetComboBoxFilter().SelectedIndex)
                {
                    case 0:
                        SerieService serieService = new();
                        FormSerie formSerie = new(serieService.GetById(Ids[Form.GetListBoxSerie().SelectedIndex]));
                        formSerie.ShowDialog(Form);
                        break;
                    case 1:
                        EpisodeService episodeService = new();
                        SaisonService saisonService = new();
                        FormEpisode formEpisode = new(saisonService.GetById(episodeService.GetById(Ids[Form.GetListBoxSerie().SelectedIndex]).SaisonId));
                        formEpisode.ShowDialog(Form);
                        break;
                    case 2:
                        PersonnageService personnageService = new();
                        FormCasting formCasting = new(personnageService.GetBySerie(Ids[Form.GetListBoxSerie().SelectedIndex]));
                        formCasting.ShowDialog(Form);
                        break;
                    case 3:
                        PersonnageService personnageServiceA = new();
                        FormCasting form = new(personnageServiceA.GetByActeur(Ids[Form.GetListBoxSerie().SelectedIndex]));
                        form.ShowDialog(Form);
                        break;
                    default:
                        break;
                }

            }
        }

        public void ButtonAddWich_Click()
        {
            if (Form.GetListBoxSerie().SelectedIndex != -1)
            {
                SerieService serieService = new();
                Serie serie = serieService.GetById(Ids[Form.GetListBoxSerie().SelectedIndex]);
                Properties.Settings.Default.UserRemain.SetToWatchList(new() { serie });
                Properties.Settings.Default.Save();
                UserService service = new();
                service.Update(Properties.Settings.Default.UserRemain);
            }
        }

        public void BtnRetour_Click()
        {
            Form.Close();
        }
        private void Check()
        {
            List<string> list = new List<string>();
            switch (Form.GetComboBoxFilter().SelectedIndex)
            {
                case 0:
                    SerieService serieService = new();
                    List<Serie> series = serieService.GetByTxt(Form.GetTextBoxRechercher().Text);
                    foreach (Serie serie in series)
                    {
                        list.Add(serie.Nom);
                        Ids.Add(serie.Id);
                    }
                    Populate(list);
                    break;
                case 1:
                    EpisodeService epService = new();
                    List<Episode> episodes = epService.GetByTxt(Form.GetTextBoxRechercher().Text);
                    foreach (Episode episode in episodes)
                    {
                        list.Add(episode.Nom);
                        Ids.Add(episode.Id);
                    }
                    Populate(list);
                    break;
                case 2:
                    PersonnageService personnageService = new();
                    List<Personnage> personnages = personnageService.GetByTxt(Form.GetTextBoxRechercher().Text);
                    foreach (Personnage personnage in personnages)
                    {
                        list.Add(personnage.Nom);
                        Ids.Add(personnage.Id);
                    }
                    Populate(list);
                    break;
                case 3:
                    ActeurService acteurService = new();
                    List<Acteur> acteurs = acteurService.GetByTxt(Form.GetTextBoxRechercher().Text);
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
                Form.GetListBoxSerie().Items.Add(item);
            }
        }
    }
}
