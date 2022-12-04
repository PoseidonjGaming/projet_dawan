using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Properties.Settings.Default.UserRemain.ToWatch.Clear();
            Properties.Settings.Default.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string json=JsonConvert.SerializeObject(Properties.Settings.Default.UserRemain.ToWatch,Formatting.Indented);
            MessageBox.Show(json);
        }
    }
}
