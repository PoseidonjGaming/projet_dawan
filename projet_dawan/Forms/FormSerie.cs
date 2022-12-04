using Newtonsoft.Json;
using projet_dawan.Models;
using projet_dawan.Properties;
using SerieDLL_EF.Repository;
using System.Configuration;

namespace projet_dawan_WinForm
{
    public partial class FormSerie : Form
    {
        private Serie Serie = new();
        private List<Saison> Saisons = new List<Saison>();
        private UserApp user;
        public FormSerie(Serie serie)
        {
            InitializeComponent();
            Serie = serie;

        }

        private void FormSerie_Load(object sender, EventArgs e)
        {
            lblSerie.Text = Serie.Nom;
            lblDateSerie.Text = Serie.DateDiff.ToString();
            linkLblBASerie.Text = Serie.UrlBa;
            txtBoxResumeSerie.Text = Serie.Resume;
            pictureBoxSerie.ImageLocation = Directory.GetCurrentDirectory() + "\\Photo\\" + Serie.Affiche;
            foreach (Saison saison in SaisonRepository.GetSaisonsBySerie(Serie.Id))
            {
                Saisons.Add(saison);
                lstBoxSaison.Items.Add(saison.Numero);
            }
            user = Settings.Default.UserRemain;
        }

        private void btnCasting_Click(object sender, EventArgs e)
        {

        }

        private void lstBoxSaison_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBoxSaison.SelectedIndex != -1)
            {
                Saison saison = Saisons[lstBoxSaison.SelectedIndex];
                FormSaison formSaison = new(saison, Serie);
                formSaison.FormClosed += OpenForm;
                this.Hide();
                formSaison.ShowDialog(this);
            }
        }

        private void OpenForm(object sender, EventArgs e)
        {
            this.Show();
        }

        private void buttonToWatch_Click(object sender, EventArgs e)
        {
            
            if (user.ToWatch.Find(e=> e.Id == Serie.Id) == null)
            {
                
                user.ToWatch.Add(Serie);
                
                Settings.Default.UserRemain = user;
                Settings.Default.Save();
            }


        }
    }
}