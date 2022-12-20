using projet_dawan.Interface;
using projet_dawan.Model;
using SerieDLL.Interface;
using SerieDLL.Repository;
using System.Data.SqlClient;

namespace SerieDLL.DAO
{
    public class RoleDAO : IDAOBase<Role>, IRoleDAO
    {
        private string cnx = string.Empty;
        private RoleRepository repo = new();


        public string Cnx
        {
            get { return cnx; }
            set { cnx = value; }
        }

        public RoleDAO(string cnx)
        {
            Cnx = cnx;
        }
        //Ajoute un role dans la base
        void IDAOBase<Role>.Add(Role role)
        {
            SqlConnection cnx = new(Cnx);

            string sql = repo.Add();
            SqlCommand cmd = new(sql, cnx);


            cmd = Bind(cmd, role);


            Execute(sql, cnx, cmd);
        }

        //Supprime le role avec l'id spécifié
        void IDAOBase<Role>.Delete(int id)
        {
            string query = repo.Remove();

            using (SqlConnection cnx = new(Cnx))
            {
                SqlCommand cmd = new(query, cnx);
                cmd.Parameters.AddWithValue("@id", id);
                Execute(query, cnx, cmd);
            }

        }

        //Récupère tous les roles
        List<Role> IDAOBase<Role>.GetAll()
        {
            List<Role> list = new List<Role>();
            string query = repo.SelectAll();
            using (SqlConnection cnx = new(Cnx))
            {
                SqlCommand cmd = new(query, cnx);
                cnx.Open();

                list = Get(cmd);

            }
            return list;
        }
        //Récupère le role qui a l'id spécifié
        Role IDAOBase<Role>.GetById(int id)
        {
            List<Role> list = new List<Role>();
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

        //Récupère les roles liés à un user
        public List<Role> GetRolesUser(UserApp user)
        {
            List<Role> list = new List<Role>();
            string query = repo.SelectByUser();
            using (SqlConnection cnx = new(Cnx))
            {
                SqlCommand cmd = new(query, cnx);
                cmd = AddParam(cmd, "@id", user.Id);
                cnx.Open();

                list = Get(cmd);

            }

            return list;
        }

        //Met à jour le role avec l'id spécifié avec les nouvelles valeurs
        void IDAOBase<Role>.Update(Role role)
        {
            SqlConnection cnx = new(Cnx);

            string query = repo.Modify();
            SqlCommand cmd = new(query, cnx);

            cmd = Bind(cmd, role);

            cmd = AddParam(cmd, "@id", role.Id);

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

        //Récupère les roles en fonction de la requète passée dans la commande
        private static List<Role> Get(SqlCommand cmd)
        {
            List<Role> list = new List<Role>();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Role acteur = new()
                    {
                        Id = reader.GetInt32(0),
                        Titre = reader.GetString(1)
                    };

                    list.Add(acteur);
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
        private SqlCommand Bind(SqlCommand cmd, Role role)
        {
            cmd = AddParam(cmd, "@titre", role.Titre);

            return cmd;
        }
    }




}
