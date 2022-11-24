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
    public class SaisonDAO 
    {
        private string cnx = string.Empty;
        private ActeurRepository repo = new();
        private string table;
        private List<string> champs = new List<string>() { "serie_id", "numero", "nb_episode" };
        private List<string> values = new List<string>() { "@serie_id", "@numero", "@nb_episode" };

        public string Cnx
        {
            get { return cnx; }
            set { cnx = value; }
        }

        public SaisonDAO(string cnx)
        {
            Cnx = cnx;
            table = "episode";
        }
        public void Add(Saison saison)
        {
            SqlConnection cnx = new(Cnx);

            string sql = repo.Insert(table, champs.ToArray())
                .Values(values.ToArray()).Build();
            SqlCommand cmd = new(sql, cnx);


            cmd = Bind(cmd, saison);


            //Execute(sql, cnx, cmd);
            MessageBox.Show(sql);
        }

        public void Delete(int id)
        {
            string query = repo.Delete(table).Build();

            using (SqlConnection cnx = new(Cnx))
            {
                SqlCommand cmd = new(query, cnx);
                cmd.Parameters.AddWithValue("@id", id);
                //Execute(query, cnx, cmd);
                MessageBox.Show(query);
            }

        }

        public List<Saison> GetAll()
        {
            List<Saison> list = new List<Saison>();
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

        public Saison GetById(int id)
        {
            List<Saison> list = new List<Saison>();
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
        public void Update(Saison saison)
        {
            SqlConnection cnx = new(Cnx);

            string query = repo.Update(table, champs, values).Build();
            SqlCommand cmd = new(query, cnx);

            cmd = Bind(cmd, saison);

            cmd = AddParam(cmd, "@id", saison.Id);

            //Execute(query, cnx, cmd);
            MessageBox.Show(query);
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

        private static List<Saison> Get(SqlCommand cmd)
        {
            List<Saison> list = new List<Saison>();
            SaisonDAO repoSaison = new(Properties.Settings.Default.Connection);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Saison saison = new()
                    {
                        Id = reader.GetInt32(0),

                    };

                    list.Add(saison);
                }
            }
            return list;
        }

        private static SqlCommand AddParam(SqlCommand command, string champ, object value)
        {
            command.Parameters.AddWithValue(champ, value);
            return command;
        }

        private SqlCommand Bind(SqlCommand cmd, Saison saison)
        {
            cmd = AddParam(cmd, "@serie_id", saison.SerieId.Id);
            cmd = AddParam(cmd, "@num", saison.Num);
            cmd = AddParam(cmd, "@nb_episode", saison.Num);

            return cmd;
        }
    }




}
