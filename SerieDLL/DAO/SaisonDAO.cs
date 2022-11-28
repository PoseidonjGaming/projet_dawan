using projet_dawan.Model;
using projet_dawan.Repository;
using SerieDLL.Interface;
using System.Data.SqlClient;

namespace projet_dawan.DAO
{
    public class SaisonDAO
    {
        private string cnx = string.Empty;
        private readonly SaisonRepository repo = new();
       

        public string Cnx
        {
            get { return cnx; }
            set { cnx = value; }
        }

        public SaisonDAO(string cnx)
        {
            Cnx = cnx;
        }

        //Ajoute une saison dans la base
        public void Add(Saison saison)
        {
            SqlConnection cnx = new(Cnx);

            string sql = repo.Add();
            SqlCommand cmd = new(sql, cnx);


            cmd = Bind(cmd, saison);


            Execute(sql, cnx, cmd);
        }

        //Supprime une saison avec l'id spécifié
        public void Delete(int id)
        {
            string query = repo.Remove();

            using (SqlConnection cnx = new(Cnx))
            {
                SqlCommand cmd = new(query, cnx);
                cmd.Parameters.AddWithValue("@id", id);
                Execute(query, cnx, cmd);
            }

        }

        //Récupère toutes les saisons
        public List<Saison> GetAll()
        {
            List<Saison> list = new List<Saison>();
            string query = repo.SelectAll();
            using (SqlConnection cnx = new(Cnx))
            {
                SqlCommand cmd = new(query, cnx);
                cnx.Open();

                list = Get(cmd);

            }
            return list;
        }

        //Récupère une saison avec l'id spécifié
        public Saison? GetById(int id)
        {
            List<Saison> list = new List<Saison>();
            string query = repo.SelectById();
            using (SqlConnection cnx = new(Cnx))
            {
                SqlCommand cmd = new(query, cnx);
                cmd = AddParam(cmd, "@id", id);
                cnx.Open();

                list = Get(cmd);
                return list[0];

            }

        }

        //Récupère toutes les sainsons d'une série avec l'id spécifié
        public List<Saison> GetSaisons(int id)
        {
            List<Saison> list = new List<Saison>();
            string query = repo.SelectBySaisons();
            using (SqlConnection cnx = new(Cnx))
            {
                SqlCommand cmd = new(query, cnx);
                cmd.Parameters.AddWithValue("@id", id);
                cnx.Open();

                list = Get(cmd);

            }
            return list;
        }

        //Met à jour la saison avec l'id spécifié avec les nouvelles valeurs
        public void Update(Saison saison)
        {
            SqlConnection cnx = new(Cnx);
            string query = repo.Modify();
            SqlCommand cmd = new(query, cnx);

            cmd = Bind(cmd, saison);

            cmd = AddParam(cmd, "@id", saison.Id);

            Execute(query, cnx, cmd);
        }

        //Exécute les commandes de type insert, delete et update
        public static void Execute(string query, SqlConnection cnx, SqlCommand cmd)
        {
            try
            {
                cnx.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cnx.Close();
            }
        }

        //Récupère les saisons en fonction de la requète passée dans la commande
        private List<Saison> Get(SqlCommand cmd)
        {
            List<Saison> list = new List<Saison>();
            IDAOBase<Serie> repoSerie = new SerieDAO(Cnx);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Saison saison = new()
                    {
                        Id = reader.GetInt32(0),
                        SerieId = repoSerie.GetById(reader.GetInt32(1)),
                        Num = reader.GetInt16(2),
                        NbEpisode = reader.GetInt32(3)
                    };

                    list.Add(saison);
                }
            }
            return list;
        }

        //Remplace le champ par la valeur passée en paramètre dans la requète
        private static SqlCommand AddParam(SqlCommand command, string champ, object value)
        {
            command.Parameters.AddWithValue(champ, value);
            return command;
        }

        //Remplace le champ titre par la valeur correspondante
        private SqlCommand Bind(SqlCommand cmd, Saison saison)
        {
            cmd = AddParam(cmd, "@serie_id", saison.SerieId.Id);
            cmd = AddParam(cmd, "@numero", saison.Num);
            cmd = AddParam(cmd, "@nb_episode", saison.NbEpisode);

            return cmd;
        }
    }




}
