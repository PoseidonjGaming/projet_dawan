using projet_dawan.Interface;
using projet_dawan.Model;
using projet_dawan.Repository;
using SerieDLL.Interface;
using System.Data.SqlClient;

namespace projet_dawan.DAO
{
    public class PersonnageDAO : IDAOBase<Personnage>, IPersonnageDAO
    {
        private string cnx = string.Empty;
        private PersonnageRepository repo = new();


        public string Cnx
        {
            get { return cnx; }
            set { cnx = value; }
        }

        public PersonnageDAO(string cnx)
        {
            Cnx = cnx;
        }

        //Ajoute un personnage dans la base
        void IDAOBase<Personnage>.Add(Personnage perso)
        {
            SqlConnection cnx = new(Cnx);

            string sql = repo.Add();
            SqlCommand cmd = new(sql, cnx);


            cmd = Bind(cmd, perso);


            Execute(sql, cnx, cmd);
        }

        //Supprime le personnage avec l'id spécifié
        void IDAOBase<Personnage>.Delete(int id)
        {
            string query = repo.Remove();

            using (SqlConnection cnx = new(Cnx))
            {
                SqlCommand cmd = new(query, cnx);
                cmd.Parameters.AddWithValue("@id", id);
                Execute(query, cnx, cmd);
            }

        }

        //Récupère tous les personnages
        List<Personnage> IDAOBase<Personnage>.GetAll()
        {
            List<Personnage> list = new List<Personnage>();
            string query = repo.SelectAll();
            using (SqlConnection cnx = new(Cnx))
            {
                SqlCommand cmd = new(query, cnx);
                cnx.Open();

                list = Get(cmd);

            }
            return list;
        }

        //Récupère le personnage qui a l'id spécifié
        Personnage? IDAOBase<Personnage>.GetById(int id)
        {
            List<Personnage> list = new List<Personnage>();
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

        public List<Personnage> GetPersonnages(int id)
        {
            List<Personnage> list = new List<Personnage>();
            string query = repo.SelectBySerie();
            using (SqlConnection cnx = new(Cnx))
            {
                SqlCommand cmd = new(query, cnx);
                cmd = AddParam(cmd, "@id", id);
                cnx.Open();
                IDAOBase<Acteur> repoActeur = new ActeurDAO(Cnx);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Personnage perso = new()
                        {
                            Id = reader.GetInt32(0),
                            Nom = reader.GetString(3),
                            ActeurId = repoActeur.GetById(reader.GetInt32(1)),
                            SerieId=null
                        };

                        list.Add(perso);
                    }


                }



                return list;


            }
        }

        //Met à jour le personnage avec l'id spécifié avec les nouvelles valeurs 
        void IDAOBase<Personnage>.Update(Personnage perso)
        {
            SqlConnection cnx = new(Cnx);

            string query = repo.Modify();
            SqlCommand cmd = new(query, cnx);

            cmd = Bind(cmd, perso);

            cmd = AddParam(cmd, "@id", perso.Id);

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

        //Récupère les personnages en fonction de la requète passée dans la commande
        private List<Personnage> Get(SqlCommand cmd)
        {
            List<Personnage> list = new List<Personnage>();
            IDAOBase<Serie> repoSerie = new SerieDAO(Cnx);
            IDAOBase<Acteur> repoActeur = new ActeurDAO(Cnx);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Personnage perso = new()
                    {
                        Id = reader.GetInt32(0),
                        Nom = reader.GetString(2),
                        SerieId = repoSerie.GetById(reader.GetInt32(3)),
                        ActeurId = repoActeur.GetById(reader.GetInt32(1))

                    };

                    list.Add(perso);
                }
            }
            return list;
        }

        //Remplace le champ par la valeur passée en paramètre dans la requète
        private SqlCommand AddParam(SqlCommand command, string champ, object value)
        {
            command.Parameters.AddWithValue(champ, value);
            return command;
        }

        //Remplace les champs nom, serie_id, et acteur_id par leur valeur correspondante
        private SqlCommand Bind(SqlCommand cmd, Personnage perso)
        {
            cmd = AddParam(cmd, "@nom", perso.Nom);
            cmd = AddParam(cmd, "@serie_id", perso.SerieId.Id);
            cmd = AddParam(cmd, "@acteur_id", perso.ActeurId.Id);

            return cmd;
        }
    }




}
