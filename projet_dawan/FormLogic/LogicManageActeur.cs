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
            Form.GetTextBoxNom().Clear();
            Form.GetTextBoxPrenom().Clear();
        }

        public void SelectIndexChanged()
        {
            if (Form.GetListBoxActeur().SelectedIndex != -1)
            {
                currentActeur = acteurs[Form.GetListBoxActeur().SelectedIndex];
                Form.GetTextBoxNom().Text = currentActeur.Nom;
                Form.GetTextBoxPrenom().Text = currentActeur.Prenom;
            }
        }

        public void Add_Cick()
        {
            if (Form.GetTextBoxPrenom().Text != string.Empty && Form.GetTextBoxNom().Text != string.Empty)
            {
                currentActeur.Prenom = Form.GetTextBoxPrenom().Text;
                currentActeur.Nom = Form.GetTextBoxNom().Text;
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
            Form.GetListBoxActeur().Items.Clear();
            Form.GetTextBoxNom().Clear();
            Form.GetTextBoxPrenom().Clear();
            acteurs = service.GetAll();
            foreach (Acteur act in acteurs)
            {
                Form.GetListBoxActeur().Items.Add(act.Prenom + " " + act.Nom);
            }
        }

    }
}
