using projet_dawan_WPF.Windows.Autre;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;

namespace projet_dawan_WPF.Logic.Autre
{
    public class LogicNote
    {
        public WindowNote Window { get; set; }
        private readonly int SerieId;
        private readonly NoteService service;

        public LogicNote(WindowNote window, int serieId)
        {
            Window = window;
            SerieId = serieId;
            service = new();
        }

        public void Load()
        {
            Note note = service.GetNote(SerieId, Properties.Settings.Default.UserRemain.Id);
            SerieService serieService = new();
            Window.Title = "Noter " + serieService.GetById(SerieId).Nom;
            if (note != null)
            {
                Window.txtBoxCommentaire.Text = note.Commentaire;
                switch (note.NbNote)
                {
                    case 1:
                        ChcBox1Checker(true);
                        break;
                    case 2:
                        ChcBox1Checker(true);
                        ChcBox2Checker(true);
                        break;
                    case 3:
                        ChcBox1Checker(true);
                        ChcBox2Checker(true);
                        ChcBox3Checker(true);
                        break;
                    case 4:
                        ChcBox1Checker(true);
                        ChcBox2Checker(true);
                        ChcBox3Checker(true);
                        ChcBox4Checker(true);
                        break;
                    case 5:
                        ChcBox1Checker(true);
                        ChcBox2Checker(true);
                        ChcBox3Checker(true);
                        ChcBox4Checker(true);
                        ChcBox5Checker(true);
                        break;
                }
            }

        }

        public void BtnValider_Click()
        {
            if (Window.txtBoxCommentaire.Text != string.Empty)
            {
                int nbNote = 0;
                if (Window.chcBox1.IsChecked == true)
                {
                    nbNote++;
                }
                if (Window.chcBox2.IsChecked == true)
                {
                    nbNote++;
                }
                if (Window.chcBox3.IsChecked == true)
                {
                    nbNote++;
                }
                if (Window.chcBox4.IsChecked == true)
                {
                    nbNote++;
                }
                if (Window.chcBox5.IsChecked == true)
                {
                    nbNote++;
                }
                Note note = new()
                {
                    SerieId = SerieId,
                    UserId = Properties.Settings.Default.UserRemain.Id,
                    Commentaire = Window.txtBoxCommentaire.Text,
                    NbNote = nbNote
                };
                if (service.CompareTo(note))
                {
                    service.Update(note);
                }
                else
                {
                    service.Add(note);
                }
                Window.Close();
            }
        }

        public void ChcBox1_Click()
        {
            if (Window.chcBox1.IsChecked == false && Window.chcBox2.IsChecked == true)
            {
                ChcBox1Checker(true);
                ChcBox2Checker(false);
                ChcBox3Checker(false);
                ChcBox4Checker(false);
                ChcBox5Checker(false);
            }
        }

        public void ChcBox2_Click()
        {
            ChcBox1Checker(true);
            if (Window.chcBox2.IsChecked == false && Window.chcBox3.IsChecked == true)
            {
                ChcBox2Checker(true);
                ChcBox3Checker(false);
                ChcBox4Checker(false);
                ChcBox5Checker(false);
            }
        }

        public void ChcBox3_Click()
        {
            ChcBox1Checker(true);
            ChcBox2Checker(true);
            if (Window.chcBox3.IsChecked == false && Window.chcBox4.IsChecked == true)
            {
                ChcBox3Checker(true);
                ChcBox4Checker(false);
                ChcBox5Checker(false);
            }
        }

        public void ChcBox4_Click()
        {
            ChcBox1Checker(true);
            ChcBox2Checker(true);
            ChcBox3Checker(true);
            if (Window.chcBox4.IsChecked == false && Window.chcBox5.IsChecked == true)
            {
                ChcBox4Checker(true);
                ChcBox5Checker(false);
            }
        }

        public void ChcBox5_Click()
        {
            ChcBox1Checker(true);
            ChcBox2Checker(true);
            ChcBox3Checker(true);
            ChcBox4Checker(true);
        }

        private void ChcBox1Checker(bool check)
        {
            Window.chcBox1.IsChecked = check;
        }

        private void ChcBox2Checker(bool check)
        {
            Window.chcBox2.IsChecked = check;
        }

        private void ChcBox3Checker(bool check)
        {
            Window.chcBox3.IsChecked = check;
        }

        private void ChcBox4Checker(bool check)
        {
            Window.chcBox4.IsChecked = check;
        }

        private void ChcBox5Checker(bool check)
        {
            Window.chcBox5.IsChecked = check;
        }
    }
}
