using projet_dawan.Interface;
using projet_dawan.Model;
using projet_dawan.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_dawan.DAO
{
    public class UserRoleDAO : IUserRoleDAO
    {
        private string cnx = string.Empty;
        private UserRoleRepository repo = new();
        private string table;
        private List<string> champs = new List<string>() { "userApp_id", "role_id" };
        private List<string> values = new List<string>() { "@userApp_id", "@role_id" };

        public string Cnx
        {
            get { return cnx; }
            set { cnx = value; }
        }

        public UserRoleDAO(string cnx)
        {
            Cnx = cnx;
            table = "userRoles";
        }
        public void Add(UserApp user, Role role)
        {
            SqlConnection cnx = new(Cnx);

            string sql = repo.Insert(table, champs.ToArray())
                .Values(values.ToArray()).Build();
            SqlCommand cmd = new(sql, cnx);


            cmd = Bind(cmd, user, role);


            Execute(sql, cnx, cmd);
            // MessageBox.Show(sql);
        }

        public void Delete(int id)
        {
            string query = repo.Delete(table).Build();

            using (SqlConnection cnx = new(Cnx))
            {
                SqlCommand cmd = new(query, cnx);
                cmd.Parameters.AddWithValue("@id", id);
                Execute(query, cnx, cmd);
                //MessageBox.Show(query);
            }

        }



        public List<UserApp> GetAllUser(int id)
        {
            List<UserApp> list = new List<UserApp>();
            string query = repo.Select("*").From(table).WhereById("userApp_id").Build();

            using (SqlConnection cnx = new(Cnx))
            {
                SqlCommand cmd = new(query, cnx);
                cmd = AddParam(cmd, "userApp_id", id);

                cnx.Open();


                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    UserAppDAO dao = new(Cnx);
                    while (reader.Read())
                    {
                        UserApp user = dao.GetById(reader.GetInt32(0));

                        list.Add(user);
                    }
                }
            }

            return list;
        }
        public List<Role> GetAllRole(int id)
        {
            List<Role> list = new List<Role>();
            string query = repo.Select("*").From(table).WhereById("role_id").Build();

            using (SqlConnection cnx = new(Cnx))
            {
                SqlCommand cmd = new(query, cnx);
                cmd = AddParam(cmd, "@id", id);

                cnx.Open();


                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    RoleDAO dao = new(Cnx);
                    while (reader.Read())
                    {
                        Role role = dao.GetById(reader.GetInt32(0));

                        list.Add(role);
                    }
                }
            }

            return list;
        }

        public void Update(UserApp user, Role role, int id)
        {
            SqlConnection cnx = new(Cnx);

            string query = repo.Update(table, champs, values).Build();
            SqlCommand cmd = new(query, cnx);

            cmd = Bind(cmd, user, role);

            cmd = AddParam(cmd, "@id", id);

            Execute(query, cnx, cmd);
            //MessageBox.Show(query);
        }

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

        



        private static SqlCommand AddParam(SqlCommand command, string champ, object value)
        {
            command.Parameters.AddWithValue(champ, value);
            return command;
        }

        private SqlCommand Bind(SqlCommand cmd, UserApp user, Role role)
        {
            cmd = AddParam(cmd, "@userApp_id", user.Id);
            cmd = AddParam(cmd, "@role_id", role.Id);

            return cmd;
        }
    }




}
