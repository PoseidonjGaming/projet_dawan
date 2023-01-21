using projet_dawan_WPF.Windows.Manage;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace projet_dawan_WPF.Logic.Manage
{
    public class LogicManageNote
    {
        public WindowManageNote Window { get; set; }

        private NoteService service;
        private SerieService serieService;
        private UserService userService;

        private List<UserApp> userList;
        private List<Serie> serieList;
        private List<Note> noteList;

        public LogicManageNote(WindowManageNote window)
        {
            Window = window;

            service = new();
            serieService = new();
            userService = new();
            userList = new();
            serieList = new();
            noteList = service.GetAll();
        }

        public void Load()
        {
            serieList = serieService.GetAll();
            foreach (Serie serie in serieList)
            {
                Window.cmbSerie.Items.Add(serie.Nom);
            }
            userList = userService.GetAll();
            foreach (UserApp userApp in userList)
            {
                Window.cmbUser.Items.Add(userApp.Login);
            }
            Window.txtBoxNote.Text = "0";
            Populate();
        }

        public void BtnAjouter_Click()
        {
            if (Window.cmbSerie.SelectedIndex != -1 && Window.cmbUser.SelectedIndex != -1)
            {
                if (Window.lstBoxNote.SelectedIndex != -1)
                {
                    Note note = noteList[Window.lstBoxNote.SelectedIndex];
                    note.NbNote = int.Parse(Window.txtBoxNote.Text);
                    note.UserId = userList[Window.cmbUser.SelectedIndex].Id;
                    note.SerieId = serieList[Window.cmbSerie.SelectedIndex].Id;
                    note.Commentaire = Window.txtCommentaire.Text;

                    service.Update(note);
                }
                else
                {
                    Note note = new()
                    {
                        UserId = userList[Window.cmbUser.SelectedIndex].Id,
                        SerieId = serieList[Window.cmbSerie.SelectedIndex].Id,
                        NbNote = int.Parse(Window.txtBoxNote.Text),
                        Commentaire = Window.txtCommentaire.Text
                    };
                    service.Add(note);
                }
                Populate();
            }
        }

        public void BtnAnnuler_Click()
        {
            Clear();
        }

        public void BtnSup_Click()
        {
            if (Window.lstBoxNote.SelectedIndex != -1)
            {
                service.Delete(noteList[Window.lstBoxNote.SelectedIndex]);
                Populate();
            }
        }

        public void LstBoxNote_SelectionChanged()
        {
            if (Window.lstBoxNote.SelectedIndex != -1)
            {
                Note note = noteList[Window.lstBoxNote.SelectedIndex];
                Window.cmbSerie.SelectedIndex = serieList.IndexOf(note.Serie);
                Window.cmbUser.SelectedIndex = userList.IndexOf(note.User);
                Window.txtBoxNote.Text = note.NbNote.ToString();
                Window.txtCommentaire.Text = note.Commentaire;
                Window.btnAjouter.Content = "Modifier";
            }
            else
            {
                Window.btnAjouter.Content = "Ajouter";
            }
        }

        public void TxtBoxNote_KeyDown(Key key)
        {
            List<Key> keys = new()
            {
                Key.NumPad0, Key.NumPad1,
                Key.NumPad2,Key.NumPad3,
                Key.NumPad4,Key.NumPad5
            };

            if (!keys.Contains(key))
            {
                MessageBox.Show("Veuillez en entre une note correcte");
                Window.txtBoxNote.Text = string.Empty;
            }
        }

        public void TxtBoxNote_MouseWheel(int delta)
        {
            int nbNote = int.Parse(Window.txtBoxNote.Text);
            if (delta > 0 && nbNote < 5)
            {
                nbNote++;
                Window.txtBoxNote.Text = nbNote.ToString();
            }
            else if (nbNote > 0 && delta < 0)
            {
                nbNote--;
                Window.txtBoxNote.Text = nbNote.ToString();
            }
        }

        private void Populate()
        {
            Clear();
            Window.lstBoxNote.Items.Clear();
            noteList = service.GetAll();
            foreach (Note note in noteList)
            {
                note.User = userList.Where(u => u.Id == note.UserId).First();
                note.Serie = serieList.Where(s => s.Id == note.SerieId).First();
                Window.lstBoxNote.Items.Add(note.ToString());
            }
        }

        private void Clear()
        {
            Window.txtBoxNote.Text = "0";
            Window.cmbSerie.SelectedIndex = -1;
            Window.cmbUser.SelectedIndex = -1;
            Window.txtCommentaire.Clear();
            Window.lstBoxNote.SelectedIndex = -1;
        }

    }
}
