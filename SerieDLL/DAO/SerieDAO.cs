using projet_dawan.Interface;
using projet_dawan.Model;
using projet_dawan.Repository;
using SerieDLL.Interface;
using System.Data.SqlClient;

namespace projet_dawan.DAO
{
    public class SerieDAO : IDAOBase<Serie>, ISerieDAO
    {
        private string cnx;
        private SerieRepository repo = new();
       

        public string Cnx
        {
            get { return cnx; }
            set { cnx = value; }
        }

        public SerieDAO(string cnx)
        {
            Cnx = cnx;
        }

        //Ajoute une série dans la base
        void IDAOBase<Serie>.Add(Serie serie)
        {
            SqlConnection cnx = new(Cnx);

            string sql = repo.Add();
            SqlCommand cmd = new(sql, cnx);


            cmd = Bind(cmd, serie);

            Execute(sql, cnx, cmd);

        }

        //Supprime une séire avec l'id spécifié
        void IDAOBase<Serie>.Delete(int id)
        {
            string query = repo.Remove();

            using (SqlConnection cnx = new(Cnx))
            {
                SqlCommand cmd = new(query, cnx);
                cmd.Parameters.AddWithValue("@id", id);
                Execute(query, cnx, cmd);
            }

        }

        //Récupère toutes les séries
        List<Serie> IDAOBase<Serie>.GetAll()
        {
            List<Serie> list = new List<Serie>();
            string query = repo.SelectAll();
            using (SqlConnection cnx = new(Cnx))
            {
                SqlCommand cmd = new(query, cnx);
                cnx.Open();

                list = Get(cmd);

            }
            return list;
        }

        //Récupère une série avec l'id spécifié
        Serie? IDAOBase<Serie>.GetById(int id)
        {
            List<Serie> list = new List<Serie>();
            string query = repo.SelectById();
            using (SqlConnection cnx = new(Cnx))
            {
                SqlCommand cmd = new(query, cnx);
                cmd = AddParam(cmd, "@id", id);
                cnx.Open();

                list = Get(cmd);

            }

            if (list.Count == 1)
            {
                return list[0];
            }

            return null;
        }

        //Récupère une série avec où le champ nom contient le text passé en paramètre
        public List<Serie> GetByTxt(string text)
        {
            List<Serie> list = new List<Serie>();
            string query = repo.SelectByNom();
            using (SqlConnection cnx = new(Cnx))
            {
                SqlCommand cmd = new(query, cnx);
                cmd = AddParam(cmd, "@text", "%"+text+"%");
                
                cnx.Open();

                list = Get(cmd);

            }

            return list;

        }

        //Met à jour la série avec l'id spécifié avec les nouvelles valeurs
        void IDAOBase<Serie>.Update(Serie serie)
        {
            SqlConnection cnx = new(Cnx);

            string query = repo.Modify();
            SqlCommand cmd = new(query, cnx);


            cmd = AddParam(cmd, "@id", serie.Id);

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

        //Récupère les séries en fonction de la requète passée dans la commande
        private static List<Serie> Get(SqlCommand cmd)
        {
            List<Serie> list = new List<Serie>();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Serie serie = new()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        DateDiff = reader.GetDateTime(2),
                        Resume = reader.GetString(3),
                        Affiche = reader.GetString(4),
                        UrlBa = reader.GetString(5)

                    };

                    list.Add(serie);
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

        //Remplace les champ nom, date_diff, url_ba, resume et affiche par leur valeur correspondante
        private SqlCommand Bind(SqlCommand cmd, Serie serie)
        {
            cmd = AddParam(cmd, "@nom", serie.Name);
            cmd = AddParam(cmd, "@date_diff", serie.DateDiff);
            cmd = AddParam(cmd, "@url_ba", serie.UrlBa);
            cmd = AddParam(cmd, "@resume", serie.Resume);
            cmd = AddParam(cmd, "@affiche", serie.Affiche);

            return cmd;
        }
    }




}
