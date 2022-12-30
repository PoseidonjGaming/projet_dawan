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
    /// Logique d'interaction pour WindowEpisode.xaml
    /// </summary>
    public partial class WindowEpisode : Window
    {
        private Saison Saison;
        private LogicEpisodes logic;
        public WindowEpisode(Saison saison)
        {
            InitializeComponent();
            Saison= saison;
            logic = new(this);
            logic.Load(Saison);
        }

        private void lstBoxEpisode_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            logic.LstBoxEpisode_SelectedIndexChanged();
        }
    }
}
