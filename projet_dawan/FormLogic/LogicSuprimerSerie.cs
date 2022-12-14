using projet_dawan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_dawan.FormLogic
{
    internal class LogicSuprimerSerie
    {
        public FormSupprimerSeries Form { get; set; }
        private List<Serie> SerieList = new List<Serie>();

        public LogicSuprimerSerie(FormSupprimerSeries form)
        {
            Form = form;
        }

        public void Load()
        {
            SerieService service = new();
            foreach (Serie serie in service.GetAll())
            {
                Form.cmbBxSerie.Items.Add(serie.Nom);
                SerieList.Add(serie);
            }
        }

        public void BtnSupprimer_Click()
        {
            // supprimer la serie selectionner. Ajouter messagebox pour demander une validation
            if (Form.cmbBxSerie.SelectedIndex != -1)
            {
                var annuler = MessageBox.Show("Etes vous sur de vouloir annuler l'ajout ?", "Annuler ajout ?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (annuler == DialogResult.Yes)
                {
                }
            }
            Form.Close();
        }

        public void BtnAnnuler_Click()
        {
            var annuler = MessageBox.Show("Etes vous sur de vouloir annuler la suppression ?", "Annuler suppression ?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (annuler == DialogResult.Yes)
            {
                Form.Close();
            }
        }
    }
}
