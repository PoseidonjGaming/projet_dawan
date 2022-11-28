using projet_dawan.Interface;
using projet_dawan.Model;
using projet_dawan.Repository;
using SerieDLL.Interface;
using System.Data.SqlClient;

namespace projet_dawan.DAO
{
    public class UserRoleDAO :  IUserRoleDAO
    {
        private string cnx = string.Empty;
        private UserRoleRepository repo = new();


        public string Cnx
        {
            get { return cnx; }
            set { cnx = value; }
        }

        public UserRoleDAO(string cnx)
        {
            Cnx = cnx;
        }

        //Associe un user à un role
        public void Add(UserApp user, Role role)
        {
            SqlConnection cnx = new(Cnx);
            string query = repo.Add();
            SqlCommand cmd = new(query, cnx);
            cmd = Bind(cmd, user, role);
            Execute(query, cnx, cmd);
        }

        //Supprime un role d'un user
        public void Delete(UserApp user, Role role)
        {
            string query = repo.Remove();

            using (SqlConnection cnx = new(Cnx))
            {
                SqlCommand cmd = new(query, cnx);
                cmd = Bind(cmd, user, role);
                Execute(query, cnx, cmd);
            }
        }


        //Récupère tous les users qui possèdent un role précis
        public List<UserApp> GetAllUser(int id)
        {
            List<UserApp> list = new List<UserApp>();
            string query = repo.SelectByRole();

            using (SqlConnection cnx = new(Cnx))
            {
                SqlCommand cmd = new(query, cnx);
                cmd = AddParam(cmd, "@role_id", id);

                cnx.Open();


                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    UserAppDAO dao = new(Cnx);
                    while (reader.Read())
                    {
                        UserApp user = dao.GetById(reader.GetInt32(1));

                        list.Add(user);
                    }
                }
            }

            return list;
        }

        //Récupère tous les roles d'un user
        public List<Role> GetAllRole(int id)
        {
            List<Role> list = new List<Role>();
            string query = repo.SelectByUser();

            using (SqlConnection cnx = new(Cnx))
            {
                SqlCommand cmd = new(query, cnx);
                cmd = AddParam(cmd, "@id", id);

                cnx.Open();


                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    IDAOBase<Role> dao = new RoleDAO(Cnx);
                    while (reader.Read())
                    {
                        Role role = dao.GetById(reader.GetInt32(0));

                        list.Add(role);
                    }
                }
            }

            return list;
        }

        //Modifie le role du user
        public void Update(UserApp user, Role role, Role oldRole)
        {
            
            string query = repo.SelectId();
            int id = 0;
            using (SqlConnection cnx = new(Cnx))
            {
                SqlCommand cmd = new(query, cnx);
                cmd = Bind(cmd, user, oldRole);

                cnx.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    
                    while (reader.Read())
                    {
                        id = reader.GetInt32(0);
                    }
                }

                query= repo.Modify();
                cmd.CommandText = query;
                cmd = AddParam(cmd, "id", id);
                cmd = Bind(cmd, user, role);

                cmd.ExecuteNonQuery();
            }

        }

        //Exécute les commandes de type insert, delete
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

        //Remplace le champ par la valeur passée en paramètre dans la requète
        private static SqlCommand AddParam(SqlCommand command, string champ, object value)
        {
            command.Parameters.AddWithValue(champ, value);
            return command;
        }

        //Remplace les champ user_id, role_id par leur valeur correspondante
        private SqlCommand Bind(SqlCommand cmd, UserApp user, Role role)
        {
            cmd = AddParam(cmd, "@userApp_id", user.Id);
            cmd = AddParam(cmd, "@role_id", role.Id);

            return cmd;
        }
    }




}
