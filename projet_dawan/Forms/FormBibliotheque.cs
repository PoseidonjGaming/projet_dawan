﻿using projet_dawan.Models;
using projet_dawan_WinForm;
using SerieDLL_EF.Repository;

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
            //serieList = .GetByTxt(txtRechercher.Text);
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
                Properties.Settings.Default.UserRemain.ToWatch.Add(serie.Id);
                Properties.Settings.Default.Save();
            }
        }

        private void FormBibliotheque_Load(object sender, EventArgs e)
        {
            cmbFiltrer.Items.AddRange(new string[] {"Serie", "Episode", "Personnage", "Acteur"});
            cmbFiltrer.SelectedIndex = 0;
        }

        private void Check()
        {
            switch (cmbFiltrer.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("Test");
                    break;
                default:
                    break;
            }
            MessageBox.Show("TestA");
        }
    }
}
