using projet_dawan.DAO;
using projet_dawan.Model;
using SerieDLL.Interface;
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
    public partial class FormSupprimerSeries : Form
    {
        private IDAOBase<Serie> SerieDAO = new SerieDAO(Properties.Settings.Default.Connection);
        private List<Serie> SerieList = new List<Serie>();
        public FormSupprimerSeries()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            // supprimer la serie selectionner. Ajouter messagebox pour demander une validation
            if (cmbBxSerie.SelectedIndex != -1)
            {
                var annuler = MessageBox.Show("Etes vous sur de vouloir annuler l'ajout ?", "Annuler ajout ?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (annuler == DialogResult.Yes)
                {
                    SerieDAO.Delete(SerieList[cmbBxSerie.SelectedIndex].Id);
                }
            }
            Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            var annuler = MessageBox.Show("Etes vous sur de vouloir annuler la suppression ?", "Annuler suppression ?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (annuler == DialogResult.Yes)
            {
                Close();
            }
        }

        private void SupprimerSeries_Load(object sender, EventArgs e)
        {
            foreach (Serie serie in SerieDAO.GetAll())
            {
                cmbBxSerie.Items.Add(serie.Name);
                SerieList.Add(serie);
            }
        }
    }
}
