using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projet_dawan.Model;

namespace projet_dawan.Forms
{
    public partial class FormCasting : Form
    {
        public FormCasting()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnPerso1_Click(object sender, EventArgs e)
        {
            // afficher fiche personnage correspondant (idem pour chaque bouton de la form casting)
            FormPersonnage perso = new();

            perso.ShowDialog();
        }
    }
}
