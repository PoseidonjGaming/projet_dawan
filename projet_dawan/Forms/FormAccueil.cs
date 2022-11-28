using projet_dawan.DAO;
using projet_dawan.Model;
using projet_dawan_WinForm;
using SerieDLL.Interface;

namespace projet_dawan
{
    public partial class FormAccueil : Form
    {
        private IDAOBase<Serie> serieDAO = new SerieDAO(Properties.Settings.Default.Connection);
        private string path = Directory.GetCurrentDirectory() + "\\photo\\";
        private List<Serie> serieList = new List<Serie>();
        public FormAccueil()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
            FormGererCompte compte = new();

            compte.ShowDialog();
        }

        private void watchlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // affiche la watchlist liée au compte actuel
            FormWatchlist watchlist = new();

            watchlist.ShowDialog();
        }

        private void btnNew2_Click(object sender, EventArgs e)
        {
            FormSerie formSerie = new(serieDAO.GetById(1));
            formSerie.ShowDialog(this);

        }

        private void PageAcceuil_Load(object sender, EventArgs e)
        {

            serieList = serieDAO.GetAll();
            
            Populate(4);
        }

        private void Serie_Click(object sender, EventArgs e)
        {
            Button? button = sender as Button;
            if (button != null)
            {
                Serie? serie = serieList.Find(s => s.Name == button.Text);
                if (serie != null)
                {
                    FormSerie formSerie = new(serie);
                    formSerie.ShowDialog(this);

                }

            }
            else
            {
                PictureBox? pictureBox = sender as PictureBox;
                Serie? serie = serieList.Find(s => s.Name == pictureBox.Name);
                if (serie != null)
                {
                    FormSerie formSerie = new(serie);
                    formSerie.ShowDialog(this);
                }
            }
        }

     

        private void Populate(int I)
        {
            if(serieList.Count > 0)
            {
                for (int i = 0; i < I; i++)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Location = new Point((95 * i * 2) + 25, 50);
                    pictureBox.Size = new Size(138, 170);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Name = serieList[i].Name;
                    pictureBox.ImageLocation = path + serieList[i].Affiche;
                    pictureBox.Click += Serie_Click;

                    this.Controls[this.Controls.IndexOf(groupBox1)].Controls.Add(pictureBox);

                    Button btnSerie = new Button();
                    btnSerie.Location = new Point((95 * i * 2) + 25, 225);
                    btnSerie.Size = new Size(138, 50);
                    btnSerie.Text = serieList[i].Name;
                    btnSerie.Click += Serie_Click;
                    this.Controls[this.Controls.IndexOf(groupBox1)].Controls.Add(btnSerie);
                }
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
            SerieDAO serieDAO = new(Properties.Settings.Default.Connection);
            serieList = serieDAO.GetByTxt(txtRechercher.Text);
            MessageBox.Show(serieList.Count.ToString());
            FormBibliotheque formBibliotheque = new(serieList, text);
            formBibliotheque.FormClosing += form_FormClosing;
            this.Hide();
            formBibliotheque.ShowDialog(this);
        }


    }
}
