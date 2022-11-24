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
            Orm orm = new SerieRepository();
            /*string query = orm.Select("*").From("serie")
                .Join("serie","id","personnage","id").OrderBy("id", "desc").Build() ;
            MessageBox.Show(query);*/
            SerieDAO dao = new("Data Source=P3570-7D6Q;Initial Catalog=serie_list;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            /*Serie serie = new()
            {
                Name = "test",
                DateDiff = DateTime.Now,
                Resume = "test 123 123",
                Affiche = "affiche.png",
                UrlBa = "youtube.com"
            };
            dao.Add(serie);
            MessageBox.Show(dao.GetAll().Count.ToString());*/

            dao.Delete(5);
            MessageBox.Show(dao.GetAll().Count.ToString());


        }
    }
}