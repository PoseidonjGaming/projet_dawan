using SerieDLL_EF.BDD;
using SerieDLL_EF.Models;
using SerieDLL_EF.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieDLL_EF.Service
{
    public class NoteService: Service<Note, NoteRepository>
    {
        public NoteService():base() { }

        public Note GetNote(int serieId, int userId)
        {
            return repo.GetNote(serieId, userId);
        }


        public List<Note> GetNoteBySerie(int serieId)
        {
            return repo.GetNoteBySerie(serieId);
        }

        public double GetNoteAverage(int serieId)
        {
            return repo.GetNoteAverage(serieId);
        }
    }
}
