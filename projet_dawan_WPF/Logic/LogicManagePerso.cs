using projet_dawan_WPF.Window;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System.Collections.Generic;
using System.Security.Cryptography.Pkcs;
using System.Windows;

namespace projet_dawan_WPF.Logic
{
    internal class LogicManagePerso
    {
        public WindowManagePersonnages Window { get; set; }
        private List<Personnage> personnages = new List<Personnage>();
        private List<Serie> serieList = new List<Serie>();
        private List<Acteur> acteurList = new List<Acteur>();
        private PersonnageService servicePerso = new();

        public LogicManagePerso(WindowManagePersonnages form)
        {
            Window = form;
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

            populate();
        }

        public void BtnAjouter_Click()
        {
            if (Window.txtBoxNom.Text != string.Empty && Window.txtBoxResume.Text != string.Empty)
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
                // ajouter le personnage

                populate();


            }
        }

        public void BtnAnnuler_Click()
        {
            Window.txtBoxNom.Clear();
            Window.txtBoxResume.Clear();
            Window.comboBoxActeur.SelectedIndex= 0;
            Window.comboBoxSerie.SelectedIndex= 0;
        }

        public void BtnSuppr_Click()
        {
            if (Window.listBoxPerso.SelectedIndex != -1)
            {
                servicePerso.Delete(personnages[Window.listBoxPerso.SelectedIndex]);
                populate();

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

        private void populate()
        {
            Window.listBoxPerso.Items.Clear();
            personnages = servicePerso.GetAll();
            foreach (Personnage perso in personnages)
            {
                Window.listBoxPerso.Items.Add(perso.Nom);
            }
        }
    }
}
