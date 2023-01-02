using projet_dawan.FormLogic;

namespace projet_dawan
{
    public partial class FormManageSerie : Form
    {
        private LogicManageSerie manageSerie;
        public FormManageSerie()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            manageSerie = new(this);
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // vérifier si les champs sont valides puis ajouter la serie à la base de données
            manageSerie.BtnAjouter_Click();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            manageSerie.BtnAnnuler_Click();
        }

        private void btnSup_Click(object sender, EventArgs e)
        {
            manageSerie.BtnSup_Click();
        }

        private void FormAjoutSerie_Load(object sender, EventArgs e)
        {
            manageSerie.Load();
        }

        private void btnParcourir_Click(object sender, EventArgs e)
        {
            manageSerie.BtnParcourir_Click();
        }

        private void lstBoxSerie_SelectedIndexChanged(object sender, EventArgs e)
        {
            manageSerie.LstBoxSerie_SelectedIndexChanged();
        }

        public TextBox GetTextBoxNomSerie()
        {
            return txtNomSerie;
        }

        public TextBox GetTextBoxResume()
        {
            return txtResume;
        }

        public TextBox GetTextBoxAffiche()
        {
            return txtPathAffiche;
        }

        public TextBox GetTextBoxURLBa()
        {
            return txtUrlBa;
        }

        public DateTimePicker GetDateDiff()
        {
            return dateTimeSortie;
        }

        public ListBox GetListBoxSerie()
        {
            return lstBoxSerie;
        }

        public OpenFileDialog GetOpenFileAffiche()
        {
            return openFileDialogAffiche;
        }

        public Button GetButtonAdd()
        {
            return btnAjouter;
        }
    }
}
