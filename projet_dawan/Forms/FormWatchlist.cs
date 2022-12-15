using Newtonsoft.Json;
using projet_dawan.Models;
using SerieDLL_EF.Repository;
using SerieDLL_EF.Service;
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
        List<Serie> series = new List<Serie>();
        public FormWatchlist()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserRemain.ToWatch.Clear();
            Properties.Settings.Default.Save();
            lstBoxWatchlist.Items.Clear();
        }

        private void btnExportList_Click(object sender, EventArgs e)
        {
            //if (saveFileDialogWatchList.ShowDialog() == DialogResult.OK)
            //{

            //    List<int> list = SaisonRepository.Export(Properties.Settings.Default.UserRemain.ToWatch);

            //    File.WriteAllText(saveFileDialogWatchList.FileName,JsonConvert.SerializeObject(list, Formatting.Indented));
            //}
        }

        private void FormWatchlist_Load(object sender, EventArgs e)
        {
            SerieService service = new();
            foreach (int serieid in Properties.Settings.Default.UserRemain.ToWatch)
            {
                Serie serie = service.GetById(serieid);
                series.Add(serie);
                lstBoxWatchlist.Items.Add(serie.Nom);
            }
        }

        // possibilité de supprimer l'élément de la listbox séléctionné
    }
}
