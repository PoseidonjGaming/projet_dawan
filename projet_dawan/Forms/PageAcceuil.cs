using projet_dawan.Controls;
using projet_dawan.DAO;
using projet_dawan.Model;
using projet_dawan_WinForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_dawan
{
    public partial class PageAcceuil : Form
    {
        private SerieDAO serieDAO = new(Properties.Settings.Default.Connection);
        private string path=Directory.GetCurrentDirectory()+"\\photo\\";
        private List<Serie> serieList = new List<Serie>();
        public PageAcceuil()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void toolStripAddSerie_Click(object sender, EventArgs e)
        {
            // affiche la page pour ajouter des séries à la base de données
            // ajouter If pour vérifier si le compte à les droits
            AjouterSeries add = new();

            add.ShowDialog();
        }

        private void toolStripDeleteSerie_Click(object sender, EventArgs e)
        {
            // affiche la page pour supprimer des séries à la base de données
            // ajouter If pour vérifier si le compte à les droits
            SupprimerSeries supr = new();

            supr.ShowDialog();
        }

        private void toolStripBibli_Click(object sender, EventArgs e)
        {
            // affiche la page de la bibliothéque des séries de la base de données
            PageBibliotheque bibli = new();

            bibli.ShowDialog();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var quitter = MessageBox.Show("Etes vous sur de vouloir vous quitter l'application ?", "Quitter ?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (quitter == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void toolStripDeco_Click(object sender, EventArgs e)
        {
            var deconnecter = MessageBox.Show("Etes vous sur de vouloir vous déconnecter de ce compte ?", "Se déconnecter ?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (deconnecter == DialogResult.Yes)
            {
                Close();
            }

        }

        private void toolStripGerer_Click(object sender, EventArgs e)
        {
            // affiche la page de gestion du compte
            GererCompte compte = new();

            compte.ShowDialog();
        }

        private void watchlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // affiche la watchlist liée au compte actuel
            Watchlist watchlist = new();

            watchlist.ShowDialog();
        }

        private void btnNew2_Click(object sender, EventArgs e)
        {
            FormSerie formSerie = new(serieDAO.GetById(1));
            formSerie.ShowDialog(this);

        }

        private void PageAcceuil_Load(object sender, EventArgs e)
        {
            int startPos = 27;

            serieList = serieDAO.GetAll();
            for (int i = 0; i < 4; i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Location = new Point((100 * i * 2) + 20, 60);
                pictureBox.Size = new Size(143, 179);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                MessageBox.Show(path + serieList[i].Affiche);
                pictureBox.ImageLocation = path + serieList[i].Affiche;

                this.Controls[this.Controls.IndexOf(groupBox1)].Controls.Add(pictureBox);

                Button btnSerie = new Button();
                btnSerie.Location = new Point((100 * i * 2) + 20, 245);
                btnSerie.Size = new Size(143, 50);
                btnSerie.Text= serieList[i].Name;
                btnSerie.Click += Serie_Click;
                this.Controls[this.Controls.IndexOf(groupBox1)].Controls.Add(btnSerie);
            }

        }

        private void Serie_Click(object sender, EventArgs e)
        {
            Button? button = sender as Button;
            Serie serie = serieList.Find(s => s.Name == button.Text);
            FormSerie formSerie = new(serie);
            formSerie.ShowDialog(this);
        }
    }
}
