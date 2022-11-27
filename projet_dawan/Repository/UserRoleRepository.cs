using Newtonsoft.Json.Linq;
using projet_dawan.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_dawan.Repository
{
    public class UserRoleRepository : Orm
    {
        private string table;
        private List<string> champs = new List<string>() { "userRoles_id", "role_id" };
        private List<string> values = new List<string>() { "@userRoles_id", "@role_id" };
        public UserRoleRepository()
        {
            table = "userRoles";
        }

       

        //Génère Insert into userRoles (login, password) values (@login, @password)
        public string Add()
        {
            return Insert(table, champs.ToArray())
                .Values(values.ToArray()).Build();
        }

        //Génère Delete from userRoles where id=@id
        public string Remove()
        {
            return Delete(table).Build();

        }
        //Génère Delete from userRoles where user_id=@id
        public string RemoveByUser()
        {
            return Delete(table).Where("user_id", "@user_id").Build();

        }
        //Génère select * from userRoles
        public string SelectAll()
        {
            return Select("*").From(table).Build();
        }
        //Génère select * from userRoles where id=@id
        public string SelectById()
        {
            return Select("*").From(table).WhereById("id").Build();
        }

        //Génère select * from userRoles where user_id=@id
        public string SelectByRole()
        {
            return Select("*").From(table).WhereById("role_id").Build();
        }

        //Génère select * from userRoles where user_id=@id
        public string SelectByUser()
        {
            return Select("*").From(table).WhereById("user_id").Build();
        }




        //Génère update userRoles set login=@login, password=@password where id=@id
        public string Modify()
        {
            return Update(table, champs, values).Build();
        }

    }
}
