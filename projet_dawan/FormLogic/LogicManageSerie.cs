using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_dawan.FormLogic
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
            if (Form.txtNomSerie.Text != string.Empty && Form.txtResume.Text != string.Empty
                && Form.txtPathAffiche.Text != string.Empty)
            {
                if (Form.lstBoxSerie.SelectedIndex != -1)
                {
                    Serie serie = serieList[Form.lstBoxSerie.SelectedIndex];
                    serie.Affiche = Path.GetFileName(Form.txtPathAffiche.Text);
                    serie.Nom = Form.txtNomSerie.Text;
                    serie.Resume = Form.txtResume.Text;
                    serie.UrlBa = Form.txtUrlBa.Text;
                    serie.DateDiff = Form.dateTimeSortie.Value;
                    serieService.Update(serie);
                }
                else
                {
                    Serie serie = new()
                    {
                        Nom = Form.txtNomSerie.Text,
                        DateDiff = Form.dateTimeSortie.Value,
                        Resume = Form.txtResume.Text,
                        UrlBa = Form.txtUrlBa.Text,
                        Affiche = Path.GetFileName(Form.txtPathAffiche.Text)

                    };
                    File.Copy(Form.txtPathAffiche.Text, Directory.GetCurrentDirectory() + "\\Photo\\" + serie.Affiche);
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
                File.Delete(Directory.GetCurrentDirectory() + "\\Photo\\" + serieList[Form.lstBoxSerie.SelectedIndex].Affiche);
                service.Delete(serieList[Form.lstBoxSerie.SelectedIndex]);
            }
            Populate();
        }

        public void BtnParcourir_Click()
        {
            if (Form.openFileDialogAffiche.ShowDialog() == DialogResult.OK)
            {
                Form.txtPathAffiche.Text = Form.openFileDialogAffiche.FileName;
            }
        }

        public void LstBoxSerie_SelectedIndexChanged()
        {
            if (Form.lstBoxSerie.SelectedIndex != -1)
            {
                Serie serie = serieList[Form.lstBoxSerie.SelectedIndex];
                Form.txtNomSerie.Text = serie.Nom;
                if (File.Exists(Directory.GetCurrentDirectory() + "\\Photo\\" + serie.Affiche))
                {
                    Form.txtPathAffiche.Text += Directory.GetCurrentDirectory() + "\\Photo\\" + serie.Affiche;
                }
                else
                {
                    Form.txtPathAffiche.Text = serie.Affiche;
                }

                Form.txtResume.Text = serie.Resume;
                Form.txtUrlBa.Text = serie.UrlBa;
                Form.dateTimeSortie.Value = (DateTime)serie.DateDiff;
                Form.btnAjouter.Text = "Modifier";
            }
            
        }

        public void BtnAnnuler_Click()
        {
            Clear();
            Form.btnAjouter.Text = "Ajouter";
        }

        private void Populate()
        {
            Clear();
            Form.lstBoxSerie.Items.Clear();
            serieList = serieService.GetAll();
            foreach (Serie serie in serieList)
            {
                Form.lstBoxSerie.Items.Add(serie.Nom);
            }
        }

        private void Clear()
        {
            Form.txtNomSerie.Clear();
            Form.txtPathAffiche.Clear();
            Form.txtUrlBa.Clear();
            Form.txtResume.Clear();
            Form.lstBoxSerie.SelectedIndex = -1;
        }
    }
}
