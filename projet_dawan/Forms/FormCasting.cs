using projet_dawan.FormLogic;
using SerieDLL_EF.Models;

namespace projet_dawan.Forms
{
    public partial class FormCasting : Form
    {

        private LogicCasting logicCasting;

        public FormCasting(List<Personnage> list)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            logicCasting = new(this);
            logicCasting.Load(list);

        }



        private void listBoxCasting_SelectedIndexChanged(object sender, EventArgs e)
        {
            logicCasting.ListBoxCasting_SelectedIndexChanged();
        }

        // ajouter information sur le perso et une image

        public Label GetLabelCasting()
        {
            return lblCasting;
        }

        public Label GetLabelNomPerso()
        {
            return labelNomPerso;
        }

        public Label GetLabelActeur()
        {
            return labelActeur;
        }

        public ListBox GetListBoxCasting()
        {
            return lstBoxCasting;
        }


    }
}
