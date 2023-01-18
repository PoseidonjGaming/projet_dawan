using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
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

namespace projet_dawan_WPF.Windows.Export
{
    /// <summary>
    /// Logique d'interaction pour WindowExportNote.xaml
    /// </summary>
    public partial class WindowExportNote : Window
    {
        private NoteService service;
        public WindowExportNote()
        {
            InitializeComponent();
            service = new();
        }

        private void btnExport_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.ExportNote = service.GetAll();
            if (checkBoxSerie.IsChecked == true)
            {
                SerieService serieService = new();
                foreach (Note note in Properties.Settings.Default.ExportNote)
                {
                    note.ShouldExportSerie = true;
                    note.Serie = serieService.GetById(note.SerieId);
                }
                WindowExportSerie window = new()
                {
                    Owner = this
                };
                window.ShowDialog();
            }
            Close();
        }
    }
}
