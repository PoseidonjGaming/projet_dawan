using projet_dawan.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieDLL.Repository
{
    public class RoleRepository : Orm
    {
        private string table;
        private List<string> champs = new List<string>() { "titre" };
        private List<string> values = new List<string>() { "@titre" };
        public RoleRepository()
        {
            table = "roles";
        }

        //Génère Insert into roles (titre) values (@titre)
        public string Add()
        {
            return Insert(table, champs.ToArray())
                .Values(values.ToArray()).Build();
        }
        //Génère Delete from roles where id=@id

        public string Remove()
        {
            return Delete(table).Build();

        }
        //Génère select * from roles
        public string SelectAll()
        {
            return Select("*").From(table).Build();
        }
        //Génère select * from roles where id=@id
        public string SelectById()
        {
            return Select("*").From(table).WhereById("id").Build();
        }

        public string SelectByUser()
        {
            return Select("*").From("userRoles").WhereById("userApp_id").Build();
        }

        //Génère update roles set titre=@titre where id=@id
        public string Modify()
        {
            return Update(table, champs, values).Build();
        }


    }
}
