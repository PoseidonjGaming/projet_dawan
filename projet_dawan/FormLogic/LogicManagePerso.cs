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
        public FormMangaPerso Form { get; set; }
        private List<Personnage> personnages = new List<Personnage>();
        private List<Serie> serieList = new List<Serie>();
        private List<Acteur> acteurList = new List<Acteur>();
        private PersonnageService servicePerso = new();

        public LogicManagePerso(FormMangaPerso form)
        {
            Form = form;
        }

        public void Load()
        {
            SerieService serieService = new();
            serieList = serieService.GetAll();
            foreach (Serie serie in serieList)
            {
                Form.comboBoxSerie.Items.Add(serie.Nom);
            }
            if (serieList.Count > 0)
            {
                Form.comboBoxSerie.SelectedIndex = 0;
            }

            ActeurService acteurService = new();
            acteurList = acteurService.GetAll();
            foreach (Acteur acteur in acteurList)
            {
                Form.comboBoxActeur.Items.Add(acteur.Prenom + " " + acteur.Nom);
            }
            if (acteurList.Count > 0)
            {
                Form.comboBoxActeur.SelectedIndex = 0;
            }

            populate();
        }

        public void BtnAjouter_Click()
        {
            if (Form.txtNomPerso.Text != string.Empty)
            {
                // ajouter le personnage
                Personnage perso = new()
                {
                    Nom = Form.txtNomPerso.Text,
                    ActeurId = acteurList[Form.comboBoxActeur.SelectedIndex].Id,
                    SerieId = serieList[Form.comboBoxSerie.SelectedIndex].Id,
                };

                servicePerso.Add(perso);
                populate();

                MessageBox.Show("Personnage ajouté");
            }
        }

        public void BtnSuppr_Click()
        {
            if (Form.listBoxPerso.SelectedIndex != -1)
            {
                servicePerso.Delete(personnages[Form.listBoxPerso.SelectedIndex]);
                populate();

                MessageBox.Show("Personnage supprimé");
            }
        }

        private void populate()
        {
            Form.listBoxPerso.Items.Clear();
            personnages = servicePerso.GetAll();
            foreach (Personnage perso in personnages)
            {
                Form.listBoxPerso.Items.Add(perso.Nom);
            }
        }
    }
}
