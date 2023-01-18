using SerieDLL_EF.Models;
using SerieDLL_EF.Service;

namespace projet_dawan.Logic.Manage
{
    internal class LogicManageSerie
    {
        public FormManageSerie Form { get; set; }
        private SerieService serieService = new();
        private List<Serie> serieList = new();

        public LogicManageSerie(FormManageSerie form)
        {
            Form = form;
        }

        public void Load()
        {
            Populate();
        }

        public void BtnAjouter_Click()
        {
            if (Form.GetTextBoxNomSerie().Text != string.Empty && Form.GetTextBoxResume().Text != string.Empty
                && Form.GetTextBoxAffiche().Text != string.Empty)
            {
                if (Form.GetListBoxSerie().SelectedIndex != -1)
                {
                    Serie serie = serieList[Form.GetListBoxSerie().SelectedIndex];
                    serie.Affiche = Path.GetFileName(Form.GetTextBoxAffiche().Text);
                    serie.Nom = Form.GetTextBoxNomSerie().Text;
                    serie.Resume = Form.GetTextBoxResume().Text;
                    serie.UrlBa = Form.GetTextBoxURLBa().Text;
                    serie.DateDiff = Form.GetDateDiff().Value;
                    serieService.Update(serie);
                }
                else
                {
                    Serie serie = new()
                    {
                        Nom = Form.GetTextBoxNomSerie().Text,
                        DateDiff = Form.GetDateDiff().Value,
                        Resume = Form.GetTextBoxResume().Text,
                        UrlBa = Form.GetTextBoxURLBa().Text,
                        Affiche = Path.GetFileName(Form.GetTextBoxAffiche().Text)

                    };
                    File.Copy(Form.GetTextBoxAffiche().Text, Directory.GetCurrentDirectory() + "\\Photo\\" + serie.Affiche);
                    serieService.Add(serie);
                }
                Populate();
            }
            else
            {
                MessageBox.Show("Champs Obligatoires Incorrects");
            }
        }

        public void BtnSup_Click()
        {
            var annuler = MessageBox.Show("Etes vous sur de vouloir annuler l'ajout ?", "Annuler ajout ?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (annuler == DialogResult.Yes)
            {
                SerieService service = new();
                File.Delete(Directory.GetCurrentDirectory() + "\\Photo\\" + serieList[Form.GetListBoxSerie().SelectedIndex].Affiche);
                service.Delete(serieList[Form.GetListBoxSerie().SelectedIndex]);
            }
            Populate();
        }

        public void BtnParcourir_Click()
        {
            if (Form.GetOpenFileAffiche().ShowDialog() == DialogResult.OK)
            {
                Form.GetTextBoxAffiche().Text = Form.GetOpenFileAffiche().FileName;
            }
        }

        public void LstBoxSerie_SelectedIndexChanged()
        {
            if (Form.GetListBoxSerie().SelectedIndex != -1)
            {
                Serie serie = serieList[Form.GetListBoxSerie().SelectedIndex];
                Form.GetTextBoxNomSerie().Text = serie.Nom;
                if (File.Exists(Directory.GetCurrentDirectory() + "\\Photo\\" + serie.Affiche))
                {
                    Form.GetTextBoxAffiche().Text = Directory.GetCurrentDirectory() + "\\Photo\\" + serie.Affiche;
                }
                else
                {
                    Form.GetTextBoxAffiche().Text = serie.Affiche;
                }

                Form.GetTextBoxResume().Text = serie.Resume;
                Form.GetTextBoxURLBa().Text = serie.UrlBa;
                Form.GetDateDiff().Value = (DateTime)serie.DateDiff;
                Form.GetButtonAdd().Text = "Modifier";
            }

        }

        public void BtnAnnuler_Click()
        {
            Clear();
            Form.GetButtonAdd().Text = "Ajouter";
        }

        private void Populate()
        {
            Clear();
            Form.GetListBoxSerie().Items.Clear();
            serieList = serieService.GetAll();
            foreach (Serie serie in serieList)
            {
                Form.GetListBoxSerie().Items.Add(serie.Nom);
            }
        }

        private void Clear()
        {
            Form.GetTextBoxNomSerie().Clear();
            Form.GetTextBoxAffiche().Clear();
            Form.GetTextBoxURLBa().Clear();
            Form.GetTextBoxResume().Clear();
            Form.GetListBoxSerie().SelectedIndex = -1;
        }
    }
}
