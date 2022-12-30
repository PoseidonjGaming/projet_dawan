using System;
using System.Collections.Generic;
using SerieDLL_EF.Service;
using SerieDLL_EF.Models;
using System.Windows;
using projet_dawan_WPF.Windows;
using System.Windows.Media.Imaging;
using System.IO;

namespace projet_dawan_WPF.Logic
{
    internal class LogicSerie
    {
        private Serie Serie = new();
        private List<Saison> Saisons = new List<Saison>();
        public WindowSerie Window { get; set; }

        public LogicSerie(WindowSerie window)
        {
            Window = window;

        }

        public void Load(Serie serie)
        {
            Serie = serie;
            Window.lblSerie.Content = Serie.Nom;
            Window.lblDateSerie.Content = "Diffusé à partir du" + Serie.DateDiff.ToString();
            Window.linkLblBASerie.Content = Serie.UrlBa;
            Window.txtBoxResumeSerie.Text = Serie.Resume;

            Window.affiche.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\Photo\\" + Serie.Affiche));
            SaisonService service = new SaisonService();
            foreach (Saison saison in service.GetSaisonsBySerie(Serie.Id))
            {
                Saisons.Add(saison);
                Window.lstBoxSaison.Items.Add(saison.Numero.ToString());
            }
        }

        public void BtnCasting_Click()
        {
            PersonnageService service = new PersonnageService();
            WindowCasting casting = new(service.GetBySerie(Serie.Id));
            casting.ShowDialog();
        }

        public void LstBoxSaison_SelectedIndexChanged()
        {
            //if (Form.GetListBoxSaison().SelectedIndex != -1)
            //{
            //    Saison saison = Saisons[Form.GetListBoxSaison().SelectedIndex];
            //    saison.Serie = Serie;
            //    FormEpisode formSaison = new(saison);
            //    formSaison.FormClosed += OpenForm;
            //    Form.Hide();
            //    formSaison.ShowDialog(Form);
            //}
        }

        public void ButtonToWatch_Click()
        {
            if (!Properties.Settings.Default.UserRemain.ToWatchList.Contains(Serie.Id))
            {

                Properties.Settings.Default.UserRemain.SetToWatchList(new() { Serie });
                Properties.Settings.Default.Save();
                UserService service = new();
                service.Update(Properties.Settings.Default.UserRemain);
            }
        }

        private void OpenForm(object sender, EventArgs e)
        {
            Window.Show();
        }
    }
}
