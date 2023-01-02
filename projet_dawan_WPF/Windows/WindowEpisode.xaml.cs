using projet_dawan_WPF.Logic;
using SerieDLL_EF.Models;
using System.Windows;
using System.Windows.Controls;

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
            Saison = saison;
            logic = new(this);
            logic.Load(Saison);
        }

        private void lstBoxEpisode_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            logic.LstBoxEpisode_SelectedIndexChanged();
        }
    }
}
