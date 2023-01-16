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

namespace projet_dawan_WPF.Windows
{
    /// <summary>
    /// Logique d'interaction pour WindowTest.xaml
    /// </summary>
    public partial class WindowTest : Window
    {
        private List<Serie> list;
        public WindowTest()
        {
            InitializeComponent();
            list = new();
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

        private void btnValider_Click(object sender, RoutedEventArgs e)
        {
            if (lstBoxSerie.SelectedIndex != -1)
            {
                int nbNote = 0;
                if (ch1.IsChecked == true)
                {
                    nbNote++;
                }
                if (ch2.IsChecked == true)
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
                    SerieId = list[lstBoxSerie.SelectedIndex].Id,
                    UserId=Properties.Settings.Default.UserRemain.Id,
                    Commentaire=comm.Text
                };

                
            }

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SerieService service = new();
            list = service.GetAll();
            foreach (Serie serie in list)
            {
                lstBoxSerie.Items.Add(serie.Nom);
            }
        }
    }
}
