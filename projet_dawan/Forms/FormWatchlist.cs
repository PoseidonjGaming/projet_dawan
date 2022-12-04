using Newtonsoft.Json;
using projet_dawan.Models;

namespace projet_dawan
{
    public partial class FormWatchlist : Form
    {
        public FormWatchlist()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Serie> list = Properties.Settings.Default.UserRemain.ToWatch;
            //List<int> list = new() { 1, 2, 3, 4, 5 };
            File.WriteAllText(@"C:\Users\Admin Stagiaire\Desktop\export.json", JsonConvert.SerializeObject(list, Formatting.Indented));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserRemain.ToWatch = new();
            Properties.Settings.Default.Save();
        }
    }
}
