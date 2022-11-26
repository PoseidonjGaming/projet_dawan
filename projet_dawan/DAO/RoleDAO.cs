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
    public class RoleDAO : IRoleDAO
    {
        private string cnx = string.Empty;
        private RoleRepository repo = new();
        private string table;
        private List<string> champs = new List<string>() { "titre", "password" };
        private List<string> values = new List<string>() { "@login", "@password" };

        public string Cnx
        {
            get { return cnx; }
            set { cnx = value; }
        }

        public RoleDAO(string cnx)
        {
            Cnx = cnx;
            table = "roles";
        }
        public void Add(Role role)
        {
            SqlConnection cnx = new(Cnx);

            string sql = repo.Insert(table, champs.ToArray())
                .Values(values.ToArray()).Build();
            SqlCommand cmd = new(sql, cnx);


            cmd = Bind(cmd, role);


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

        public List<Role> GetAll()
        {
            List<Role> list = new List<Role>();
            string query = repo.Select("*").From(table).Build();
            MessageBox.Show(query);
            using (SqlConnection cnx = new(Cnx))
            {
                SqlCommand cmd = new(query, cnx);
                cnx.Open();

                list = Get(cmd);

            }
            return list;
        }

        public Role GetById(int id)
        {
            List<Role> list = new List<Role>();
            string query = repo.Select("*").From(table).WhereById("id").Build();
            MessageBox.Show(query);
            using (SqlConnection cnx = new(Cnx))
            {
                SqlCommand cmd = new(query, cnx);
                cmd = AddParam(cmd, "@id", id);
                cnx.Open();

                list = Get(cmd);

            }

            return list[0];
        }

        public List<Role> GetRolesUser(UserApp user)
        {
            List<Role> list = new List<Role>();
            string query = repo.Select("*").From("userRoles").WhereById("userApp_id").Build();
            MessageBox.Show(query);
            using (SqlConnection cnx = new(Cnx))
            {
                SqlCommand cmd = new(query, cnx);
                cmd = AddParam(cmd, "@id", user.Id);
                cnx.Open();

                list = Get(cmd);

            }

            return list;
        }
        public void Update(Role role)
        {
            SqlConnection cnx = new(Cnx);

            string query = repo.Update(table, champs, values).Build();
            SqlCommand cmd = new(query, cnx);

            cmd = Bind(cmd, role);

            cmd = AddParam(cmd, "@id", role.Id);

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

       

        private static SqlCommand AddParam(SqlCommand command, string champ, object value)
        {
            command.Parameters.AddWithValue(champ, value);
            return command;
        }

        private SqlCommand Bind(SqlCommand cmd, Role role)
        {
            cmd = AddParam(cmd, "@titre", role.Titre);

            return cmd;
        }
    }




}
