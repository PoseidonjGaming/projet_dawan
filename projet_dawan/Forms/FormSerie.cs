using projet_dawan.DAO;
using projet_dawan.Model;
using projet_dawan.Properties;

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

            lblSerie.Text = Serie.Name;
            lblDateSerie.Text = Serie.DateDiff.ToShortDateString();
            linkLblBASerie.Text = Serie.UrlBa;
            txtBoxResumeSerie.Text = Serie.Resume;
            pictureBoxSerie.ImageLocation = Directory.GetCurrentDirectory() + "\\Photo\\" + Serie.Affiche;
            SaisonDAO dao = new(projet_dawan.Properties.Settings.Default.Connection);
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
                formSaison.ShowDialog(this);
            }
        }

        private void buttonToWatch_Click(object sender, EventArgs e)
        {
            List<Serie> series= new List<Serie>();
            series.Add(Serie);
            projet_dawan.Properties.Settings.Default.ToWatch= series;
            projet_dawan.Properties.Settings.Default.Save();
        }
    }
}