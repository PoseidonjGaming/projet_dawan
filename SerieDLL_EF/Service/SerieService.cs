using SerieDLL_EF.Models;
using SerieDLL_EF.Repository;
using System.Xml.Serialization;

namespace SerieDLL_EF.Service
{
    /*
    * Classe qui hérite de la classe Service et qui type Service pour le type Série
    */
    public class SerieService : Service<Serie, SerieRepository>
    {
        public SerieService() : base(new SerieRepository()) { }

        //Récupère la liste des séries dont l'id est présent dans la liste toWatch
        public List<Serie> ExportWatchList(List<int> toWatch)
        {
            return repo.ExportWatchList(toWatch);
        }

        //Récupère la liste des séries dont le nom contient la chaîne txt
        public List<Serie> GetByTxt(string text)
        {
            return repo.GetByTxt(text);
        }


        

        


    }
}