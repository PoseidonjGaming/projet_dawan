﻿
using Microsoft.VisualBasic.Logging;
using projet_dawan_WPF.Logic.Autre;
using projet_dawan_WPF.Windows.Manage;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace projet_dawan_WPF.Logic.Manage
{
    internal class LogicManageEpisode
    {
        private EpisodeService service;
        private List<Episode> episodes;
        private List<Serie> serieList;
        private Saison saison;

        public WindowManageEpisodes Window { get; set; }

        public LogicManageEpisode(WindowManageEpisodes window)
        {
            Window = window;
            service = new();
            episodes = new();
            serieList = new();
            saison = new();
        }

        public void Load()
        {
            SerieService serieService = new();
            serieList = serieService.GetAll();
            foreach (Serie serie in serieList)
            {
                Window.cmbSerie.Items.Add(serie.Nom);
            }

            Populate();
        }

        public void BtnAjouter_Click()
        {
            SaisonService saisonService = new();
            List<Saison> saisonList = saisonService.GetSaisonsBySerie(serieList[Window.cmbSerie.SelectedIndex].Id);
            if (Window.txtBoxNom.Text != string.Empty && Window.txtBoxResume.Text != string.Empty)
            {
                Saison saison = saisonList.Where(e => e.Numero == int.Parse(Window.numSaison.Text)).FirstOrDefault();
                saison.NbEpisode++;
                saisonService.Update(saison);
                Episode ep = new()
                {
                    Nom = Window.txtBoxNom.Text,
                    Resume = Window.txtBoxResume.Text,
                    DatePremDiff = (System.DateTime)Window.datePremDiff.SelectedDate,
                    SaisonId = saison.Id
                };
                if (Window.lstBoxEpisode.SelectedIndex != -1)
                {
                    service.Update(ep);
                }
                else
                {
                    service.Add(ep);
                }



            }

            if ((bool)Window.checkBoxLastSeason.IsChecked)
            {
                Saison saison = new()
                {
                    NbEpisode = 0,
                    SerieId = serieList[Window.cmbSerie.SelectedIndex].Id,
                    Numero = saisonList.Max(e => e.Numero)
                };
                saison.Numero++;
                saisonService.Add(saison);
            }
        }

        public void BtnAnnuler_Click()
        {
            Window.txtBoxNom.Clear();
            Window.txtBoxResume.Clear();
            Window.numSaison.Text = "0";
            Window.datePremDiff.SelectedDate = null;
            Window.lstBoxEpisode.SelectedIndex = -1;
            Window.cmbSerie.SelectedIndex = -1;
        }

        public void CmbSerie_SelectedIndexChanged()
        {
            SaisonService saisonService = new();
            Window.numSaison.Text = saisonService.GetSaisonsBySerie(serieList[Window.cmbSerie.SelectedIndex].Id).MaxBy(e => e.Numero).Numero.ToString();
        }


        public void LstBoxEpisode_SelectedIndexChanged()
        {
            if (Window.lstBoxEpisode.SelectedIndex != -1)
            {
                Episode ep = episodes[Window.lstBoxEpisode.SelectedIndex];
                Window.txtBoxNom.Text = ep.Nom;
                Window.txtBoxResume.Text = ep.Resume;
                Window.datePremDiff.SelectedDate = ep.DatePremDiff;

                SaisonService saisonService = new();
                saison = saisonService.GetById(episodes[Window.lstBoxEpisode.SelectedIndex].SaisonId);
                Window.numSaison.Text = saisonService.GetById(ep.SaisonId).Numero.ToString();
                Window.cmbSerie.SelectedIndex = serieList.IndexOf(serieList.Where(s => s.Id == saison.SerieId).SingleOrDefault());
            }
        }

        public void BtnSup_Click()
        {
            if (Window.lstBoxEpisode.SelectedIndex != -1)
            {
                var annuler = MessageBox.Show("Etes vous sur de vouloir annuler l'ajout ?", "Annuler ajout ?",
                 MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (annuler == MessageBoxResult.Yes)
                {
                    EpisodeService service = new();
                    service.Delete(episodes[Window.lstBoxEpisode.SelectedIndex]);
                }
                Populate();
            }
        }

        public void BtnAddNum_Click()
        {
            int saison = int.Parse(Window.numSaison.Text);
            saison++;
            Window.numSaison.Text = saison.ToString();
        }

        public void BtnSupNum_Click()
        {
            int saison = int.Parse(Window.numSaison.Text);
            saison--;
            if (saison < 0)
            {
                Window.numSaison.Text = "0";
            }
            else
            {
                Window.numSaison.Text = saison.ToString();
            }

        }

        public void TextBox_MouseWheel(int saison)
        {
            if (saison >= 0)
            {
                BtnAddNum_Click();
            }
            else
            {
                BtnSupNum_Click();
            }
        }

        public void NumSaison_KeyUp(Key key)
        {
            if (key == Key.Up)
            {
                BtnAddNum_Click();
            }
            else if (key == Key.Down)
            {
                BtnSupNum_Click();
            }
        }


        private void Populate()
        {
            Window.lstBoxEpisode.Items.Clear();
            episodes.Clear();
            episodes = service.GetAll();
            foreach (Episode episode in episodes)
            {
                Window.lstBoxEpisode.Items.Add(episode.Nom);
            }

        }
    }
}
