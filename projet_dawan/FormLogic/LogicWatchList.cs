using Newtonsoft.Json;
using SerieDLL_EF.Models;
using SerieDLL_EF.Repository;
using SerieDLL_EF.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            foreach (int serieid in Properties.Settings.Default.UserRemain.ToWatchList)
            {
                Serie serie = service.GetById(serieid);
                series.Add(serie);
                Form.lstBoxWatchlist.Items.Add(serie.Nom);
            }
        }

        public void BtnClearAll_Click()
        {
            Properties.Settings.Default.UserRemain.ToWatchList.Clear();
            Properties.Settings.Default.UserRemain.ToWatch = string.Empty;
            Properties.Settings.Default.Save();
            UserService service= new();
            service.Update(Properties.Settings.Default.UserRemain);
            Form.lstBoxWatchlist.Items.Clear();
        }

        public void BtnExportList_Click()
        {
            Form.saveFileDialogWatchList.InitialDirectory = Directory.GetCurrentDirectory();
            Form.saveFileDialogWatchList.FileName = $"exports.json";
            Form.saveFileDialogWatchList.Filter = $"File JSON|*json";
            Form.saveFileDialogWatchList.Title = $"Save WatchList";

            if (Form.saveFileDialogWatchList.ShowDialog() == DialogResult.OK)
            {
                SerieService service = new();
                List<Serie> list = service.Export(Properties.Settings.Default.UserRemain.ToWatchList);

                File.WriteAllText(Form.saveFileDialogWatchList.FileName, JsonConvert.SerializeObject(list, Formatting.Indented));
            }

        }

        public void Import()
        {
            Form.openFileDialogLoad.InitialDirectory = Directory.GetCurrentDirectory();
            Form.openFileDialogLoad.FileName = $"exports.json";
            Form.openFileDialogLoad.Filter = $"File JSON|*json";
            Form.openFileDialogLoad.Title = $"Load WatchList";
            if (Form.openFileDialogLoad.ShowDialog() == DialogResult.OK)
            {
                List<Serie> list = new List<Serie>();
                using (StreamReader file = File.OpenText(Form.openFileDialogLoad.FileName))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    list = (List<Serie>)serializer.Deserialize(file, typeof(List<Serie>));
                }
                Form.lstBoxWatchlist.Items.Clear();
                Properties.Settings.Default.UserRemain.ToWatchList.Clear();
                Properties.Settings.Default.UserRemain.SetToWatchList(list);
                Properties.Settings.Default.Save();
                Load();
                UserService service= new();
                service.Update(Properties.Settings.Default.UserRemain);
            }
        }
    }
}
