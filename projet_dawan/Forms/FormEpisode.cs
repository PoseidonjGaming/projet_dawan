﻿using projet_dawan.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_dawan_WinForm.Forms
{
    public partial class FormEpisode : Form
    {
        private Episode episode;
        public FormEpisode(Episode episode)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            this.episode = episode;
        }
    }
}
