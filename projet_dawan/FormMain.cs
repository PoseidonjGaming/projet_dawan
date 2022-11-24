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
            Orm orm = new SerieRepository();
            string query = orm.Select("*").From().WhereByLike("resume").Build() ;
            MessageBox.Show(query);
        }
    }
}