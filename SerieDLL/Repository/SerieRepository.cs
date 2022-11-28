using projet_dawan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_dawan.Repository
{
    public class SerieRepository : Orm
    {
        private string table;
        private List<string> champs = new List<string>() { "nom", "resume", "affiche", "url_ba", "date_diff" };
        private List<string> values = new List<string>() { "@nom", "@resume", "@affiche", "@url_ba", "@date_diff" };
        public SerieRepository()
        {
            table = "serie";
        }

        //Génère Insert into serie (serie_id, numero, nb_episode) values (@serie_id, @numero, @nb_episode)
        public string Add()
        {
            return Insert(table, champs.ToArray())
                .Values(values.ToArray()).Build();
        }
        //Génère Delete from serie where id=@id

        public string Remove()
        {
            return Delete(table).Build();

        }
        //Génère select * from serie
        public string SelectAll()
        {
            return Select("*").From(table).Build();
        }
        //Génère select * from serie where id=@id
        public string SelectById()
        {
            return Select("*").From(table).WhereById("id").Build();
        }

        //Génère select * from serie where nom like @text
        public string SelectByNom()
        {
            return Select("*").From(table).WhereByLike("nom").Build();
        }

        //Génère update serie set serie_id=@serie_id, numero=@numero, nb_episode=@nb_episode where id=@id
        public string Modify()
        {
            return Update(table, champs, values).Build();
        }


    }
}
