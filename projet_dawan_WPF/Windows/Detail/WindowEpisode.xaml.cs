﻿using projet_dawan_WPF.Logic.Detail;
using SerieDLL_EF.Models;
using System.Windows;
using System.Windows.Controls;

namespace projet_dawan_WPF.Windows.Detail
{
    /// <summary>
    /// Logique d'interaction pour WindowEpisode.xaml
    /// </summary>
    public partial class WindowEpisode : System.Windows.Window
    {
        private Saison Saison;
        private LogicEpisodes logic;
        public WindowEpisode(Saison saison)
        {
            InitializeComponent();
            Saison = saison;
            logic = new(this);
            logic.Load(Saison);
        }

        private void lstBoxEpisode_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            logic.LstBoxEpisode_SelectedIndexChanged();
        }

        private void btnCasting_Click(object sender, RoutedEventArgs e)
        {
            logic.Casting_Click();
        }
    }
}
