using Newtonsoft.Json;
using projet_dawan.Models;
using projet_dawan.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_dawan
{
    public partial class FormAjoutSerie : Form
    {
        private Serie serie;
        private bool ajout = true;
        public FormAjoutSerie(Serie? serie)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            if (serie == null)
            {
                this.serie = new Serie();
            }
            else
            {
                this.serie = serie;
                btnAjouter.Text = "Modifier";
                ajout = false;
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // vérifier si les champs sont valides puis ajouter la serie à la base de données
            if (txtBoxPathFile.Text != string.Empty)
            {

                List<Serie> series = JsonConvert.DeserializeObject<List<Serie>>(File.ReadAllText(txtBoxPathFile.Text));
                
                series.ForEach(s => MessageBox.Show(s.Nom));
            }
            else
            {
                if (ajout)
                {
                }
                else
                {
                }
                Close();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            var annuler = MessageBox.Show("Etes vous sur de vouloir annuler l'ajout ?", "Annuler ajout ?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (annuler == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (openFileDialogImport.ShowDialog() == DialogResult.OK)
            {
                txtBoxPathFile.Text = openFileDialogImport.FileName;
            }
        }
    }
}
