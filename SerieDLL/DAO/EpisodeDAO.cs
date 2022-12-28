using SerieDLL.Interface;
using SerieDLL.Model;
using SerieDLL.Repository;
using System.Data.SqlClient;

namespace SerieDLL.DAO
{
    public class EpisodeDAO : IDAOBase<Episode>, IEpisodeDAO
    {
        private string cnx = string.Empty;
        private EpisodeRepository repo = new();


        public string Cnx
        {
            get { return cnx; }
            set { cnx = value; }
        }

        public EpisodeDAO(string cnx)
        {
            Cnx = cnx;
        }

        //Ajoute un épisode dans la base
        void IDAOBase<Episode>.Add(Episode episode)
        {
            SqlConnection cnx = new(Cnx);

            string sql = repo.Add();
            SqlCommand cmd = new(sql, cnx);


            cmd = Bind(cmd, episode);


            Execute(sql, cnx, cmd);
        }

        //Supprime l'épisode avec l'id spécifié
        void IDAOBase<Episode>.Delete(int id)
        {
            string query = repo.Remove();

            using (SqlConnection cnx = new(Cnx))
            {
                SqlCommand cmd = new(query, cnx);
                cmd.Parameters.AddWithValue("@id", id);
                Execute(query, cnx, cmd);
            }

        }

        //Récupère tous les épisodes
        List<Episode> IDAOBase<Episode>.GetAll()
        {
            List<Episode> list = new List<Episode>();
            string query = repo.SelectAll();
            using (SqlConnection cnx = new(Cnx))
            {
                SqlCommand cmd = new(query, cnx);
                cnx.Open();

                list = Get(cmd);

            }
            return list;
        }

        //Récupère l'épisode qui a l'id spécifié
        Episode IDAOBase<Episode>.GetById(int id)
        {
            List<Episode> list = new List<Episode>();
            string query = repo.SelectById();
            using (SqlConnection cnx = new(Cnx))
            {
                SqlCommand cmd = new(query, cnx);
                cmd = AddParam(cmd, "@id", id);
                cnx.Open();

                list = Get(cmd);

            }

            return list[0];
        }

        //Met à jour l'épisode avec l'id spécifié avec les nouvelles valeurs 
        void IDAOBase<Episode>.Update(Episode episode)
        {
            SqlConnection cnx = new(Cnx);

            string query = repo.Modify();
            SqlCommand cmd = new(query, cnx);

            cmd = Bind(cmd, episode);

            cmd = AddParam(cmd, "@id", episode.Id);

            Execute(query, cnx, cmd);
        }

        //Récupère les épisodes qui appartiennent à la saison spécifiée
        public List<Episode> GetEpisodes(int id)
        {
            List<Episode> list = new List<Episode>();
            string query = repo.SelectBySaison();
            using (SqlConnection cnx = new(Cnx))
            {
                SqlCommand cmd = new(query, cnx);
                cmd.Parameters.AddWithValue("@id", id);
                cnx.Open();

                list = Get(cmd);

            }
            return list;
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

        //Récupère les épisodes en fonction de la requète passée dans la commande
        private List<Episode> Get(SqlCommand cmd)
        {
            List<Episode> list = new List<Episode>();
            SaisonDAO repoSaison = new(Cnx);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Episode episode = new()
                    {
                        Id = reader.GetInt32(0),
                        Nom = reader.GetString(2),
                        SaisonId = repoSaison.GetById(reader.GetInt32(1)),
                        Resume = reader.GetString(3),
                        DatePremDiff = reader.GetDateTime(4)
                    };

                    list.Add(episode);
                }
            }
            return list;
        }

        //Remplace le champ par la valeur passée en paralètre dans la requète
        private static SqlCommand AddParam(SqlCommand command, string champ, object value)
        {
            command.Parameters.AddWithValue(champ, value);
            return command;
        }

        //Remplace les champs saison_id, nom, date_prem_diff et resume par leur valeur correspondante
        private SqlCommand Bind(SqlCommand cmd, Episode episode)
        {
            cmd = AddParam(cmd, "@saison_id", episode.SaisonId.Id);
            cmd = AddParam(cmd, "@nom", episode.Nom);
            cmd = AddParam(cmd, "@date_prem_dif", episode.DatePremDiff);
            cmd = AddParam(cmd, "@resume", episode.Resume);

            return cmd;
        }
    }




}
