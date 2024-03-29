﻿using Microsoft.Win32;
using Newtonsoft.Json;
using projet_dawan_WPF.Windows.Autre;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System.Collections.Generic;
using System.IO;

namespace projet_dawan_WPF.Logic.Autre
{
    internal class LogicWatchList
    {
        private readonly List<Serie> series;
        public WindowWatchList Window { get; set; }

        public LogicWatchList(WindowWatchList window)
        {
            Window = window;
            series = new();
        }

        public void Load()
        {
            SerieService service = new();
            foreach (int serieid in Properties.Settings.Default.UserRemain.ToWatchList)
            {
                Serie serie = service.GetById(serieid);
                series.Add(serie);
                Window.lstBoxWatchlist.Items.Add(serie.Nom);
            }
        }

        public void BtnClearAll_Click()
        {
            Properties.Settings.Default.UserRemain.ToWatchList.Clear();
            Properties.Settings.Default.UserRemain.ToWatch = string.Empty;
            Properties.Settings.Default.Save();
            UserService service = new();
            service.Update(Properties.Settings.Default.UserRemain);
            Window.lstBoxWatchlist.Items.Clear();
        }

        public void BtnExportList_Click()
        {
            SaveFileDialog save = new()
            {
                InitialDirectory = Directory.GetCurrentDirectory(),
                FileName = "exports.json",
                Filter = "File JSON|*json",
                Title = "Save WatchList"
            };

            if (save.ShowDialog() == true)
            {
                SerieService service = new();
                List<Serie> list = service.ExportWatchList(Properties.Settings.Default.UserRemain.ToWatchList);
                File.WriteAllText(save.FileName, JsonConvert.SerializeObject(list, Formatting.Indented));
            }

        }

        public void Import()
        {
            OpenFileDialog fileDialog = new()
            {
                InitialDirectory = Directory.GetCurrentDirectory(),
                FileName = string.Empty,
                Filter = "File JSON|*json",
                Title = "Load WatchList"
            };

            if (fileDialog.ShowDialog() == true)
            {
                List<Serie> list = new();
                using (StreamReader file = File.OpenText(fileDialog.FileName))
                {
                    JsonSerializer serializer = new();
                    list = (List<Serie>)serializer.Deserialize(file, typeof(List<Serie>));
                }
                Window.lstBoxWatchlist.Items.Clear();
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
