using projet_dawan.Forms;
using projet_dawan.Models;
using SerieDLL_EF.Repository;
using SerieDLL_EF.Service;

namespace projet_dawan_WinForm
{
    public partial class FormSerie : Form
    {
        private Serie Serie = new();
        private List<Saison> Saisons = new List<Saison>();

        public FormSerie(Serie serie)
        {
            InitializeComponent();
            Serie = serie;
            //(width - 176) / 2
        }

        private void FormSerie_Load(object sender, EventArgs e)
        {
            

            lblSerie.Text = Serie.Nom;
            lblSerie.Location = new Point((this.Size.Width-lblSerie.Size.Width) / 2, lblSerie.Location.Y);
            lblDateSerie.Text = Serie.DateDiff.ToString();
            linkLblBASerie.Text = Serie.UrlBa;
            txtBoxResumeSerie.Text = Serie.Resume;
            pictureBoxSerie.ImageLocation = Directory.GetCurrentDirectory() + "\\Photo\\" + Serie.Affiche;
            SaisonService service = new SaisonService();
            foreach (Saison saison in service.GetSaisonsBySerie(Serie.Id))
            {
                Saisons.Add(saison);
                lstBoxSaison.Items.Add(saison.Numero.ToString());
            }
        }

        private void btnCasting_Click(object sender, EventArgs e)
        {
            // retour form casting correspondant au personnage présent dans la série
            PersonnageService service= new PersonnageService();
            FormCasting casting = new(service.GetBySerie(Serie.Id));
            casting.ShowDialog();
        }

        private void lstBoxSaison_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBoxSaison.SelectedIndex != -1)
            {
                Saison saison = Saisons[lstBoxSaison.SelectedIndex];
                saison.Serie = Serie;
                FormEpisode formSaison = new(saison);
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
            if (!projet_dawan.Properties.Settings.Default.UserRemain.ToWatch.Contains(Serie.Id))
            {

                projet_dawan.Properties.Settings.Default.UserRemain.ToWatch.Add(Serie.Id);
                projet_dawan.Properties.Settings.Default.Save();
            }
        }
    }
}