using projet_dawan.FormLogic;

namespace projet_dawan.Forms
{
    public partial class FormManagePerso : Form
    {
        private LogicManagePerso managePerso;
        public FormManagePerso()
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

        private void listBoxPerso_SelectedIndexChanged(object sender, EventArgs e)
        {
            managePerso.ListBoxPerso_SelectedIndexChanged();
        }

        public ComboBox GetComboBoxSerie()
        {
            return comboBoxSerie;
        }
        public ComboBox GetComboBoxActeur()
        {
            return comboBoxActeur;
        }

        public TextBox GetTextBoxNomPerso()
        {
            return txtNomPerso;
        }

        public ListBox GetListBoxPerso()
        {
            return listBoxPerso;
        }


    }
}
