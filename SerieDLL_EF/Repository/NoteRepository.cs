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
    /*
     * Les Répositories sont les classes qui gèrent la bdd.
     * Dans notre cas, elles implèmentent les interfaces du dossier Interface, pour plus de simplicité
     * Cette classe implémente les interfaces IRepoCRUD et IRepSpecials pour gérer la table note
     */

    public class NoteRepository : IRepoCRUD<Note>, IRepSpecials<Note>
    {
        /*
         * Récupère toutes les notes depuis la base de données
         */
        public List<Note> GetAll()
        {
            using BddprojetContext context = new();
            return context.Notes.ToList();
        }

        /*
         * Récupère la note depuis la base de données
         * dont l'id correspond à l'id passé en paramètre
         */
        public Note GetById(int id)
        {
            using BddprojetContext context = new();
            return context.Notes.Where(n => n.Id == id).FirstOrDefault();
        }

        /*
         * Récupère la note depuis la base données dont 
         * l'id de la série associée et l'id de l'utilisateur correspondent
         * à l'id de la série et l'id de l'utilisateur passés en paramètre
         */
        public Note? GetNote(int serieId, int userId)
        {
            using BddprojetContext context = new();
            return context.Notes.Where(n => n.SerieId == serieId && n.UserId == userId).FirstOrDefault();
        }

        /*
         * Récupère les notes dont l'id de la série associée
         * correspond à l'id passé en paramètre
         */
        public List<Note> GetNoteBySerie(int serieId)
        {
            using BddprojetContext context = new();
            return context.Notes.Where(n => n.SerieId == serieId).ToList();
        }

        /*
         * Calcul la moyenne des notes dont l'id de la série associée
         * correspond à l'id passé en paramètre
         */
        public double GetNoteAverage(int serieId)
        {
            using BddprojetContext context = new();
            List<Note> notes = GetNoteBySerie(serieId);
            double sum = 0.0;
            foreach (Note note in notes)
            {
                sum += note.NbNote;
            }
            return sum / notes.Count;
        }

        /*
         * Ajoute la note passée en paramètre dans la base de données 
         */
        public void Add(Note item)
        {
            using BddprojetContext context = new();
            context.Notes.Add(item);
            context.SaveChanges();
        }

        /*
         * Modifie dans la base de données, la note passée en paramètre
         */
        public void Update(Note item)
        {
            using BddprojetContext context = new();
            context.Notes.Update(item);
            context.SaveChanges();
        }

        /*
         * Supprime dans la base de données, la note passée en paramètre
         */
        public void Delete(Note item)
        {
            using BddprojetContext context = new();
            context.Notes.Remove(item);
            context.SaveChanges();
        }

        /*
         * Vérifie si une note dont l'id de la série associée et
         * l'id de l'utilisateur associé correspond
         * à ceux de la note passée en paramètre
         * existe dans la base de données
         */
        public bool CompareTo(Note obj)
        {
            using BddprojetContext context = new();
            Note? note = context.Notes.Where(n => n.SerieId == obj.SerieId && n.UserId == obj.UserId).FirstOrDefault();
            return note != null;
        }
        /*
         * Récupère la note dont l'id de la série associée et
         * l'id de l'utilisateur associé correspond
         * à ceux de la note passée en paramètre
         * dpeuis la base de données
         */
        public Note? GetCompareTo(Note obj)
        {
            using BddprojetContext context = new();
            return context.Notes.Where(n => n.SerieId == obj.SerieId && n.UserId == obj.UserId).FirstOrDefault();
        }

        public List<Note> GetByTxt(string txt)
        {
            using BddprojetContext context = new();
            return context.Notes.Where(n => n.Commentaire.Contains(txt)).ToList();

        }

        public Note Export(int id)
        {
            using BddprojetContext context = new();
            return context.Notes.Where(n => n.Id == id).ToList().FirstOrDefault();

        }
    }
}
