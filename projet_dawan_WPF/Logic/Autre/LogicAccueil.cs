using projet_dawan_WPF.Windows.Autre;
using projet_dawan_WPF.Windows.Detail;
using projet_dawan_WPF.Windows.Export;
using projet_dawan_WPF.Windows.Manage;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace projet_dawan_WPF.Logic.Autre
{
    internal class LogicAccueil
    {
        private List<Serie> serieList;
        private UserApp user;
        private Grid Grid;
        public WindowAccueil Window { get; set; }
        public LogicAccueil(WindowAccueil form)
        {
            user = Properties.Settings.Default.UserRemain;
            Window = form;
            Grid = new();
            serieList = new();
        }
        public void Load()
        {

            if (Properties.Settings.Default.UserRemain != null)
            {
                UserService service = new();
                if (service.CompareTo(Properties.Settings.Default.UserRemain))
                {
                    user = Properties.Settings.Default.UserRemain;
                    Window.menuItemSeConnecter.Header = "Déconnexion";
                    if (user.IsGranted(Roles.SuperAdmin))
                    {
                        Window.menuGestion.IsEnabled = true;

                    }
                    else
                    {
                        Window.menuGestion.IsEnabled = false;
                    }
                }
                else
                {
                    Window.menuGestion.IsEnabled = false;
                }

            }
            else
            {
                Window.menuGestion.IsEnabled = false;
                Window.menuItemSeConnecter.Header = "Connexion";
            }
            Refresh();

        }

        private void Refresh()
        {

            Window.GridMain.Children.Remove(Grid);

            SerieService service = new();
            serieList = service.LastAdd();

            Populate(serieList.Count);
        }

        private void Populate(int I)
        {
            for (int i = 0; i < I; i++)
            {
                Grid = new();
                RowDefinition rowImg = new()
                {
                    Height = new GridLength(225, GridUnitType.Star)
                };
                RowDefinition rowBtn = new()
                {
                    Height = new GridLength(30, GridUnitType.Pixel)
                };
                Grid.RowDefinitions.Add(rowImg);
                Grid.RowDefinitions.Add(rowBtn);

                Image img = new();
                BitmapImage bitImg = new();
                try
                {
                    bitImg.BeginInit();
                    bitImg.UriSource = new Uri(serieList[i].Affiche);
                    bitImg.EndInit();
                }
                catch (Exception ex)
                {

                }

                img.Margin = new Thickness(10, 20, 10, 0);
                img.Source = bitImg;
                img.Stretch = Stretch.Fill;
                img.MouseLeftButtonDown += Serie_Click;

                Grid.SetRow(img, 0);
                Grid.Children.Add(img);

                Button btnSerie = new Button();
                btnSerie.Content = serieList[i].Nom;
                btnSerie.Margin = new Thickness(10, 0, 10, 10);
                btnSerie.Click += Serie_Click;
                Grid.SetRow(btnSerie, 1);
                Grid.Children.Add(btnSerie);

                Grid.SetColumn(Grid, 1 + i);
                Grid.SetRow(Grid, 2);
                Window.GridMain.Children.Add(Grid);
            }
        }

        private void Serie_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
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
                Image? img = sender as Image;
                Serie? serie = serieList.Find(s => s.Affiche == img?.Source.ToString());
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

        public void GererLesActeurs_Click()
        {
            if (user.IsGranted(Roles.SuperAdmin))
            {
                WindowManageActeur windowGereActeur = new()
                {
                    Owner = Window
                };
                windowGereActeur.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vous devez avoir le niveau accréditation requis");
            }
        }

        public void GererLesUsers_Click()
        {
            if (user.IsGranted(Roles.SuperAdmin))
            {
                WindowManageUsers windowManageUser = new()
                {
                    Owner = Window
                };
                windowManageUser.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vous devez avoir le niveau accréditation requis");
            }
        }

        private void OpenFormBibli(string text)
        {

            WindowBibliotheque WindowsBibliotheque = new(text)
            {
                Owner = Window
            };
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
                WindowManageEpisodes window = new()
                {
                    Owner = Window
                };
                window.ShowDialog();
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

                Refresh();
            }
        }

        public void GererPersonnagesToolStripMenuItem_Click()
        {
            if (user.IsGranted(Roles.SuperAdmin))
            {
                WindowManagePersonnages window = new()
                {
                    Owner = Window
                };
                window.ShowDialog();
            }

        }

        public void SeConnecterToolStripMenuItem_Click()
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
                    Window.menuItemSeConnecter.Header = "Connexion";
                }
            }
            else
            {
                WindowConnection winCon = new()
                {
                    Owner = Window
                };
                winCon.Closing += FormClose;
                winCon.ShowDialog();
            }

        }

        private void FormClose(object sender, EventArgs e)
        {
            user = Properties.Settings.Default.UserRemain;
            if (user != null)
            {
                Window.menuItemSeConnecter.Header = "Déconnexion";
                if (user.IsGranted(Roles.SuperAdmin))
                {
                    Window.menuGestion.IsEnabled = true;
                }
                else
                {
                    Window.menuGestion.IsEnabled = false;
                }
            }

        }

        public void MenuItemImport_Export_Click()
        {
            WindowImportExport window = new()
            {
                Owner = Window
            };
            window.ShowDialog();
            Refresh();
        }

        public void TxtRechercher_KeyUp(KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Search_Click();
            }
        }

        public void MenuItemNote_Click()
        {
            if (Properties.Settings.Default.UserRemain.IsGranted(Roles.SuperAdmin))
            {

                WindowManageNote window = new()
                {
                    Owner = Window
                };
                window.ShowDialog();
            }
        }
    }
}
