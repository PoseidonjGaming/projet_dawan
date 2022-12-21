﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projet_dawan.FormLogic;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;

namespace projet_dawan.Forms
{
    public partial class FormMangaPerso : Form
    {
        private LogicManagePerso managePerso;
        public FormMangaPerso()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            managePerso = new(this);
        }

        private void FormAjoutPerso_Load(object sender, EventArgs e)
        {
            managePerso.Load();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
           managePerso.BtnAjouter_Click();
        }

        private void btnSuppr_Click(object sender, EventArgs e)
        {
            managePerso.BtnSuppr_Click();
        }
    }
}
