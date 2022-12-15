<<<<<<< HEAD
﻿using Newtonsoft.Json;
=======
﻿using Microsoft.VisualBasic.Devices;
using Newtonsoft.Json;
>>>>>>> f984640f1965c9eef8b8e8c88742c195a1fc19ce
using projet_dawan.FormLogic;
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
<<<<<<< HEAD
        private LogicWatchList logic;
=======
        private LogicWatchList watchlist;
>>>>>>> f984640f1965c9eef8b8e8c88742c195a1fc19ce
        public FormWatchlist()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
<<<<<<< HEAD
           
=======
            watchlist = new(this);
>>>>>>> f984640f1965c9eef8b8e8c88742c195a1fc19ce
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            logic.BtnClearAll_Click();
=======
            watchlist.BtnClearAll_Click();
>>>>>>> f984640f1965c9eef8b8e8c88742c195a1fc19ce
        }

        private void btnExportList_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            logic.BtnExportList_Click();
=======
            watchlist.BtnExportList_Click();
>>>>>>> f984640f1965c9eef8b8e8c88742c195a1fc19ce
        }

        private void FormWatchlist_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            logic.Load();
=======
            watchlist.Load();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
           watchlist.Import();
>>>>>>> f984640f1965c9eef8b8e8c88742c195a1fc19ce
        }

        // possibilité de supprimer l'élément de la listbox séléctionné
    }
}
