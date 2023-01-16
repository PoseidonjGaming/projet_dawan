using projet_dawan_WPF.Logic.Autre;
using projet_dawan_WPF.Windows.Manage;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System.Collections.Generic;

namespace projet_dawan_WPF.Logic.Manage
{
    internal class LogicManageActeur
    {
        public WindowManageActeur Window { get; set; }
        private readonly ActeurService service;
        private List<Acteur> acteurs;

        public LogicManageActeur(WindowManageActeur window)
        {
            Window = window;
            service = new();
            acteurs = new();
        }

        public void Load()
        {
            Populate();
        }

        public void BtnNewActeur_Click()
        {
            Window.txtBoxNom.Clear();
            Window.txtBoxPrenom.Clear();
        }

        public void SelectIndexChanged()
        {
            if (Window.lstBoxActeur.SelectedIndex != -1)
            {
                Acteur acteur = acteurs[Window.lstBoxActeur.SelectedIndex];
                Window.txtBoxNom.Text = acteur.Nom;
                Window.txtBoxPrenom.Text = acteur.Prenom;
            }
        }

        public void Add_Cick()
        {
            if (Window.txtBoxPrenom.Text != string.Empty && Window.txtBoxNom.Text != string.Empty)
            {
                Acteur acteur = new()
                {
                    Nom = Window.txtBoxNom.Text,
                    Prenom = Window.txtBoxPrenom.Text
                };
                if (!service.CompareTo(acteur))
                {
                    service.Add(acteur);
                }
                else
                {
                    acteur=service.GetCompareTo(acteur);
                    acteur.Nom = Window.txtBoxNom.Text;
                    acteur.Prenom = Window.txtBoxPrenom.Text;
                    service.Update(acteur);
                }

            }
            Populate();
        }

        public void Sup_Click()
        {
            Acteur acteur = acteurs[Window.lstBoxActeur.SelectedIndex];
            if (service.CompareTo(acteur))
            {
                service.Delete(acteur);
            }
            Populate();
        }

        private void Populate()
        {
            Window.lstBoxActeur.Items.Clear();
            Window.txtBoxNom.Clear();
            Window.txtBoxPrenom.Clear();
            acteurs = service.GetAll();
            foreach (Acteur act in acteurs)
            {
                Window.lstBoxActeur.Items.Add(act.Prenom + " " + act.Nom);
            }
        }

    }
}
