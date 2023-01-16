using SerieDLL_EF.BDD;
using SerieDLL_EF.Interface;
using SerieDLL_EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Azure.Core.HttpHeader;

namespace SerieDLL_EF.Repository
{
    public class NoteRepository : IRepoCRUD<Note>
    {
        public List<Note> GetAll()
        {
            using BddprojetContext context= new();
            return context.Notes.ToList();
        }

        public Note GetById(int id)
        {
            using BddprojetContext context = new();
            return context.Notes.Where(n=> n.Id==id).FirstOrDefault();
        }

        public Note? GetNote(int serieId, int userId)
        {
            using BddprojetContext context = new();
            return context.Notes.Where(n => n.SerieId == serieId && n.UserId == userId).FirstOrDefault();
        }

        public List<Note> GetNoteBySerie(int serieId)
        {
            using BddprojetContext context = new();
            return context.Notes.Where(n => n.SerieId==serieId).ToList();
        }

        public double GetNoteAverage(int serieId)
        {
            using BddprojetContext context = new();
            List<Note> notes = GetNoteBySerie(serieId);
            double sum = 0.0;
            foreach (Note note in notes)
            {
                sum += note.nbNote;
            }
            return sum / notes.Count;
        }

        public void Add(Note item)
        {
            using BddprojetContext context = new();
            context.Notes.Add(item);
            context.SaveChanges();
        }

        public void Update(Note item)
        {
            using BddprojetContext context = new();
            context.Notes.Update(item);
            context.SaveChanges();
        }
        public void Delete(Note item)
        {
            using BddprojetContext context = new();
            context.Notes.Remove(item);
            context.SaveChanges();
        }

        public bool CompareTo(Note obj)
        {
            using BddprojetContext context = new();
            Note? note = context.Notes.Where(n => n.SerieId==obj.SerieId && n.UserId==obj.UserId).FirstOrDefault();
            return note != null;
        }

        public Note? GetCompareTo(Note obj)
        {
            using BddprojetContext context = new();
            return context.Notes.Where(n => n.SerieId == obj.SerieId && n.UserId == obj.UserId).FirstOrDefault();
        }

        

    }
}
