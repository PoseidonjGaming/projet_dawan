namespace projet_dawan.Repository
{
    public class EpisodeRepository : Orm
    {
        private readonly string table;
        private readonly List<string> champs = new List<string>() { "saison_id", "nom", "resume", "date_prem_diff" };
        private readonly List<string> values = new List<string>() { "@saison_id", "@nom", "@resume", "@date_prem_diff" };
        public EpisodeRepository()
        {
            table = "episode";
        }

        //Génère Insert into episode (saison_id, nom, resume, date_prem_diff) values (@saison_id, @nom, @resume, @date_prem_diff)
        public string Add()
        {
            return Insert(table, champs.ToArray())
                .Values(values.ToArray()).Build();
        }
        //Génère Delete from episode where id=@id

        public string Remove()
        {
            return Delete(table).Build();

        }
        //Génère select * from episode
        public string SelectAll()
        {
            return Select("*").From(table).Build();
        }
        //Génère select * from episode where id=@id
        public string SelectById()
        {
            return Select("*").From(table).WhereById("id").Build();
        }

        //Génère select * from episode where saison_id=@id
        public string SelectBySaison()
        {
            return Select("*").From(table).WhereById("saison_id").Build();
        }

        //Génère update episode set saison_id=@saison_id, nom=@nom,resume=@resume,date_prem_diff=@date_prem_diff where id=@id
        public string Modify()
        {
            return Update(table, champs, values).Build();
        }


    }
}
