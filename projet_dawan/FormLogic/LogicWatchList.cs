﻿using Newtonsoft.Json;
using projet_dawan.Models;
using SerieDLL_EF.Repository;
using SerieDLL_EF.Service;
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
            if (Form.saveFileDialogWatchList.ShowDialog() == DialogResult.OK)
            {
                SerieService service = new();
                List<Serie> list = service.Export(Properties.Settings.Default.UserRemain.ToWatchList);

                File.WriteAllText(Form.saveFileDialogWatchList.FileName, JsonConvert.SerializeObject(list, Formatting.Indented));
            }

        }

        public void Import()
        {
            if (Form.openFileDialogLoad.ShowDialog() == DialogResult.OK)
            {
                List<Serie> list = new List<Serie>();
                using (StreamReader file = File.OpenText(Form.openFileDialogLoad.FileName))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    list = (List<Serie>)serializer.Deserialize(file, typeof(List<Serie>));
                }
                Properties.Settings.Default.UserRemain.SetToWatchList(list);
                Properties.Settings.Default.Save();
                Load();
                UserService service= new();
                service.Update(Properties.Settings.Default.UserRemain);
            }
        }
    }
}
