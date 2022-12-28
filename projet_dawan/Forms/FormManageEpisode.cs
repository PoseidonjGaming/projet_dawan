using projet_dawan.FormLogic;
using SerieDLL_EF.Models;
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
    public partial class FormManageEpisode : Form
    {
        private LogicManageEpisode manageEpisode;
        public FormManageEpisode()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            manageEpisode = new(this);
        }

        private void FormAjoutEpisode_Load(object sender, EventArgs e)
        {
            manageEpisode.Load();
        }

        

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            manageEpisode.BtnAjouter_Click();
        }

        private void cmbSerie_SelectedIndexChanged(object sender, EventArgs e)
        {
            manageEpisode.CmbSerie_SelectedIndexChanged();
        }

        private void lstBoxEpisode_SelectedIndexChanged(object sender, EventArgs e)
        {
            manageEpisode.LstBoxEpisode_SelectedIndexChanged();
        }

        private void btnSup_Click(object sender, EventArgs e)
        {
           manageEpisode.BtnSup_Click();
        }

        public ComboBox GetComboBoxSerie()
        {
            return cmbSerie;
        }

        public NumericUpDown GetNumericSaison()
        {
            return numSaison;
        }

        public ListBox GetListBoxEpisode()
        {
            return lstBoxEpisode;
        }

        public TextBox GetTextBoxNom()
        {
            return txtBoxNom;
        }
        public TextBox GetTextBoxResume()
        {
            return txtBoxResume;
        }

        public DateTimePicker GetDateTimeDatePremDiff()
        {
            return datePremDiff;
        }

        public CheckBox GetCheckBoxLasEp()
        {
            return checkBoxLastSeason;
        }
    }
}
