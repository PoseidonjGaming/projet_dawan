﻿using projet_dawan_WPF.Logic.Autre;
using System.Windows;
using System.Windows.Input;

namespace projet_dawan_WPF.Windows.Autre
{
    /// <summary>
    /// Logique d'interaction pour WindowsConnection.xaml
    /// </summary>
    public partial class WindowConnection : System.Windows.Window
    {
        private LogicMain logic;
        public WindowConnection()
        {
            InitializeComponent();
            logic = new(this);
        }

        private void btnConnexion_Click(object sender, RoutedEventArgs e)
        {
            logic.BtnConnexion_Click();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            logic.Load();
        }

        private void txtLogin_KeyDown(object sender, KeyEventArgs e)
        {
            logic.Txt_KeyDown(sender,e);
            
        }
    }
}
