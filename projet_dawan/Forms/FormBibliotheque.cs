using projet_dawan.DAO;
using projet_dawan.Model;
using projet_dawan_WinForm;
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
    public partial class FormBibliotheque : Form
    {
        private List<Serie> serieList = new List<Serie>();
        private SerieDAO SerieDAO = new(Properties.Settings.Default.Connection);
        public FormBibliotheque(List<Serie> series, string text)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            serieList = series;
            if (text != string.Empty)
            {
                txtRechercher.Text = text;
            }
            else
            {
                Populate();
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Populate()
        {
            foreach (Serie serie in serieList)
            {
                lstBxSerie.Items.Add(serie.Name);
            }
        }

        private void txtRechercher_TextChanged(object sender, EventArgs e)
        {
            serieList.Clear();
            lstBxSerie.Items.Clear();
            serieList = SerieDAO.GetByTxt(txtRechercher.Text);
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
            if (lstBxSerie.SelectedItems.Count > 0)
            {
                foreach (var item in lstBxSerie.SelectedItems)
                {
                    Serie serie = serieList[lstBxSerie.Items.IndexOf(item)];
                    if (!Properties.Settings.Default.UserRemain.Towatch.Contains(serie))
                    {
                        Properties.Settings.Default.UserRemain.Towatch.Add(serie);
                    }
                }
                Properties.Settings.Default.Save();
            }
        }
    }
}
