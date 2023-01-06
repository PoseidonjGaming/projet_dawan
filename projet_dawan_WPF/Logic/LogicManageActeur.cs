using projet_dawan_WPF.Window.Manage;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System.Collections.Generic;

namespace projet_dawan_WPF.Logic
{
    internal class LogicManageActeur
    {
        public WindowManageActeur Window { get; set; }

        private Acteur currentActeur;
        private ActeurService service = new();
        private List<Acteur> acteurs = new();
        public LogicManageActeur(WindowManageActeur window)
        {
            Window = window;
            currentActeur = new Acteur();
        }

        public void Load()
        {
            acteurs = service.GetAll();
            Populate();
        }

        public void BtnNewActeur_Click()
        {
            currentActeur = new();
            Window.txtBoxNom.Clear();
            Window.txtBoxPrenom.Clear();
        }

        public void SelectIndexChanged()
        {
            if (Window.lstBoxActeur.SelectedIndex != -1)
            {
                currentActeur = acteurs[Window.lstBoxActeur.SelectedIndex];
                Window.txtBoxNom.Text = currentActeur.Nom;
                Window.txtBoxPrenom.Text = currentActeur.Prenom;
            }
        }

        public void Add_Cick()
        {
            if (Window.txtBoxPrenom.Text != string.Empty && Window.txtBoxNom.Text != string.Empty)
            {
                currentActeur.Prenom = Window.txtBoxPrenom.Text;
                currentActeur.Nom = Window.txtBoxNom.Text;
                if (currentActeur.Id == 0)
                {
                    service.Add(currentActeur);
                }
                else
                {
                    service.Update(currentActeur);
                }

            }
            Populate();
        }

        public void Sup_Click()
        {
            if (currentActeur.Id != 0)
            {
                service.Delete(currentActeur);
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
