using projet_dawan_WPF.Windows.Export;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_dawan_WPF.Logic.Export
{
    internal class LogicExportNote
    {
        private NoteService service;
        private WindowExportNote Window { get; set; }

        public LogicExportNote(WindowExportNote window)
        {
            service = new();
            Window = window;
        }

        public void BtnExport_Click()
        {
            Properties.Settings.Default.ExportNote = service.GetAll();
            if (Window.checkBoxSerie.IsChecked == true)
            {
                SerieService serieService = new();
                foreach (Note note in Properties.Settings.Default.ExportNote)
                {
                    note.ShouldExportSerie = true;
                    note.Serie = serieService.GetById(note.SerieId);
                }
                WindowExportSerie window = new()
                {
                    Owner = Window
                };
                window.ShowDialog();
            }
            Window.Close();
        }
    }
}
