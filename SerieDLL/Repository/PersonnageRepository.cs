using projet_dawan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieDLL.Repository
{
    public class PersonnageRepository : Orm
    {
        private string table;
        private List<string> champs = new List<string>() { "nom", "serie_id", "acteur_id" };
        private List<string> values = new List<string>() { "@nom", "@serie_id", "@acteur_id" };
        public PersonnageRepository()
        {
            table = "personnage";
        }

        //Génère Insert into personnage (nom, serie_id, acteur_id) values (@nom, @serie_id, @acteur_id)
        public string Add()
        {
            return Insert(table, champs.ToArray())
                .Values(values.ToArray()).Build();
        }
        //Génère Delete from personnage where id=@id

        public string Remove()
        {
            return Delete(table).Build();

        }
        //Génère select * from personnage
        public string SelectAll()
        {
            return Select("*").From(table).Build();
        }
        //Génère select * from personnage where id=@id
        public string SelectById()
        {
            return Select("*").From(table).WhereById("id").Build();
        }

        //Génère update personnage set nom=@nom, serie_id=@serie_id, acteur_id=@acteur_id where id=@id
        public string Modify()
        {
            return Update(table, champs, values).Build();
        }



    }
}
