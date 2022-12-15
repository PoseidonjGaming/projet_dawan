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

        private LogicEpisodes logicEpisodes;

        
        

        public FormEpisode(Saison saison)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;

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
    }
}
