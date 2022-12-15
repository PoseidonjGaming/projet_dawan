using projet_dawan.FormLogic;
using projet_dawan.Forms;
using projet_dawan.Models;
using SerieDLL_EF.Repository;
using SerieDLL_EF.Service;

namespace projet_dawan.Forms
{  
    public partial class FormCasting : Form
    {
<<<<<<< HEAD
        private LogicCasting logicCasting;
=======
        private LogicCasting casting;
>>>>>>> f984640f1965c9eef8b8e8c88742c195a1fc19ce
        public FormCasting(List<Personnage> list)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
<<<<<<< HEAD
            logicCasting.Load(list);
           
        }

       

        private void listBoxCasting_SelectedIndexChanged(object sender, EventArgs e)
        {
           logicCasting.ListBoxCasting_SelectedIndexChanged();
        }
=======
            casting=new(this);
            casting.Load(list);
        }

        private void listBoxCasting_SelectedIndexChanged(object sender, EventArgs e)
        {
            casting.ListBoxCasting_SelectedIndexChanged();
        }

       
>>>>>>> f984640f1965c9eef8b8e8c88742c195a1fc19ce

        // ajouter information sur le perso et une image

    }
}
