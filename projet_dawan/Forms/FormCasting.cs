using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projet_dawan.Models;

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

        // la list box affiche tous les nom des personnages de la série
        // en selectionnant un des nom de la liste les information sur le côté s'actualise en fonction du personnage
        // au demarage de la form casting le premier nom de la liste est automatiquement selectionné
    }
}
