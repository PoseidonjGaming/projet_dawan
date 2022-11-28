namespace projet_dawan.Repository
{
    public class ActeurRepository : Orm
    {
        private readonly string table;
        private readonly List<string> champs = new List<string>() { "nom", "prenom" };
        private readonly List<string> values = new List<string>() { "@nom", "@prenom" };
        public ActeurRepository()
        {
            table = "acteur";
        }

        //Génère Insert into acteur (nom,prenom) values (@nom,@prenom)
        public string Add()
        {
            return Insert(table, champs.ToArray())
                .Values(values.ToArray()).Build();
        }
        //Génère Delete from acteur where id=@id

        public string Remove()
        {
            return Delete(table).Build();

        }
        //Génère select * from acteur
        public string SelectAll()
        {
            return Select("*").From(table).Build();
        }
        //Génère select * from acteur where id=@id
        public string SelectById()
        {
            return Select("*").From(table).WhereById("id").Build();
        }

        //Génère update acteur set nom=@nom, prenom=@prenom where id=@id
        public string Modify()
        {
            return Update(table, champs, values).Build();
        }
    }
}
