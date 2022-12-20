using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;

namespace projet_dawan.Forms
{
    public partial class FormAjoutPerso : Form
    {
        private List<Personnage> personnages = new List<Personnage>();
        private List<Serie> serieList = new List<Serie>();
        private List<Acteur> acteurList = new List<Acteur>();
        private PersonnageService servicePerso = new();

        public FormAjoutPerso()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void FormAjoutPerso_Load(object sender, EventArgs e)
        {
            SerieService serieService = new();
            serieList = serieService.GetAll();
            foreach (Serie serie in serieList)
            {
                comboBoxSerie.Items.Add(serie.Nom);
            }
            if (serieList.Count > 0)
            {
                comboBoxSerie.SelectedIndex = 0;
            }

            ActeurService acteurService = new();
            acteurList = acteurService.GetAll();
            foreach (Acteur acteur in acteurList)
            {
                comboBoxActeur.Items.Add(acteur.Prenom + " " + acteur.Nom);
            }
            if (acteurList.Count > 0)
            {
                comboBoxActeur.SelectedIndex = 0;
            }

            populate();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
           if (txtNomPerso.Text != string.Empty)
            {
                // ajouter le personnage
                Personnage perso = new()
                {
                    Nom = txtNomPerso.Text,
                    ActeurId = acteurList[comboBoxActeur.SelectedIndex].Id,
                    SerieId = serieList[comboBoxSerie.SelectedIndex].Id,
                };

                servicePerso.Add(perso);
                populate();

                MessageBox.Show("Personnage ajouté");
            }
        }

        private void populate()
        {
            listBoxPerso.Items.Clear();
            personnages = servicePerso.GetAll();
            foreach (Personnage perso in personnages)
            {
                listBoxPerso.Items.Add(perso.Nom);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listBoxPerso.SelectedIndex != -1)
            {             
                servicePerso.Delete(personnages[listBoxPerso.SelectedIndex]);
                populate();

                MessageBox.Show("Personnage supprimé");
            }
        }
    }
}
