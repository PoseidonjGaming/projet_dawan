﻿using projet_dawan_WPF.Logic;
using System.Windows;

namespace projet_dawan_WPF.Window
{
    /// <summary>
    /// Logique d'interaction pour WindowWatchList.xaml
    /// </summary>
    public partial class WindowWatchList : System.Windows.Window
    {
        private LogicWatchList logic;
        public WindowWatchList()
        {
            InitializeComponent();
            logic = new(this);
            logic.Load();
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            logic.Import();
        }

        private void btnExportList_Click(object sender, RoutedEventArgs e)
        {
            logic.BtnExportList_Click();
        }

        private void btnClearAll_Click(object sender, RoutedEventArgs e)
        {
            logic.BtnClearAll_Click();
        }
    }
}
