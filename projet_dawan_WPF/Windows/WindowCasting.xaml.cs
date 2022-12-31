using projet_dawan_WPF.Logic;
using SerieDLL_EF.Models;
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
    /// Logique d'interaction pour WindowCasting.xaml
    /// </summary>
    public partial class WindowCasting : Window
    {
        private LogicCasting logic;
        public WindowCasting (List<Personnage> list)
        {
            InitializeComponent();
            logic = new(this);
            logic.Load(list);
        }

        private void lstBoxCasting_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            logic.ListBoxCasting_SelectedIndexChanged();
        }
    }
}
