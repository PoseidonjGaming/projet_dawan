using projet_dawan.DAO;
using projet_dawan.Model;
using projet_dawan.Properties;

namespace projet_dawan_WinForm
{
    public partial class FormSerie : Form
    {
        private Serie Serie;
        private List<Saison> Saisons=new List<Saison>();
        
        public FormSerie(Serie serie)
        {
            InitializeComponent();
            Serie = serie;
        }

        private void FormSerie_Load(object sender, EventArgs e)
        {
            lblSerie.Text = Serie.Name;
            lblDateSerie.Text=Serie.DateDiff.ToString();
            linkLblBASerie.Text = Serie.UrlBa;
            txtBoxResumeSerie.Text = Serie.Resume;
            pictureBoxSerie.ImageLocation = Directory.GetCurrentDirectory() + "\\Photo\\" + Serie.Affiche;
            SaisonDAO dao = new(Settings.Default.Connection);
            foreach(Saison saison in dao.GetSaisons(Serie.Id))
            {
                Saisons.Add(saison);
                lstBoxSaison.Items.Add(saison.Num);
            }
        }
    }
}