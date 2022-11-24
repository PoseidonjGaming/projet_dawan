using projet_dawan.DAO;
using projet_dawan.Model;
using projet_dawan.Repository;

namespace projet_dawan
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Orm orm = new EpisodeRepository();
            
            EpisodeDAO dao = new(Properties.Settings.Default.Connection);
            dao.Delete(1);
            
        }
    }
}