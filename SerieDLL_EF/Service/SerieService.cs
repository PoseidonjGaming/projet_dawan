using projet_dawan.Models;
using SerieDLL_EF.Repository;
using SerieDLL_EF.Service;

namespace projet_dawan
{
    /*
    * Classe qui hérite de la classe Service et qui type Service pour le type Série
    */
    public class SerieService : Service<Serie, SerieRepository>
    {
        public SerieService() : base(new SerieRepository()) { }

        //Récupère la liste des séries dont le nom contient la chaîne txt
        public List<Serie> GetByTxt(string text)
        {
            return repo.GetByTxt(text);
        }

        public List<Serie> Export(List<int> ids)
        {
            List<Serie> list = new();
            foreach(int id in ids)
            {
                list.Add(repo.GetById(id));
            }
            return list;
        }
    }
}