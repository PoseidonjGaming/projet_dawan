using projet_dawan_WPF.Windows.Manage;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace projet_dawan_WPF.Logic.Manage
{
    internal class LogicManageSerie
    {
        public WindowManageSeries Window { get; set; }
        private SerieService serieService = new();
        private List<Serie> serieList = new();

        public LogicManageSerie(WindowManageSeries window)
        {
            Window = window;
        }

        public void Load()
        {
            Populate();
        }

        public void BtnAjouter_Click()
        {
            if (Window.txtNomSerie.Text != string.Empty && Window.txtResume.Text != string.Empty
                && Window.txtPathAffiche.Text != string.Empty)
            {
                if (Window.lstBoxSerie.SelectedIndex != -1)
                {
                    Serie serie = serieList[Window.lstBoxSerie.SelectedIndex];
                    serie.Affiche = Window.txtPathAffiche.Text;
                    serie.Nom = Window.txtNomSerie.Text;
                    serie.Resume = Window.txtResume.Text;
                    serie.UrlBa = Window.txtUrlBa.Text;
                    serie.DateDiff = Window.dateTimeSortie.SelectedDate;
                    serieService.Update(serie);
                }
                else
                {
                    Serie serie = new()
                    {
                        Nom = Window.txtNomSerie.Text,
                        DateDiff = Window.dateTimeSortie.SelectedDate,
                        Resume = Window.txtResume.Text,
                        UrlBa = Window.txtUrlBa.Text,
                        Affiche = Path.GetFileName(Window.txtPathAffiche.Text)

                    };
                    File.Copy(Window.txtPathAffiche.Text, Directory.GetCurrentDirectory() + "\\Photo\\" + serie.Affiche);
                    serieService.Add(serie);
                }
                Populate();
            }
            else
            {
                MessageBox.Show("Champs Obligatoires Incorrects");
            }
        }

        public void BtnSup_Click()
        {
            var annuler = MessageBox.Show("Etes vous sur de vouloir supprimé cette série ?", "Supprimer la série ?",
                MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (annuler == MessageBoxResult.Yes)
            {
                try
                {
                    SerieService service = new();
                    PersonnageService personnageService = new();
                    SaisonService saisonService = new();
                    EpisodeService episodeService = new();
                    Serie serie = serieList[Window.lstBoxSerie.SelectedIndex];
                    serie.Personnages = personnageService.GetBySerie(serie.Id);
                    serie.Saisons = saisonService.GetSaisonsBySerie(serie.Id);
                    foreach (Personnage personnage in serie.Personnages)
                    {
                        personnageService.Delete(personnage);
                    }
                    serie.Personnages.Clear();
                    foreach (Saison saison in serie.Saisons)
                    {
                        saison.Episodes = episodeService.GetBySaison(saison.Id);
                        foreach (Episode episode in saison.Episodes)
                        {
                            episodeService.Delete(episode);
                        }
                        saisonService.Delete(saison);
                    }
                    serie.Saisons.Clear();
                    service.Delete(serie);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
            }
            Populate();
        }



        public void LstBoxSerie_SelectedIndexChanged()
        {
            if (Window.lstBoxSerie.SelectedIndex != -1)
            {
                Serie serie = serieList[Window.lstBoxSerie.SelectedIndex];
                Window.txtNomSerie.Text = serie.Nom;
                Window.txtResume.Text = serie.Resume;
                Window.txtUrlBa.Text = serie.UrlBa;
                Window.dateTimeSortie.SelectedDate = (DateTime)serie.DateDiff;
                Window.btnAjouter.Content = "Modifier";
            }

        }

        public void BtnAnnuler_Click()
        {
            Clear();
            Window.btnAjouter.Content = "Ajouter";
        }

        private void Populate()
        {
            Clear();
            Window.lstBoxSerie.Items.Clear();
            serieList = serieService.GetAll();
            foreach (Serie serie in serieList)
            {
                Window.lstBoxSerie.Items.Add(serie.Nom);
            }
        }

        private void Clear()
        {
            Window.txtNomSerie.Clear();
            Window.txtPathAffiche.Clear();
            Window.txtUrlBa.Clear();
            Window.txtResume.Clear();
            Window.lstBoxSerie.SelectedIndex = -1;
            Window.dateTimeSortie.SelectedDate = null;
        }
    }
}
