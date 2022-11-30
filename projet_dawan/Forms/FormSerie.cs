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
        private UserApp user;
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
            SaisonDAO dao = new SaisonDAO(Settings.Default.Connection);
            foreach (Saison saison in dao.GetSaisons(Serie.Id))
            {
                Saisons.Add(saison);
                lstBoxSaison.Items.Add(saison.Num);
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
            
            MessageBox.Show(user.Towatch.Count.ToString());
            if (user.Towatch.Find(e=> e.Id == Serie.Id) == null)
            {
                
                user.Towatch.Add(Serie);
                
                Settings.Default.UserRemain = user;
                MessageBox.Show(user.Towatch.Count.ToString());
                //Settings.Default.Save();
            }


        }
    }
}