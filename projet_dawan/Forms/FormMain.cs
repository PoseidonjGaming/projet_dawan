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
            //Orm orm = new SaisonRepository();

            SaisonDAO dao = new(Properties.Settings.Default.Connection);

            Saison serie = dao.GetById(1);
            //MessageBox.Show(serie.Name);
        }
    }
}