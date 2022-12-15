using Microsoft.VisualBasic.Devices;
using Newtonsoft.Json;
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
        private LogicWatchList watchlist;
        public FormWatchlist()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            watchlist = new(this);
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            watchlist.BtnClearAll_Click();
        }

        private void btnExportList_Click(object sender, EventArgs e)
        {
            watchlist.BtnExportList_Click();
        }

        private void FormWatchlist_Load(object sender, EventArgs e)
        {
            watchlist.Load();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
           watchlist.Import();
        }

        // possibilité de supprimer l'élément de la listbox séléctionné
    }
}
