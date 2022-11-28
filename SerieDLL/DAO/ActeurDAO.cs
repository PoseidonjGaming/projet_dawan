using projet_dawan.Interface;
using projet_dawan.Model;
using projet_dawan.Repository;
using SerieDLL.Interface;
using System.Data.SqlClient;

namespace projet_dawan.DAO
{
    public class ActeurDAO : IDAOBase<Acteur>
    {
        private string cnx = string.Empty;
        private ActeurRepository repo = new();
        

        public string Cnx
        {
            get { return cnx; }
            set { cnx = value; }
        }

        public ActeurDAO(string cnx)
        {
            Cnx = cnx;
            
        }

        //Ajoute un acteur dans la base
        void IDAOBase<Acteur>.Add(Acteur obj)
        {
            SqlConnection cnx = new(Cnx);

            string sql = repo.Add();
            SqlCommand cmd = new(sql, cnx);


            cmd = Bind(cmd, obj);


            Execute(sql, cnx, cmd);
        }

        //Met à jour l'acteur avec l'id spécifié avec les nouvelles valeurs 
        void IDAOBase<Acteur>.Update(Acteur obj)
        {
            SqlConnection cnx = new(Cnx);

            string query = repo.Modify();
            SqlCommand cmd = new(query, cnx);

            cmd = Bind(cmd, obj);

            cmd = AddParam(cmd, "@id", obj.Id);

            Execute(query, cnx, cmd);
        }

        //Supprime l'acteur avec l'id spécifié
        void IDAOBase<Acteur>.Delete(int id)
        {
            string query = repo.Remove();
            using (SqlConnection cnx = new(Cnx))
            {
                SqlCommand cmd = new(query, cnx);
                cmd.Parameters.AddWithValue("@id", id);
                Execute(query, cnx, cmd);
            }
        }

        //Récupère tous les acteurs
        List<Acteur> IDAOBase<Acteur>.GetAll()
        {
            List<Acteur> list = new List<Acteur>();
            string query = repo.SelectAll();
            using (SqlConnection cnx = new(Cnx))
            {
                SqlCommand cmd = new(query, cnx);
                cnx.Open();

                list = Get(cmd);

            }
            return list;
        }

        //Récupère l'acteur qui a l'id spécifié
        Acteur IDAOBase<Acteur>.GetById(int id)
        {
            List<Acteur> list = new List<Acteur>();
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

        //Récupère les acteurs en fonction de la requète passée dans la commande
        private static List<Acteur> Get(SqlCommand cmd)
        {
            List<Acteur> list = new List<Acteur>();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Acteur acteur = new()
                    {
                        Id = reader.GetInt32(0),
                        Nom = reader.GetString(1),
                        Prenom = reader.GetString(2),

                    };

                    list.Add(acteur);
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

        //Remplace les champs nom et prenom par leur valeur correspondante
        private static SqlCommand Bind(SqlCommand cmd, Acteur acteur)
        {
            cmd = AddParam(cmd, "@nom", acteur.Nom);
            cmd = AddParam(cmd, "@prenom", acteur.Prenom);

            return cmd;
        }

    }




}
