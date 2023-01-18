using projet_dawan.Forms;
using projet_dawan_WinForm;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;

namespace projet_dawan.Logic.Detail
{
    internal class LogicSerie
    {
        private Serie Serie = new();
        private List<Saison> Saisons = new List<Saison>();
        public FormSerie Form { get; set; }

        public LogicSerie(FormSerie form)
        {
            Form = form;

        }

        public void Load(Serie serie)
        {
            Serie = serie;
            Form.GetLabelNom().Text = Serie.Nom;
            Form.GetLabelNom().Location = new Point((Form.Size.Width - Form.GetLabelNom().Size.Width) / 2, Form.GetLabelNom().Location.Y);
            Form.GetLabelDateSerie().Text = Serie.DateDiff.ToString();
            Form.GetLinkLabelUrlBa().Text = Serie.UrlBa;
            Form.GetTextBoxRsume().Text = Serie.Resume;
            Form.GetPictureBoxAffiche().ImageLocation = Directory.GetCurrentDirectory() + "\\Photo\\" + Serie.Affiche;
            SaisonService service = new SaisonService();
            foreach (Saison saison in service.GetSaisonsBySerie(Serie.Id))
            {
                Saisons.Add(saison);
                Form.GetListBoxSaison().Items.Add(saison.Numero.ToString());
            }
        }

        public void BtnCasting_Click()
        {
            PersonnageService service = new PersonnageService();
            FormCasting casting = new(service.GetBySerie(Serie.Id));
            casting.ShowDialog();
        }

        public void LstBoxSaison_SelectedIndexChanged()
        {
            if (Form.GetListBoxSaison().SelectedIndex != -1)
            {
                Saison saison = Saisons[Form.GetListBoxSaison().SelectedIndex];
                saison.Serie = Serie;
                FormEpisode formSaison = new(saison);
                formSaison.FormClosed += OpenForm;
                Form.Hide();
                formSaison.ShowDialog(Form);
            }
        }

        public void ButtonToWatch_Click()
        {
            if (!Properties.Settings.Default.UserRemain.ToWatchList.Contains(Serie.Id))
            {

                Properties.Settings.Default.UserRemain.SetToWatchList(new() { Serie });
                Properties.Settings.Default.Save();
                UserService service = new();
                service.Update(Properties.Settings.Default.UserRemain);
            }
        }

        private void OpenForm(object sender, EventArgs e)
        {
            Form.Show();
        }
    }
}
