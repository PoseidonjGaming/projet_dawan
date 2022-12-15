using projet_dawan.FormLogic;
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

namespace projet_dawan.Forms
{
    public partial class FormManageActeur : Form
    {
        private LogicManageActeur manageActeur;
        public FormManageActeur()
        {
            InitializeComponent();
            manageActeur = new(this);
        }

        private void lstBoxActeur_SelectedIndexChanged(object sender, EventArgs e)
        {
            manageActeur.SelectIndexChanged();
        }

        private void FormManageActeur_Load(object sender, EventArgs e)
        {
            manageActeur.Load();
        }

        
        private void btnNewActeur_Click(object sender, EventArgs e)
        {
            manageActeur.BtnNewActeur_Click();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            manageActeur.Add_Cick();
        }

        private void btnSup_Click(object sender, EventArgs e)
        {
           manageActeur.Sup_Click();
        }
    }
}
