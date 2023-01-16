using SerieDLL_EF.BDD;
using SerieDLL_EF.Interface;
using SerieDLL_EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieDLL_EF.Repository
{
    public class NoteRepo : IRepoCRUD<Note>
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

        public void Add(Note item)
        {
            using BddprojetContext context = new();
            context.Notes.Add(item);
        }

        public void Update(Note item)
        {
            using BddprojetContext context = new();
            context.Notes.Update(item);
        }
        public void Delete(Note item)
        {
            using BddprojetContext context = new();
            context.Notes.Remove(item);
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
