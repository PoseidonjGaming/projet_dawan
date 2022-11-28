using projet_dawan.Interface;
using projet_dawan.Model;
using projet_dawan.Repository;
using System.Data.SqlClient;

namespace projet_dawan.DAO
{
    public class UserAppDAO : IUserAppDAO
    {
        private string cnx = string.Empty;
        private UserAppRepository repo = new();
       

        public string Cnx
        {
            get { return cnx; }
            set { cnx = value; }
        }

        public UserAppDAO(string cnx)
        {
            Cnx = cnx;
        }

        //Ajoute un user dans la base avec ses roles
        public void Add(UserApp user)
        {
            SqlConnection cnx = new(Cnx);

            string sql = repo.Add();



            SqlCommand cmd = new(sql, cnx);
            cmd = Bind(cmd, user);

            Execute(sql, cnx, cmd);

            UserRoleDAO dao = new(Cnx);
            foreach (Role role in user.Roles)
            {
                dao.Add(user, role);
            }
        }

        //Supprime un user de la base avec ses role
        public void Delete(int id)
        {
            string query = repo.Remove();

            using (SqlConnection cnx = new(Cnx))
            {
                SqlCommand cmd = new(query, cnx);
                UserRoleDAO dao = new(Cnx);
                cmd.Parameters.AddWithValue("@id", id);
                Execute(query, cnx, cmd);
            }

        }

        //Récupère tous les users
        public List<UserApp> GetAll()
        {
            List<UserApp> list = new List<UserApp>();
            string query = repo.SelectAll();
            using (SqlConnection cnx = new(Cnx))
            {
                SqlCommand cmd = new(query, cnx);
                cnx.Open();

                list = Get(cmd);

            }
            return list;
        }

        //Récupère le user avec l'id passé em paramètre
        public UserApp GetById(int id)
        {
            List<UserApp> list = new List<UserApp>();
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

        //Récupère le user avec le login passé en paramètre
        public UserApp? GetByLogin(string text)
        {
            List<UserApp> list = new List<UserApp>();
            string query = repo.SelectByLogin();
            using (SqlConnection cnx = new(Cnx))
            {
                SqlCommand cmd = new(query, cnx);
                cmd = AddParam(cmd, "@text", text);

                cnx.Open();

                list = Get(cmd);

            }
            if (list.Count > 0)
            {
                return list[0];
            }
            else
            {
                return null;
            }

        }

        //Met à jour le user avec l'id spécifié avec les nouvelles valeurs
        public void Update(UserApp user)
        {
            SqlConnection cnx = new(Cnx);

            string query = repo.Modify();
            SqlCommand cmd = new(query, cnx);

            cmd = Bind(cmd, user);

            cmd = AddParam(cmd, "@id", user.Id);

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

        //Récupère les users en fonction de la requète passée dans la commande
        private List<UserApp> Get(SqlCommand cmd)
        {
            List<UserApp> list = new List<UserApp>();
            UserRoleDAO dao = new UserRoleDAO(Cnx);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    UserApp user = new()
                    {
                        Id = reader.GetInt32(0),
                        Login = reader.GetString(1),
                        Password = reader.GetString(2),
                        Roles = dao.GetAllRole(reader.GetInt32(0))

                    };

                    list.Add(user);
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

        //Remplace les champ login, password par leur valeur correspondante
        private SqlCommand Bind(SqlCommand cmd, UserApp user)
        {
            cmd = AddParam(cmd, "@login", user.Login);
            cmd = AddParam(cmd, "@password", user.Password);

            return cmd;
        }
    }




}
