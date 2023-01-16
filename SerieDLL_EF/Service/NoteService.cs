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
        public NoteService():base(new NoteRepository()) { }

        public Note GetNote(int serieId, int userId)
        {
            return repo.GetNote(serieId, userId);
        }
    }
}
