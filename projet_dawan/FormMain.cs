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
            Orm orm = new();
            string query = orm.Select("*").From("serie").Build();
            MessageBox.Show(query);
        }
    }
}