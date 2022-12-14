using Newtonsoft.Json;
using projet_dawan.Models;
using SerieDLL_EF.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_dawan.FormLogic
{
    internal class LogicWatchList
    {
        private List<Serie> series = new List<Serie>();
        public FormWatchlist Form { get; set; }

        public LogicWatchList(FormWatchlist form)
        {
            Form = form;
        }

        public void Load()
        {
            SerieService service = new();
            foreach (int serieid in Properties.Settings.Default.UserRemain.ToWatch)
            {
                Serie serie = service.GetById(serieid);
                series.Add(serie);
                Form.lstBoxWatchlist.Items.Add(serie.Nom);
            }
        }

        public void BtnClearAll_Click()
        {
            Properties.Settings.Default.UserRemain.ToWatch.Clear();
            Properties.Settings.Default.Save();
            Form.lstBoxWatchlist.Items.Clear();
        }

        public void BtnExportList_Click()
        {
            if (Form.saveFileDialogWatchList.ShowDialog() == DialogResult.OK)
            {
                SerieService service = new();
                List<Serie> list = service.Export(Properties.Settings.Default.UserRemain.ToWatch);

                File.WriteAllText(Form.saveFileDialogWatchList.FileName, JsonConvert.SerializeObject(list, Formatting.Indented));
            }

        }
    }
}
