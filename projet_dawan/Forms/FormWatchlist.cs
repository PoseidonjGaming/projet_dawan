﻿using Microsoft.VisualBasic.Devices;
using Newtonsoft.Json;
using projet_dawan.Model;
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
            List<Serie> list = Properties.Settings.Default.UserRemain.Towatch;
            //List<int> list = new() { 1, 2, 3, 4, 5 };
            MessageBox.Show(list[0].Personnages.Count.ToString());
            File.WriteAllText(@"C:\Users\Admin Stagiaire\Desktop\export.json", JsonConvert.SerializeObject(list, Formatting.Indented));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserRemain.Towatch = new();
            Properties.Settings.Default.Save();
        }
    }
}
