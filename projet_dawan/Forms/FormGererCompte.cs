using Newtonsoft.Json;

namespace projet_dawan
{
    public partial class FormGererCompte : Form
    {
        public FormGererCompte()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //UserApp user = new();
            //user.Login = "Admin";
            //user.Password = "P@ssw0rd";
            //user.Roles = Roles.SuperAdmin;
            //UserService service = new();
            //service.Add(user);

            SerieService service = new(Cnx);
            List<Serie> series = service.GetAll();
            SaveFileDialog save = new SaveFileDialog()
            {
                InitialDirectory = Directory.GetCurrentDirectory(),
                FileName = "exports.json",
                Filter = "File JSON|*json",
                Title = "Save WatchList"
            };

            if (save.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(save.FileName, JsonConvert.SerializeObject(series, Formatting.Indented));
            }


        }
    }
}
