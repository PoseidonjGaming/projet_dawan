using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace projet_dawan_WPF.Windows.Autre
{
    /// <summary>
    /// Logique d'interaction pour WindowNote.xaml
    /// </summary>
    public partial class WindowNote : Window
    {
        private readonly int SerieId;
        private readonly NoteService service;
        public WindowNote(int serieId)
        {
            InitializeComponent();
            SerieId = serieId;
            service = new();
        }

        private void btnValider_Click(object sender, RoutedEventArgs e)
        {
            if (txtBoxCommentaire.Text != string.Empty)
            {
                int nbNote = 0;
                if (ch1.IsChecked == true)
                {
                    nbNote++;
                }
                if(ch2.IsChecked == true)
                {
                    nbNote++;
                }
                if (ch3.IsChecked == true)
                {
                    nbNote++;
                }
                if (ch4.IsChecked == true)
                {
                    nbNote++;
                }
                if (ch5.IsChecked == true)
                {
                    nbNote++;
                }
                Note note = new()
                {
                    SerieId = SerieId,
                    UserId = Properties.Settings.Default.UserRemain.Id,
                    Commentaire=txtBoxCommentaire.Text,
                    nbNote=nbNote
                };
                if (service.CompareTo(note))
                {
                    service.Update(note);
                }
                else
                {
                    service.Add(note);
                }



            }
        }

        private void ch1_Click(object sender, RoutedEventArgs e)
        {
            if (ch1.IsChecked == false && ch2.IsChecked == true)
            {
                Ch1(true);
                Ch2(false);
                Ch3(false);
                Ch4(false);
                Ch5(false);
            }
        }

        private void ch2_Click(object sender, RoutedEventArgs e)
        {
            Ch1(true);
            if (ch2.IsChecked == false && ch3.IsChecked == true)
            {
                Ch2(true);
                Ch3(false);
                Ch4(false);
                Ch5(false);
            }
        }

        private void ch3_Click(object sender, RoutedEventArgs e)
        {
            Ch1(true);
            Ch2(true);
            if (ch3.IsChecked == false && ch4.IsChecked == true)
            {
                Ch3(true);
                Ch4(false);
                Ch5(false);
            }
        }

        private void ch4_Click(object sender, RoutedEventArgs e)
        {
            Ch1(true);
            Ch2(true);
            Ch3(true);
            if (ch4.IsChecked == false && ch5.IsChecked == true)
            {
                Ch4(true);
                Ch5(false);
            }
        }

        private void ch5_Click(object sender, RoutedEventArgs e)
        {
            Ch1(true);
            Ch2(true);
            Ch3(true);
            Ch4(true);
        }

        private void Ch1(bool check)
        {
            ch1.IsChecked = check;
        }

        private void Ch2(bool check)
        {
            ch2.IsChecked = check;
        }

        private void Ch3(bool check)
        {
            ch3.IsChecked = check;
        }

        private void Ch4(bool check)
        {
            ch4.IsChecked = check;
        }

        private void Ch5(bool check)
        {
            ch5.IsChecked = check;
        }

       

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Note note = service.GetNote(SerieId, Properties.Settings.Default.UserRemain.Id);
            if (note != null)
            {
                txtBoxCommentaire.Text=note.Commentaire;
                switch (note.nbNote)
                {
                    case 1:
                        Ch1(true);
                        break;
                    case 2:
                        Ch1(true);
                        Ch2(true);
                        break;
                    case 3:
                        Ch1(true);
                        Ch2(true);
                        Ch3(true);
                        break;
                    case 4:
                        Ch1(true);
                        Ch2(true);
                        Ch3(true);
                        Ch4(true);
                        break;
                    case 5:
                        Ch1(true);
                        Ch2(true);
                        Ch3(true);
                        Ch4(true);
                        Ch5(true);
                        break;
                }
            }

            
        }
    }
}
