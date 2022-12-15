using projet_dawan.FormLogic;
using projet_dawan.Forms;
using projet_dawan.Models;
using SerieDLL_EF.Repository;
using SerieDLL_EF.Service;

namespace projet_dawan.Forms
{  
    public partial class FormCasting : Form
    {
        private LogicCasting casting;
        public FormCasting(List<Personnage> list)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            casting=new(this);
            casting.Load(list);
        }

        private void listBoxCasting_SelectedIndexChanged(object sender, EventArgs e)
        {
            casting.ListBoxCasting_SelectedIndexChanged();
        }

       

        // ajouter information sur le perso et une image

    }
}
