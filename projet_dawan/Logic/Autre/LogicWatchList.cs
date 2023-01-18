using Newtonsoft.Json;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;

namespace projet_dawan.Logic.Autre
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
                Form.GetListBoxWatch().Items.Add(serie.Nom);
            }


            Form.GetOpenFileDialogLoad().InitialDirectory = Directory.GetCurrentDirectory();
            Form.GetOpenFileDialogLoad().FileName = string.Empty;
            Form.GetOpenFileDialogLoad().Filter = "File JSON|*json";
            Form.GetOpenFileDialogLoad().Title = "Load WatchList";

            Form.GetSaveFileDialogWatchlist().InitialDirectory = Directory.GetCurrentDirectory();
            Form.GetSaveFileDialogWatchlist().FileName = "exports.json";
            Form.GetSaveFileDialogWatchlist().Filter = "File JSON|*json";
            Form.GetSaveFileDialogWatchlist().Title = "Save WatchList";
        }

        public void BtnClearAll_Click()
        {
            Properties.Settings.Default.UserRemain.ToWatchList.Clear();
            Properties.Settings.Default.UserRemain.ToWatch = string.Empty;
            Properties.Settings.Default.Save();
            UserService service = new();
            service.Update(Properties.Settings.Default.UserRemain);
            Form.GetListBoxWatch().Items.Clear();
        }

        public void BtnExportList_Click()
        {


            if (Form.GetSaveFileDialogWatchlist().ShowDialog() == DialogResult.OK)
            {
                SerieService service = new();
                List<Serie> list = service.ExportWatchList(Properties.Settings.Default.UserRemain.ToWatchList);

                File.WriteAllText(Form.GetSaveFileDialogWatchlist().FileName, JsonConvert.SerializeObject(list, Formatting.Indented));
            }

        }

        public void Import()
        {

            if (Form.GetOpenFileDialogLoad().ShowDialog() == DialogResult.OK)
            {
                List<Serie> list = new List<Serie>();
                using (StreamReader file = File.OpenText(Form.GetOpenFileDialogLoad().FileName))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    list = (List<Serie>)serializer.Deserialize(file, typeof(List<Serie>));
                }
                Form.GetListBoxWatch().Items.Clear();
                Properties.Settings.Default.UserRemain.ToWatchList.Clear();
                Properties.Settings.Default.UserRemain.SetToWatchList(list);
                Properties.Settings.Default.Save();
                Load();
                UserService service = new();
                service.Update(Properties.Settings.Default.UserRemain);
            }
        }
    }
}
