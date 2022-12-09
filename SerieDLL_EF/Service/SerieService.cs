using projet_dawan.Models;
using SerieDLL_EF.Repository;
using SerieDLL_EF.Service;

namespace projet_dawan
{
    public class SerieService: Service<Serie, SerieRepository>
    {
        public SerieService():base(new SerieRepository()) { }
    }
}