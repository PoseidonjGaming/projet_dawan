using Microsoft.EntityFrameworkCore;
using SerieDLL_EF.BDD;
using SerieDLL_EF.Interface;
using SerieDLL_EF.Models;

namespace SerieDLL_EF.Repository
{
    /*
     * Les Répositories sont les classes qui gèrent la bdd.
     * Dans notre cas, elles implèmentent les interfaces du dossier Interface, pour plus de simplicité
     * Cette classe implémente les interfaces IRepoCRUD et IRepSpecials pour gérer la table série
     */
    public class SerieRepository : IRepoCRUD<Serie>, IRepSpecials<Serie>
    {
        /*
         * Récupère toutes les séries depuis la base de données
         */
        public List<Serie> GetAll()
        {
            using BddprojetContext context = new();
            return context.Series.ToList();
        }

        /*
         * Récupère la série dont l'id
         * correspond à l'id passé en paramètre
         */
        public Serie GetById(int id)
        {
            using BddprojetContext context = new();
            return context.Series.Where(s => s.Id == id).SingleOrDefault();
        }

        /*
         * Récupère les série dont le nom
         * contient le texte passé en paramètre
         */
        public List<Serie> GetByTxt(string txt)
        {
            using BddprojetContext context = new();
            return context.Series.Where(s => s.Nom.Contains(txt)).ToList();
        }

        /*
         * Récupère les séries dont l'id
         * est contenu dans la liste passée en paramètre
         */
        public List<Serie> ExportWatchList(List<int> ids)
        {
            List<Serie> list = new();
            foreach (int id in ids)
            {
                list.Add(GetById(id));
            }
            return list;


        }

        /*
         * Ajoute la série passée en paramètre dans la base de données
         */
        public void Add(Serie item)
        {
            using BddprojetContext context = new();
            context.Series.Add(item);
            context.SaveChanges();
        }

        /*
         * Modifie la série passée en paramètre dans la base de données
         */
        public void Update(Serie item)
        {
            using BddprojetContext context = new();
            context.Series.Update(item);
            context.SaveChanges();
        }

        /*
         * Supprime la série passée en paramètre dans la base de données
         */
        public void Delete(Serie item)
        {
            using BddprojetContext context = new();
            context.Series.Remove(item);
            context.SaveChanges();
        }

        /*
         * Vérifie si une série dont 
         * les nom, affiche, DateDiff et résumé
         * correspondent à ceux de la série passée en paramètre
         * existe dans la base de données
         */
        public bool CompareTo(Serie item)
        {
            using BddprojetContext context = new();
            Serie? serie = context.Series.Where(s => s.Nom == item.Nom &&
            s.Affiche == item.Affiche && s.DateDiff == item.DateDiff && s.Resume == item.Resume
            ).FirstOrDefault();

            return serie != null;
        }

        /*
         * Récupère la série, depuis la base de donné, dont 
         * les nom, affiche, DateDiff et résumé
         * correspondent à ceux de la série passée en paramètre
         */
        public Serie GetCompareTo(Serie item)
        {
            using BddprojetContext context = new();
            return context.Series.Where(s => s.Nom == item.Nom && item.Affiche == item.Affiche
            && s.DateDiff == item.DateDiff && s.Resume == item.Resume).FirstOrDefault();
        }

        /*
         * Récupère les série dont l'id fait partie des 4
         * plus grandes ids de la base de données
         */
        public List<Serie> LastAdd()
        {
            using BddprojetContext context = new();
            var list = context.Series.AsNoTracking();
            if (list.Count()>4)
            {
                return list.OrderByDescending(s => s.Id).Take(4).ToList();
            }
            else
            {
                return list.OrderByDescending(s => s.Id).ToList();
            }
            
        }

        public Serie Export(int id)
        {
            using BddprojetContext context = new();
            return context.Series.Where(s => s.Id == id).ToList().FirstOrDefault();
        }
    }
}
