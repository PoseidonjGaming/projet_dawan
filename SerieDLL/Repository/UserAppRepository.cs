﻿namespace SerieDLL.Repository
{
    public class UserAppRepository : Orm
    {
        private string table;
        private List<string> champs = new List<string>() { "user_id", "role_id" };
        private List<string> values = new List<string>() { "@user_id", "@role_id" };
        public UserAppRepository()
        {
            table = "userApp";
        }

        //Génère Insert into userApp (login, password) values (@login, @password)
        public string Add()
        {
            return Insert(table, champs.ToArray())
                .Values(values.ToArray()).Build();
        }

        //Génère Delete from userApp where id=@id
        public string Remove()
        {
            return Delete(table).Build();

        }
        //Génère select * from userApp
        public string SelectAll()
        {
            return Select("*").From(table).Build();
        }
        //Génère select * from userApp where id=@id
        public string SelectById()
        {
            return Select("*").From(table).WhereById("id").Build();
        }

        //Génère select * from userApp where Like=@id
        public string SelectByLogin()
        {
            return Select("*").From(table).WhereByLike("login").Build();
        }

        //Génère update userApp set login=@login, password=@password where id=@id
        public string Modify()
        {
            return Update(table, champs, values).Build();
        }



    }
}
