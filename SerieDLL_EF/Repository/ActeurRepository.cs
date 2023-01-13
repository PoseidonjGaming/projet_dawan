using SerieDLL_EF.Interface;
using SerieDLL_EF.Models;
using System.Linq.Expressions;
using static System.Net.Mime.MediaTypeNames;

namespace SerieDLL_EF.Repository
{
    /*
     * Les Répositories sont les classes qui gèrent la bdd.
     * Dans notre cas, elles implèment les interfaces du dossier Interface, pour plus de simplicité
     * Cette classe implémente les interfaces IRepoCRUD et IRepSpecials pour gérer la table acteur
     */
    public class ActeurRepository : BaseRepo<Acteur>,  IRepoCRUD<Acteur>, IRepSpecials<Acteur>
    {
        public ActeurRepository():base()
        {
            DbSet = Context.Acteurs;
        }

        public Acteur GetById(int id)
        {
            return GetById(p=> p.Id==id);
        }

        public List<Acteur> GetByTxt(string txt)
        {
            return GetByTxt(a => a.Nom.Contains(txt) || a.Prenom.Contains(txt));
        }

        public bool CompareTo(Acteur item)
        {
            return CompareTo(a => a.Nom == item.Nom && a.Prenom == item.Prenom);
        }

        public Acteur? GetCompareTo(Acteur item)
        {
            return GetCompareTo(a => a.Nom == item.Nom && a.Prenom == item.Prenom);
        }

        
    }
}
