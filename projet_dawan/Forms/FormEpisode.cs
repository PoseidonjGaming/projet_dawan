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
        
        private Episodes episodes;
        public FormEpisode(Saison saison)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
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

       
    }
}
