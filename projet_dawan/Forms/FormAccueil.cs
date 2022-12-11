using projet_dawan.Forms;
using projet_dawan.Models;
using projet_dawan_WinForm;
using SerieDLL_EF.Models;
using SerieDLL_EF.Repository;
using SerieDLL_EF.Service;

namespace projet_dawan
{
    public partial class FormAccueil : Form
    {
        private string path = Directory.GetCurrentDirectory() + "\\photo\\";
        private List<Serie> serieList = new List<Serie>();
        private UserApp user;
        public FormAccueil()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            user=Properties.Settings.Default.UserRemain;
        }

        private void toolStripAddSerie_Click(object sender, EventArgs e)
        {
            // affiche la page pour ajouter des séries à la base de données
            // ajouter If pour vérifier si le compte à les droits
            FormAjoutSerie add = new(new Serie());

            add.ShowDialog();
        }

        private void toolStripDeleteSerie_Click(object sender, EventArgs e)
        {
            // affiche la page pour supprimer des séries à la base de données
            // ajouter If pour vérifier si le compte à les droits
            FormSupprimerSeries supr = new();

            supr.ShowDialog();
        }

        private void toolStripBibli_Click(object sender, EventArgs e)
        {
            //affiche la page de la bibliothéque des séries de la base de données
            OpenFormBibli(string.Empty);
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
                Properties.Settings.Default.token = string.Empty;
                Properties.Settings.Default.UserRemain = null;
                Properties.Settings.Default.Save();
                this.Close();
            }

        }

        private void toolStripGerer_Click(object sender, EventArgs e)
        {
            // affiche la page de gestion du compte
            if(user.Roles>Roles.User)
            {
                FormGererCompte compte = new();

                compte.ShowDialog();
            }
            
        }

        private void watchlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // affiche la watchlist liée au compte actuel
            FormWatchlist watchlist = new();

            watchlist.ShowDialog();
        }

       

        private void PageAcceuil_Load(object sender, EventArgs e)
        {
            SerieService service = new();
            serieList = service.GetAll();
            
            Populate(4);
        }

        private void Serie_Click(object sender, EventArgs e)
        {
            Button? button = sender as Button;
            if (button != null)
            {
                Serie? serie = serieList.Find(s => s.Nom == button.Text);
                if (serie != null)
                {
                    FormSerie formSerie = new(serie);
                    formSerie.ShowDialog(this);

                }

            }
            else
            {
                PictureBox? pictureBox = sender as PictureBox;
                Serie? serie = serieList.Find(s => s.Nom == pictureBox.Name);
                if (serie != null)
                {
                    FormSerie formSerie = new(serie);
                    formSerie.ShowDialog(this);
                }
            }
        }

     

        private void Populate(int I)
        {
            for (int i = 0; i < I; i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Location = new Point((95 * i * 2) + 25, 50);
                pictureBox.Size = new Size(138, 170);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Name = serieList[i].Nom;
                pictureBox.ImageLocation = path + serieList[i].Affiche;
                pictureBox.Click += Serie_Click;

                this.Controls[this.Controls.IndexOf(groupBox1)].Controls.Add(pictureBox);

                Button btnSerie = new Button();
                btnSerie.Location = new Point((95 * i * 2) + 25, 225);
                btnSerie.Size = new Size(138, 50);
                btnSerie.Text = serieList[i].Nom;
                btnSerie.Click += Serie_Click;
                this.Controls[this.Controls.IndexOf(groupBox1)].Controls.Add(btnSerie);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            OpenFormBibli(txtRechercher.Text);
        }

        private void form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void OpenFormBibli(string text)
        {
            serieList.Clear();
            //serieList = SaisonRepository.GetByTxt(txtRechercher.Text);
            SerieService service = new();
            FormBibliotheque formBibliotheque = new(text);
            formBibliotheque.FormClosing += form_FormClosing;
            this.Hide();
            formBibliotheque.ShowDialog(this);
        }

        private void gererLesActeursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (user.Roles == Roles.SuperAdmin)
            {
                FormManageActeur formManageActeur = new();
                formManageActeur.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Test");
            }
           
        }
    }
}
