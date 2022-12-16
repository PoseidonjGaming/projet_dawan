using projet_dawan.Model;
using projet_dawan.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieDLL.Repository
{
    public class SaisonRepository : Orm
    {
        private string table;
        private List<string> champs = new List<string>() { "serie_id", "numero", "nb_episode" };
        private List<string> values = new List<string>() { "@serie_id", "@numero", "@nb_episode" };
        public SaisonRepository()
        {
            table = "saison";
        }

        //Génère Insert into saison (serie_id, numero, nb_episode) values (@serie_id, @numero, @nb_episode)
        public string Add()
        {
            return Insert(table, champs.ToArray())
                .Values(values.ToArray()).Build();
        }
        //Génère Delete from saison where id=@id

        public string Remove()
        {
            return Delete(table).Build();

        }
        //Génère select * from saison
        public string SelectAll()
        {
            return Select("*").From(table).Build();
        }
        //Génère select * from table where id=@id
        public string SelectById()
        {
            return Select("*").From(table).WhereById("id").Build();
        }

        //Génère select * from saison where serie_id=@id
        public string SelectBySaisons()
        {
            return Select("*").From(table).WhereById("serie_id").Build();
        }

        //Génère update saison set serie_id=@serie_id, numero=@numero, nb_episode=@nb_episode where id=@id
        public string Modify()
        {
            return Update(table, champs, values).Build();
        }

    }
}
