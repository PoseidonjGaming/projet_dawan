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
            string query = orm.Select("*").From()
                .Join("serie","id","personnage","id").OrderBy("id", "desc").Build() ;
            MessageBox.Show(query);
        }
    }
}