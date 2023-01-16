using projet_dawan_WPF.Logic.Autre;
using projet_dawan_WPF.Windows.Manage;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System.Collections.Generic;
using System.Windows;

namespace projet_dawan_WPF.Logic.Manage
{
    internal class LogicManagePerso
    {
        public WindowManagePersonnages Window { get; set; }
        private List<Personnage> personnages;
        private List<Serie> serieList;
        private List<Acteur> acteurList;
        private readonly PersonnageService servicePerso;

        public LogicManagePerso(WindowManagePersonnages form)
        {
            Window = form;
            servicePerso = new();
            personnages = new();
            serieList = new();
            acteurList = new();
            servicePerso = new();
        }

        public void Load()
        {
            SerieService serieService = new();
            serieList = serieService.GetAll();
            foreach (Serie serie in serieList)
            {
                Window.comboBoxSerie.Items.Add(serie.Nom);
            }
            if (serieList.Count > 0)
            {
                Window.comboBoxSerie.SelectedIndex = 0;
            }

            ActeurService acteurService = new();
            acteurList = acteurService.GetAll();
            foreach (Acteur acteur in acteurList)
            {
                Window.comboBoxActeur.Items.Add(acteur.Prenom + " " + acteur.Nom);
            }
            if (acteurList.Count > 0)
            {
                Window.comboBoxActeur.SelectedIndex = 0;
            }

            Populate();
        }

        public void BtnAjouter_Click()
        {
            if (Window.txtBoxNom.Text != string.Empty)
            {
                if (Window.listBoxPerso.SelectedIndex != -1)
                {
                    Personnage perso = personnages[Window.listBoxPerso.SelectedIndex];
                    perso.Nom = Window.txtBoxNom.Text;
                    perso.SerieId = serieList[Window.comboBoxSerie.SelectedIndex].Id;
                    perso.ActeurId = acteurList[Window.comboBoxActeur.SelectedIndex].Id;
                    servicePerso.Update(perso);
                    MessageBox.Show("Personnage modifié");
                }
                else
                {
                    Personnage perso = new()
                    {
                        Nom = Window.txtBoxNom.Text,
                        ActeurId = acteurList[Window.comboBoxActeur.SelectedIndex].Id,
                        SerieId = serieList[Window.comboBoxSerie.SelectedIndex].Id,
                    };

                    servicePerso.Add(perso);
                    MessageBox.Show("Personnage ajouté");
                }

                Populate();


            }
        }

        public void BtnAnnuler_Click()
        {
            Window.txtBoxNom.Clear();
            Window.txtBoxResume.Clear();
            Window.listBoxPerso.Items.Clear();
            Window.comboBoxActeur.SelectedIndex = 0;
            Window.comboBoxSerie.SelectedIndex = 0;
            Window.listBoxPerso.SelectedIndex = -1;
        }

        public void BtnSuppr_Click()
        {
            if (Window.listBoxPerso.SelectedIndex != -1)
            {
                servicePerso.Delete(personnages[Window.listBoxPerso.SelectedIndex]);
                Populate();

                MessageBox.Show("Personnage supprimé");
            }
        }

        public void ListBoxPerso_SelectedIndexChanged()
        {
            Personnage perso = personnages[Window.listBoxPerso.SelectedIndex];
            Window.txtBoxNom.Text = perso.Nom;
            Acteur acteur = acteurList.Find(a => a.Id == perso.ActeurId);

            Window.comboBoxActeur.SelectedIndex = acteurList.IndexOf(acteur);
            Serie serie = serieList.Find(s => s.Id == perso.SerieId);
            Window.comboBoxSerie.SelectedIndex = serieList.IndexOf(serie);
        }

        private void Populate()
        {
            BtnAnnuler_Click();
            personnages = servicePerso.GetAll();
            foreach (Personnage perso in personnages)
            {
                Window.listBoxPerso.Items.Add(perso.Nom);
            }
        }
    }
}
