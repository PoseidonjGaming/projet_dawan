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
    internal class LogicManagePerso
    {
        public FormManagePerso Form { get; set; }
        private List<Personnage> personnages = new List<Personnage>();
        private List<Serie> serieList = new List<Serie>();
        private List<Acteur> acteurList = new List<Acteur>();
        private PersonnageService servicePerso = new();

        public LogicManagePerso(FormManagePerso form)
        {
            Form = form;
        }

        public void Load()
        {
            SerieService serieService = new();
            serieList = serieService.GetAll();
            foreach (Serie serie in serieList)
            {
                Form.GetComboBoxSerie().Items.Add(serie.Nom);
            }
            if (serieList.Count > 0)
            {
                Form.GetComboBoxSerie().SelectedIndex = 0;
            }

            ActeurService acteurService = new();
            acteurList = acteurService.GetAll();
            foreach (Acteur acteur in acteurList)
            {
                Form.GetComboBoxActeur().Items.Add(acteur.Prenom + " " + acteur.Nom);
            }
            if (acteurList.Count > 0)
            {
                Form.GetComboBoxActeur().SelectedIndex = 0;
            }

            populate();
        }

        public void BtnAjouter_Click()
        {
            if (Form.GetTextBoxNomPerso().Text != string.Empty)
            {
                // ajouter le personnage
                Personnage perso = new()
                {
                    Nom = Form.GetTextBoxNomPerso().Text,
                    ActeurId = acteurList[Form.GetComboBoxActeur().SelectedIndex].Id,
                    SerieId = serieList[Form.GetComboBoxSerie().SelectedIndex].Id,
                };

                servicePerso.Add(perso);
                populate();

                MessageBox.Show("Personnage ajouté");
            }
        }

        public void BtnSuppr_Click()
        {
            if (Form.GetListBoxPerso().SelectedIndex != -1)
            {
                servicePerso.Delete(personnages[Form.GetListBoxPerso().SelectedIndex]);
                populate();

                MessageBox.Show("Personnage supprimé");
            }
        }

        public void ListBoxPerso_SelectedIndexChanged()
        {
            Personnage perso = personnages[Form.GetListBoxPerso().SelectedIndex];
            Form.GetTextBoxNomPerso().Text = perso.Nom;
            Acteur acteur = acteurList.Find(a => a.Id == perso.ActeurId);
            
            Form.GetComboBoxActeur().SelectedIndex = acteurList.IndexOf(acteur);
            Serie serie = serieList.Find(s => s.Id == perso.SerieId);
            Form.GetComboBoxSerie().SelectedIndex = serieList.IndexOf(serie);
        }

        private void populate()
        {
            Form.GetListBoxPerso().Items.Clear();
            personnages = servicePerso.GetAll();
            foreach (Personnage perso in personnages)
            {
                Form.GetListBoxPerso().Items.Add(perso.Nom);
            }
        }
    }
}
