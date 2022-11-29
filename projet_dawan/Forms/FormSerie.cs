using Newtonsoft.Json;
using projet_dawan.DAO;
using projet_dawan.Model;
using projet_dawan.Properties;
using SerieDLL.Interface;
using System.Configuration;

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
            
        }

        private void FormSerie_Load(object sender, EventArgs e)
        {
            Settings.Default.UserRemain.Towatch = new List<Serie>();
            lblSerie.Text = Serie.Name;
            lblDateSerie.Text = Serie.DateDiff.ToShortDateString();
            linkLblBASerie.Text = Serie.UrlBa;
            txtBoxResumeSerie.Text = Serie.Resume;
            pictureBoxSerie.ImageLocation = Directory.GetCurrentDirectory() + "\\Photo\\" + Serie.Affiche;
            SaisonDAO dao = new SaisonDAO(Settings.Default.Connection);
            foreach (Saison saison in dao.GetSaisons(Serie.Id))
            {
                Saisons.Add(saison);
                lstBoxSaison.Items.Add(saison.Num);
            }
        }

        private void btnCasting_Click(object sender, EventArgs e)
        {

        }

        private void lstBoxSaison_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBoxSaison.SelectedIndex != -1)
            {
                Saison saison = Saisons[lstBoxSaison.SelectedIndex];
                FormSaison formSaison = new(saison);
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
            if (Settings.Default.UserRemain.Towatch.Find(e => e.Id == Serie.Id) == null)
            {
                Settings.Default.UserRemain.Towatch.Add(Serie);
                Settings.Default.Save();
            }
            UserApp user = Settings.Default.UserRemain;
            string jsonUser = JsonConvert.SerializeObject(user, Formatting.Indented);
            MessageBox.Show(jsonUser);

        }
    }
}