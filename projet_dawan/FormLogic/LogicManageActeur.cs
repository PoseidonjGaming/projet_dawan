using projet_dawan.Forms;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_dawan.FormLogic
{
    internal class LogicManageActeur
    {
        public FormManageActeur Form { get; set; }

        private Acteur currentActeur;
        private ActeurService service = new();
        private List<Acteur> acteurs = new();
        public LogicManageActeur(FormManageActeur form)
        {
            Form = form;
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
            Form.txtBoxNom.Clear();
            Form.txtPrenom.Clear();
        }

        public void SelectIndexChanged()
        {
            if (Form.lstBoxActeur.SelectedIndex != -1)
            {
                currentActeur = acteurs[Form.lstBoxActeur.SelectedIndex];
                Form.txtBoxNom.Text = currentActeur.Nom;
                Form.txtPrenom.Text = currentActeur.Prenom;
            }
        }

        public void Add_Cick()
        {
            if (Form.txtPrenom.Text != string.Empty && Form.txtBoxNom.Text != string.Empty)
            {
                currentActeur.Prenom = Form.txtPrenom.Text;
                currentActeur.Nom = Form.txtBoxNom.Text;
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
            Form.lstBoxActeur.Items.Clear();
            Form.txtBoxNom.Clear();
            Form.txtPrenom.Clear();
            acteurs = service.GetAll();
            foreach (Acteur act in acteurs)
            {
                Form.lstBoxActeur.Items.Add(act.Prenom + " " + act.Nom);
            }
        }

    }
}
