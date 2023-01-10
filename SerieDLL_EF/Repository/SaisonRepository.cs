﻿using SerieDLL_EF.Interface;
using SerieDLL_EF.Models;
using SerieDLL_EF.Service;

namespace SerieDLL_EF.Repository
{
    //Cette classe implémente les interfaces IRepoCRUD et IRepSpecials pour gérer la table saison
    public class SaisonRepository : BaseRepo, IRepoCRUD<Saison>, IRepSpecials<Saison>
    {
        public SaisonRepository(string cnx):base(cnx)
        {

        }
        public List<Saison> GetAll()
        {
            using BddprojetContext context = new(Cnx);
            return context.Saisons.ToList();
        }

        public Saison GetById(int id)
        {
            using BddprojetContext context = new(Cnx);
            return context.Saisons.Where(sa => sa.Id == id).SingleOrDefault();
        }


        public List<Saison> GetSaisonsBySerie(int id)
        {
            using BddprojetContext context = new(Cnx);
            return context.Saisons.Where(sa => sa.SerieId == id).ToList();
        }




        public void Add(Saison item)
        {
            using BddprojetContext context = new(Cnx);
            context.Saisons.Add(item);
            context.SaveChanges();
        }

        public void Update(Saison item)
        {
            using BddprojetContext context = new(Cnx);
            context.Saisons.Update(item);
            context.SaveChanges();
        }

        public void Delete(Saison item)
        {
            using BddprojetContext context = new(Cnx);
            context.Saisons.Remove(item);
            context.SaveChanges();
        }

        public List<Saison> GetByTxt(string txt)
        {
            using BddprojetContext context = new(Cnx);
            return context.Saisons.Where(sa => sa.Numero == short.Parse(txt)).ToList();
        }

        public bool CompareTo(Saison saison)
        {
            using BddprojetContext context = new(Cnx);
            Saison oldSaison = context.Saisons.Where(sa => sa.Numero == saison.Numero
            && sa.NbEpisode == saison.NbEpisode && sa.SerieId == saison.SerieId).FirstOrDefault();
            return oldSaison != null;
        }

        public Saison GetCompareTo(Saison saison)
        {
            SerieService serieService = new(Cnx);
            using BddprojetContext context = new(Cnx);
            return context.Saisons.Where(sa => sa.Numero == saison.Numero
            && sa.NbEpisode == saison.NbEpisode && sa.SerieId==saison.SerieId).FirstOrDefault();
        }
    }
}
