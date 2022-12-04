using projet_dawan.Models;
using projet_dawan_WinForm;

namespace projet_dawan
{
    public partial class FormBibliotheque : Form
    {
        private List<Serie> serieList = new List<Serie>();
        public FormBibliotheque(List<Serie> series, string text)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            serieList = series;
            
            txtRechercher.Text = text;
            Populate();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Populate()
        {
            foreach (Serie serie in serieList)
            {
                lstBxSerie.Items.Add(serie.Nom);
            }
        }

        private void txtRechercher_TextChanged(object sender, EventArgs e)
        {
            serieList.Clear();
            lstBxSerie.Items.Clear();
            Populate();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (lstBxSerie.SelectedIndex != -1)
            {
                Serie serie = serieList[lstBxSerie.SelectedIndex];
                FormSerie formSerie = new(serie);
                formSerie.ShowDialog(this);
            }
        }

        private void buttonAddWich_Click(object sender, EventArgs e)
        {
            if(lstBxSerie.SelectedIndex != -1)
            {
                Serie serie = serieList[lstBxSerie.SelectedIndex];
                Properties.Settings.Default.ToWatch.Add(serie);
                Properties.Settings.Default.Save();
            }
        }
    }
}
