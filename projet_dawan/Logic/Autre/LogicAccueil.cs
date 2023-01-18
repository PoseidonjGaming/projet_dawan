using projet_dawan.Forms;
using projet_dawan_WinForm;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;

namespace projet_dawan.Logic.Autre
{
    internal class LogicAccueil
    {
        private string path = Directory.GetCurrentDirectory() + "\\photo\\";
        private List<Serie> serieList = new List<Serie>();
        private UserApp user;
        public FormAccueil Form { get; set; }
        public LogicAccueil(FormAccueil form)
        {
            user = Properties.Settings.Default.UserRemain;
            Form = form;
        }
        public void Load()
        {
            SerieService service = new();
            serieList = service.GetAll();

            if (Properties.Settings.Default.UserRemain != null)
            {
                Form.getSeConnecter().Enabled = false;
            }

            Populate(4);
        }

        private void Populate(int I)
        {
            for (int i = 0; i < I; i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Location = new Point(95 * i * 2 + 25, 50);
                pictureBox.Size = new Size(138, 170);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Name = serieList[i].Nom;
                pictureBox.ImageLocation = path + serieList[i].Affiche;
                pictureBox.Click += Serie_Click;

                Form.Controls[Form.Controls.IndexOf(Form.GetGroupBox())].Controls.Add(pictureBox);

                Button btnSerie = new Button();
                btnSerie.Location = new Point(95 * i * 2 + 25, 225);
                btnSerie.Size = new Size(138, 50);
                btnSerie.Text = serieList[i].Nom;
                btnSerie.Click += Serie_Click;
                Form.Controls[Form.Controls.IndexOf(Form.GetGroupBox())].Controls.Add(btnSerie);
            }
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
                    formSerie.ShowDialog(Form);

                }

            }
            else
            {
                PictureBox? pictureBox = sender as PictureBox;
                Serie? serie = serieList.Find(s => s.Nom == pictureBox.Name);
                if (serie != null)
                {
                    FormSerie formSerie = new(serie);
                    formSerie.ShowDialog(Form);

                }
            }
        }

        public void Gerer_Click()
        {
            // affiche la page de gestion du compte
            if (user.Roles > Roles.User)
            {
                FormGererCompte compte = new();

                compte.ShowDialog();
            }
        }

        public void GererLesActeurs_Click()
        {
            if (user.IsGranted(Roles.SuperAdmin))
            {
                FormManageActeur formManageActeur = new();
                formManageActeur.ShowDialog(Form);
            }
            else
            {
                MessageBox.Show("Vous devez avoir le niveau accréditation requis");
            }
        }

        private void OpenFormBibli(string text)
        {

            SerieService service = new();
            FormBibliotheque formBibliotheque = new(text);
            formBibliotheque.FormClosing += Form_FormClosing;
            Form.Hide();
            formBibliotheque.ShowDialog(Form);
        }

        public void Biblio_Click()
        {
            OpenFormBibli(string.Empty);
        }

        public void Search_Click()
        {
            OpenFormBibli(Form.GetTextBoxRechercher().Text);
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form.Show();
        }

        public void Quitter_Click()
        {
            var quitter = MessageBox.Show("Etes vous sur de vouloir vous quitter l'application ?", "Quitter ?",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (quitter == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        public void Deco_Click()
        {
            if (Properties.Settings.Default.UserRemain != null)
            {
                var deconnecter = MessageBox.Show("Etes vous sur de vouloir vous déconnecter de ce compte ?", "Se déconnecter ?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (deconnecter == DialogResult.Yes)
                {
                    Properties.Settings.Default.token = string.Empty;
                    Properties.Settings.Default.UserRemain = null;
                    Properties.Settings.Default.Save();
                }
                Form.getSeConnecter().Enabled = true;
            }

        }

        public void WatchList_Click()
        {
            if (Properties.Settings.Default.UserRemain != null)
            {
                FormWatchlist watchlist = new();
                watchlist.ShowDialog();
            }

        }

        public void ManageEpisodeToolStripMenuItem_Click()
        {
            if (user.IsGranted(Roles.SuperAdmin))
            {
                FormManageEpisode form = new();
                form.ShowDialog(Form);
            }

        }

        public void ToolStripAddSerie_Click()
        {
            if (user.IsGranted(Roles.SuperAdmin))
            {
                FormManageSerie form = new FormManageSerie();
                form.ShowDialog(Form);
            }
        }

        public void gererPersonnagesToolStripMenuItem_Click()
        {
            if (user.IsGranted(Roles.SuperAdmin))
            {
                FormManagePerso form = new();
                form.ShowDialog(Form);
            }

        }

        public void SeConnecterToolStripMenuItem_Click()
        {
            FormMain formMain = new FormMain();
            formMain.FormClosed += FormClose;
            formMain.ShowDialog(Form);
        }

        private void FormClose(object sender, EventArgs e)
        {
            user = Properties.Settings.Default.UserRemain;
            Form.getSeConnecter().Enabled = false;
        }

    }
}
