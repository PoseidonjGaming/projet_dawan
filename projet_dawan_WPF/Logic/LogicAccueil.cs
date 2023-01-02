using projet_dawan_WPF.Windows;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace projet_dawan_WPF.Logic
{
    internal class LogicAccueil
    {
        private string path = Directory.GetCurrentDirectory() + "\\photo\\";
        private List<Serie> serieList = new List<Serie>();
        private UserApp user;
        public WindowAccueil Window { get; set; }
        public LogicAccueil(WindowAccueil form)
        {
            user = projet_dawan_WPF.Properties.Settings.Default.UserRemain;
            Window = form;
        }
        public void Load()
        {
            SerieService service = new();
            serieList = service.GetAll();

            if (Properties.Settings.Default.UserRemain != null)
            {
                Window.menuItemSeConnecter.IsEnabled = false;
            }

            Populate(4);
        }

        private void Populate(int I)
        {
            for (int i = 0; i < I; i++)
            {
                Grid grid = new Grid();
                RowDefinition rowImg = new();
                rowImg.Height = new GridLength(225, GridUnitType.Star);
                RowDefinition rowBtn = new();
                rowBtn.Height = new GridLength(30, GridUnitType.Pixel);
                grid.RowDefinitions.Add(rowImg);
                grid.RowDefinitions.Add(rowBtn);

                Image img = new();
                BitmapImage bitImg = new BitmapImage();
                bitImg.BeginInit();
                bitImg.UriSource = new(path + "\\" + serieList[i].Affiche);
                bitImg.EndInit();
                img.Margin = new Thickness(10, 20, 10, 0);
                img.Source = bitImg;
                img.Stretch = Stretch.Fill;

                Grid.SetRow(img, 0);
                grid.Children.Add(img);

                Button btnSerie = new Button();
                btnSerie.Content = serieList[i].Nom;
                btnSerie.Margin = new Thickness(10, 0, 10, 10);
                btnSerie.Click += Serie_Click;
                Grid.SetRow(btnSerie, 1);
                grid.Children.Add(btnSerie);

                Grid.SetColumn(grid, 1 + i);
                Grid.SetRow(grid, 2);
                Window.GridMain.Children.Add(grid);
            }
        }

        private void Serie_Click(object sender, EventArgs e)
        {
            Button? button = sender as Button;
            if (button != null)
            {
                Serie? serie = serieList.Find(s => s.Nom == button.Content);
                if (serie != null)
                {
                    WindowSerie formSerie = new(serie)
                    {
                        Owner = Window
                    };
                    formSerie.ShowDialog();

                }

            }
            else
            {
                Image? pictureBox = sender as Image;
                Serie? serie = serieList.Find(s => s.Nom == pictureBox.Name);
                if (serie != null)
                {
                    WindowSerie formSerie = new(serie)
                    {
                        Owner = Window
                    };
                    formSerie.ShowDialog();

                }
            }
        }

        public void Gerer_Click()
        {
            // affiche la page de gestion du compte
            if (user.IsGranted(Roles.User))
            {
                //FormGererCompte compte = new();

                //compte.ShowDialog();
            }
        }

        public void GererLesActeurs_Click()
        {
            if (user.IsGranted(Roles.SuperAdmin))
            {
                WindowManageActeur windowGereActeur = new();
                windowGereActeur.Owner = Window;
                windowGereActeur.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vous devez avoir le niveau accréditation requis");
            }
        }

        private void OpenFormBibli(string text)
        {

            SerieService service = new();
            WindowBibliotheque WindowsBibliotheque = new(text, Window);
            WindowsBibliotheque.Closing += Form_FormClosing;
            Window.Hide();
            WindowsBibliotheque.ShowDialog();
        }

        public void Biblio_Click()
        {
            OpenFormBibli(string.Empty);
        }

        public void Search_Click()
        {
            OpenFormBibli(Window.txtRechercher.Text);
        }

        private void Form_FormClosing(object sender, CancelEventArgs e)
        {
            Window.Show();
        }

        public void Quitter_Click()
        {
            var quitter = MessageBox.Show("Etes vous sur de vouloir vous quitter l'application ?", "Quitter ?",
              MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (quitter == MessageBoxResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        public void Deco_Click()
        {
            if (Properties.Settings.Default.UserRemain != null)
            {
                var deconnecter = MessageBox.Show("Etes vous sur de vouloir vous déconnecter de ce compte ?", "Se déconnecter ?",
                MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (deconnecter == MessageBoxResult.Yes)
                {
                    Properties.Settings.Default.token = string.Empty;
                    Properties.Settings.Default.UserRemain = null;
                    Properties.Settings.Default.Save();
                }
                Window.menuItemSeConnecter.IsEnabled = true;
            }

        }

        public void WatchList_Click()
        {
            if (Properties.Settings.Default.UserRemain != null)
            {
                WindowWatchList watchlist = new()
                {
                    Owner = Window
                };
                watchlist.ShowDialog();
            }

        }

        public void ManageEpisodeToolStripMenuItem_Click()
        {
            if (user.IsGranted(Roles.SuperAdmin))
            {
                WindowManageEpisodes form = new()
                {
                    Owner = Window
                };
                form.ShowDialog();
            }

        }

        public void ToolStripAddSerie_Click()
        {
            if (user.IsGranted(Roles.SuperAdmin))
            {
                WindowManageSeries window = new()
                {
                    Owner = Window
                };
                window.ShowDialog();
            }
        }

        public void gererPersonnagesToolStripMenuItem_Click()
        {
            if (user.IsGranted(Roles.SuperAdmin))
            {
                WindowManagePersonnages form = new()
                {
                    Owner = Window
                };
                form.ShowDialog();
            }

        }

        public void SeConnecterToolStripMenuItem_Click()
        {
            WindowConnection winCon = new();
            winCon.Closing += FormClose;
            winCon.ShowDialog();
        }

        private void FormClose(object sender, EventArgs e)
        {
            user = Properties.Settings.Default.UserRemain;
            Window.menuItemSeConnecter.IsEnabled = false;
        }

    }
}
