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
            var annuler = MessageBox.Show("Etes vous sur de vouloir annuler l'ajout ?", "Annuler ajout ?",
                MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (annuler == MessageBoxResult.Yes)
            {
                SerieService service = new();
                File.Delete(Directory.GetCurrentDirectory() + "\\Photo\\" + serieList[Window.lstBoxSerie.SelectedIndex].Affiche);
                service.Delete(serieList[Window.lstBoxSerie.SelectedIndex]);
            }
            Populate();
        }



        public void LstBoxSerie_SelectedIndexChanged()
        {
            if (Window.lstBoxSerie.SelectedIndex != -1)
            {
                Serie serie = serieList[Window.lstBoxSerie.SelectedIndex];
                Window.txtNomSerie.Text = serie.Nom;
                if (File.Exists(Directory.GetCurrentDirectory() + "\\Photo\\" + serie.Affiche))
                {
                    Window.txtPathAffiche.Text = Directory.GetCurrentDirectory() + "\\Photo\\" + serie.Affiche;
                }
                else
                {
                    Window.txtPathAffiche.Text = serie.Affiche;
                }

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
