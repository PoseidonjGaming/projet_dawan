using projet_dawan;
using projet_dawan.FormLogic;
using projet_dawan.Forms;
using projet_dawan.Models;
using SerieDLL_EF.Repository;
using SerieDLL_EF.Service;

namespace projet_dawan_WinForm
{
    public partial class FormEpisode : Form
    {
<<<<<<< HEAD
        private LogicEpisodes logicEpisodes;
=======
        
        private Episodes episodes;
>>>>>>> f984640f1965c9eef8b8e8c88742c195a1fc19ce
        public FormEpisode(Saison saison)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
<<<<<<< HEAD
            logicEpisodes.Load(saison);
        }

        private void lstBoxEpisode_SelectedIndexChanged(object sender, EventArgs e)
        {
            logicEpisodes.LstBoxEpisode_SelectedIndexChanged();
        }


        private void btnCasting_Click(object sender, EventArgs e)
        {
            logicEpisodes.Casting_Click();
        }


=======
            episodes = new(this);
            episodes.Load(saison);
            
            
        }

        

        private void lstBoxEpisode_SelectedIndexChanged(object sender, EventArgs e)
        {
            episodes.LstBoxEpisode_SelectedIndexChanged();
        }

       

        private void btnCasting_Click(object sender, EventArgs e)
        {
            //retour form casting correspondant au personnage présent dans la série
            episodes.Casting_Click();
        }

       
>>>>>>> f984640f1965c9eef8b8e8c88742c195a1fc19ce
    }
}
