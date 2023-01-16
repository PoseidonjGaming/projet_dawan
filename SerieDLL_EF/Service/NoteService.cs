using SerieDLL_EF.Models;
using SerieDLL_EF.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieDLL_EF.Service
{
    public class NoteService: Service<Note, NoteRepo>
    {
        public NoteService():base(new NoteRepo()) { }
    }
}
