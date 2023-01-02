using projet_dawan.FormLogic;

namespace projet_dawan
{
    public partial class FormWatchlist : Form
    {
        private LogicWatchList logic;

        public FormWatchlist()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            logic = new(this);
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            logic.BtnClearAll_Click();
        }

        private void btnExportList_Click(object sender, EventArgs e)
        {
            logic.BtnExportList_Click();
        }

        private void FormWatchlist_Load(object sender, EventArgs e)
        {

            logic.Load();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            logic.Import();
        }

        // possibilité de supprimer l'élément de la listbox séléctionné


        public ListBox GetListBoxWatch()
        {
            return lstBoxWatchlist;
        }

        public OpenFileDialog GetOpenFileDialogLoad()
        {
            return openFileDialogLoad;
        }

        public SaveFileDialog GetSaveFileDialogWatchlist()
        {
            return saveFileDialogWatchList;
        }
    }
}
