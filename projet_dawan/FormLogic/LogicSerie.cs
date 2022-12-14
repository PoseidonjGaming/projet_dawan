using projet_dawan_WinForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projet_dawan.Models;
using SerieDLL_EF.Service;
using projet_dawan.Forms;

namespace projet_dawan.FormLogic
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
            Form.lblSerie.Text = Serie.Nom;
            Form.lblSerie.Location = new Point((Form.Size.Width - Form.lblSerie.Size.Width) / 2, Form.lblSerie.Location.Y);
            Form.lblDateSerie.Text = Serie.DateDiff.ToString();
            Form.linkLblBASerie.Text = Serie.UrlBa;
            Form.txtBoxResumeSerie.Text = Serie.Resume;
            Form.pictureBoxSerie.ImageLocation = Directory.GetCurrentDirectory() + "\\Photo\\" + Serie.Affiche;
            SaisonService service = new SaisonService();
            foreach (Saison saison in service.GetSaisonsBySerie(Serie.Id))
            {
                Saisons.Add(saison);
                Form.lstBoxSaison.Items.Add(saison.Numero.ToString());
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
            if (Form.lstBoxSaison.SelectedIndex != -1)
            {
                Saison saison = Saisons[Form.lstBoxSaison.SelectedIndex];
                saison.Serie = Serie;
                FormEpisode formSaison = new(saison);
                formSaison.FormClosed += OpenForm;
                Form.Hide();
                formSaison.ShowDialog(Form);
            }
        }

        public void ButtonToWatch_Click()
        {
            if (!Properties.Settings.Default.UserRemain.ToWatch.Contains(Serie.Id))
            {

                Properties.Settings.Default.UserRemain.ToWatch.Add(Serie.Id);
                Properties.Settings.Default.Save();
            }
        }

        private void OpenForm(object sender, EventArgs e)
        {
            Form.Show();
        }
    }
}
