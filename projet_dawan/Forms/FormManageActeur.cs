using projet_dawan.Models;
using SerieDLL_EF.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_dawan.Forms
{
    public partial class FormManageActeur : Form
    {
        private Acteur currentActeur;
        private ActeurService service = new();
        private List<Acteur> acteurs = new();
        public FormManageActeur()
        {
            InitializeComponent();
            currentActeur= new Acteur();
        }

        private void lstBoxActeur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBoxActeur.SelectedIndex != -1)
            {
                currentActeur = acteurs[lstBoxActeur.SelectedIndex];
                txtBoxNom.Text = currentActeur.Nom;
                txtPrenom.Text = currentActeur.Prenom;
            }
        }

        private void FormManageActeur_Load(object sender, EventArgs e)
        {
            acteurs = service.GetAll();
            Populate();
        }

        private void Populate()
        {
            lstBoxActeur.Items.Clear();
            txtBoxNom.Clear();
            txtPrenom.Clear();
            acteurs = service.GetAll();
            foreach (Acteur act in acteurs)
            {
                lstBoxActeur.Items.Add(act.Prenom + " " + act.Nom);
            }
        }

        private void btnNewActeur_Click(object sender, EventArgs e)
        {
            currentActeur = new();
            txtBoxNom.Clear();
            txtPrenom.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtPrenom.Text != string.Empty && txtBoxNom.Text != string.Empty)
            {
                currentActeur.Prenom = txtPrenom.Text;
                currentActeur.Nom = txtBoxNom.Text;
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

        private void btnSup_Click(object sender, EventArgs e)
        {
            if(currentActeur.Id != 0)
            {
                service.Delete(currentActeur);
            }
            Populate();
        }
    }
}
