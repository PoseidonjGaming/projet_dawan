using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projet_dawan.DAO;
using projet_dawan.Model;
using projet_dawan_WinForm;
using SerieDLL.Interface;

namespace projet_dawan.Forms
{
    public partial class FormPersonnage : Form
    {
        private IDAOBase<Serie> serieDAO = new SerieDAO(Properties.Settings.Default.Connection);

        public FormPersonnage()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void labelNomPerso_Click(object sender, EventArgs e)
        {
            // retour form serie correspondant au personnage
            FormSerie serie = new(serieDAO.GetById(1));

            serie.ShowDialog();
        }

        private void labelActeur_Click(object sender, EventArgs e)
        {
            // afficher form acteur correspondant à l'acteur du personnage
            FormActeur acteur = new();

            acteur.ShowDialog();
        }
    }
}
