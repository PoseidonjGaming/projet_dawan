using Microsoft.EntityFrameworkCore;
using SerieDLL_EF.Interface;
using SerieDLL_EF.Models;
using System.Formats.Asn1;
using System.Linq.Expressions;
using static System.Net.Mime.MediaTypeNames;

namespace SerieDLL_EF.Repository
{
    /*
     * Les Répositories sont les classes qui gèrent la bdd.
     * Dans notre cas, elles implèment les interfaces du dossier Interface, pour plus de simplicité
     * Cette classe implémente les interfaces IRepoCRUD et IRepSpecials pour gérer la table acteur
     */
    public class ActeurRepository : IRepoCRUD<Acteur>, IRepSpecials<Acteur>
    {
        private readonly BaseRepo<Acteur> BaseRepo;
        public ActeurRepository()
        {
            BaseRepo = new BaseRepo<Acteur>();
            BaseRepo.DbSet = BaseRepo.Context.Acteurs;
        }

        public List<Acteur> GetAll()
        {
            return BaseRepo.GetAll();
        }

        public Acteur GetById(int id)
        {
            return BaseRepo.GetById(p => p.Id == id);
        }

        public List<Acteur> GetByTxt(string txt)
        {
            return BaseRepo.GetByTxt(a => a.Nom.Contains(txt) || a.Prenom.Contains(txt));
        }

        public bool CompareTo(Acteur item)
        {
            return BaseRepo.CompareTo(a => a.Nom == item.Nom && a.Prenom == item.Prenom);
        }

        public Acteur? GetCompareTo(Acteur item)
        {
            return BaseRepo.GetCompareTo(a => a.Nom == item.Nom && a.Prenom == item.Prenom);
        }

        public void Add(Acteur item)
        {
            BaseRepo.Add(item);
        }

        public void Update(Acteur item)
        {
            BaseRepo.Update(item);
        }

        public void Delete(Acteur item)
        {
            BaseRepo.Delete(item);
        }


    }
}
