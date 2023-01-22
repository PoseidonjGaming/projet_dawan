using projet_dawan_WPF.Logic.Autre;
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
        private readonly LogicNote logic;
        public WindowNote(int serieId)
        {
            InitializeComponent();
            logic = new(this, serieId);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            logic.Load();
        }

        private void btnValider_Click(object sender, RoutedEventArgs e)
        {
            logic.BtnValider_Click();
        }

        private void chcBox1_Click(object sender, RoutedEventArgs e)
        {
            logic.ChcBox1_Click();
        }

        private void chcBox2_Click(object sender, RoutedEventArgs e)
        {
            logic.ChcBox2_Click();
        }

        private void chcBox3_Click(object sender, RoutedEventArgs e)
        {
            logic.ChcBox3_Click();
        }

        private void chcBox4_Click(object sender, RoutedEventArgs e)
        {
            logic.ChcBox4_Click();
        }

        private void chcBox5_Click(object sender, RoutedEventArgs e)
        {
            logic.ChcBox5_Click();
        }

        private void chcBox5_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
