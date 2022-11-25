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
    public class ActeurDAO : IActeurDAO
    {
        private string cnx = string.Empty;
        private ActeurRepository repo = new();
        private string table;
        private List<string> champs = new List<string>() { "nom", "prenom" };
        private List<string> values = new List<string>() { "@nom", "@prenom" };

        public string Cnx
        {
            get { return cnx; }
            set { cnx = value; }
        }

        public ActeurDAO(string cnx)
        {
            Cnx = cnx;
            table = "acteur";
        }
        public void Add(Acteur acteur)
        {
            SqlConnection cnx = new(Cnx);

            string sql = repo.Insert(table, champs.ToArray())
                .Values(values.ToArray()).Build();
            SqlCommand cmd = new(sql, cnx);


            cmd = Bind(cmd, acteur);


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

        public List<Acteur> GetAll()
        {
            List<Acteur> list = new List<Acteur>();
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

        public Acteur GetById(int id)
        {
            List<Acteur> list = new List<Acteur>();
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
        public void Update(Acteur acteur)
        {
            SqlConnection cnx = new(Cnx);

            string query = repo.Update(table, champs, values).Build();
            SqlCommand cmd = new(query, cnx);

            cmd = Bind(cmd, acteur);

            cmd = AddParam(cmd, "@id", acteur.Id);

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

        private static SqlCommand AddParam(SqlCommand command, string champ, object value)
        {
            command.Parameters.AddWithValue(champ, value);
            return command;
        }

        private SqlCommand Bind(SqlCommand cmd, Acteur acteur)
        {
            cmd = AddParam(cmd, "@nom", acteur.Nom);
            cmd = AddParam(cmd, "@prenom", acteur.Prenom);

            return cmd;
        }
    }




}
