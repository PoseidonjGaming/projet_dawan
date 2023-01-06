using projet_dawan_WPF.Logic.Detail;
using SerieDLL_EF.Models;
using System.Collections.Generic;
using System.Windows.Controls;

namespace projet_dawan_WPF.Windows.Detail
{
    /// <summary>
    /// Logique d'interaction pour WindowCasting.xaml
    /// </summary>
    public partial class WindowCasting : System.Windows.Window
    {
        private LogicCasting logic;
        public WindowCasting(List<Personnage> list)
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
