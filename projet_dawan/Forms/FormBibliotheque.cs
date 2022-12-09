using projet_dawan.Forms;
using projet_dawan.Models;
using projet_dawan_WinForm;
using SerieDLL_EF.Repository;
using SerieDLL_EF.Service;

namespace projet_dawan
{
    public partial class FormBibliotheque : Form
    {
        private List<int> Ids = new List<int>();
        public FormBibliotheque(string text)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;


            txtRechercher.Text = text;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void txtRechercher_TextChanged(object sender, EventArgs e)
        {
            Ids.Clear();
            lstBxSerie.Items.Clear();
            Check();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (lstBxSerie.SelectedIndex != -1)
            {
                switch (cmbFiltrer.SelectedIndex)
                {
                    case 0:
                        SerieService serieService = new();
                        FormSerie formSerie = new(serieService.GetById(Ids[lstBxSerie.SelectedIndex]));
                        formSerie.ShowDialog(this);
                        break;
                    case 1:
                        EpisodeService episodeService = new();
                        SaisonService saisonService = new();
                        FormEpisode formEpisode = new(saisonService.GetById(episodeService.GetById(Ids[lstBxSerie.SelectedIndex]).SaisonId));
                        formEpisode.ShowDialog(this);
                        break;
                    case 2:
                        PersonnageService personnageService= new();
                        FormCasting formCasting = new(personnageService.GetBySerie(Ids[lstBxSerie.SelectedIndex]));
                        formCasting.ShowDialog(this);
                        break;
                    //case 3:
                    //    ActeurRepository acteurService= new();
                        
                    default:
                        break;
                }

            }
        }

        private void buttonAddWich_Click(object sender, EventArgs e)
        {
            if (lstBxSerie.SelectedIndex != -1)
            {
                //Serie serie = serieList[lstBxSerie.SelectedIndex];
                //Properties.Settings.Default.UserRemain.ToWatch.Add(serie.Id);
                //Properties.Settings.Default.Save();
            }
        }

        private void FormBibliotheque_Load(object sender, EventArgs e)
        {
            cmbFiltrer.Items.AddRange(new string[] { "Serie", "Episode", "Personnage", "Acteur" });
            cmbFiltrer.SelectedIndex = 0;
        }

        private void Check()
        {
            List<string> list = new List<string>();
            switch (cmbFiltrer.SelectedIndex)
            {
                case 0:
                    SerieService serieService = new();
                    List<Serie> series = serieService.GetByTxt(txtRechercher.Text);
                    foreach (Serie serie in series)
                    {
                        list.Add(serie.Nom);
                        Ids.Add(serie.Id);
                    }
                    Populate(list);
                    break;
                case 1:
                    EpisodeService epService = new();
                    List<Episode> episodes = epService.GetByTxt(txtRechercher.Text);
                    foreach (Episode episode in episodes)
                    {
                        list.Add(episode.Nom);
                        Ids.Add(episode.Id);
                    }
                    Populate(list);
                    break;
                case 2:
                    PersonnageService personnageService = new();
                    List<Personnage> personnages = personnageService.GetByTxt(txtRechercher.Text);
                    foreach (Personnage personnage in personnages)
                    {
                        list.Add(personnage.Nom);
                        Ids.Add(personnage.Id);
                    }
                    Populate(list);
                    break;
                case 3:
                    ActeurService acteurService = new();
                    List<Acteur> acteurs = acteurService.GetByTxt(txtRechercher.Text);
                    foreach (Acteur acteur in acteurs)
                    {
                        list.Add(acteur.Prenom + " " + acteur.Nom);
                        Ids.Add(acteur.Id);
                    }
                    Populate(list);
                    break;

                default:
                    MessageBox.Show("Pas de Filtre seléctionné");
                    break;
            }
        }

        private void cmbFiltrer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltrer.SelectedIndex != -1)
            {
                lstBxSerie.Items.Clear();
                Ids.Clear();
                Check();
            }
        }

        private void Populate(List<string> list)
        {
            foreach (string item in list)
            {
                lstBxSerie.Items.Add(item);
            }
        }


    }
}
