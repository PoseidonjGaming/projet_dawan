using projet_dawan.Interface;
using projet_dawan.Model;
using projet_dawan.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_dawan.DAO
{
    public class SerieDAO : ISerieDAO
    {
        private string cnx;
        private SerieRepository repo = new();
        private string table;
        private List<string> champs= new List<string>() { "nom","resume","affiche","url_ba", "date_diff"};
        private List<string> values= new List<string>() { "@nom","@resume","@affiche","@url_ba", "@date_diff" };

        public string Cnx
        {
            get { return cnx; }
            set { cnx = value; }
        }

        public SerieDAO(string cnx)
        {
            Cnx = cnx;
            table = "serie";
        }
        public void Add(Serie serie)
        {
            SqlConnection cnx = new(Cnx);

            string sql = repo.Insert(table,champs.ToArray())
                .Values(values.ToArray()).Build();
            SqlCommand cmd = new(sql, cnx);


            cmd = AddParam(cmd, "@nom", serie.Name);
            cmd = AddParam(cmd, "@date_diff", serie.DateDiff);
            cmd = AddParam(cmd, "@url_ba", serie.UrlBa);
            cmd = AddParam(cmd, "@resume", serie.Resume);
            cmd = AddParam(cmd, "@affiche", serie.Affiche);

            Execute(sql, cnx, cmd);

        }

        public void Delete(int id)
        {
            string query = repo.Delete(table).Build();

            using (SqlConnection cnx = new(Cnx))
            {
                SqlCommand cmd = new(query, cnx);
                cmd.Parameters.AddWithValue("@id", id);
                Execute(query, cnx, cmd);
            }

        }

        public List<Serie> GetAll()
        {
            List<Serie> list = new List<Serie>();
            string query = repo.Select("*").From(table).Build();
            using (SqlConnection cnx = new(Cnx))
            {
                SqlCommand cmd = new(query, cnx);
                cnx.Open();

                list = Get(cmd);

            }
            return list;
        }

        public Serie GetById(int id)
        {
            List<Serie> list = new List<Serie>();
            string query = repo.Select("*").From(table).WhereById("id").Build();
            using (SqlConnection cnx = new(Cnx))
            {
                SqlCommand cmd = new(query, cnx);
                cmd = AddParam(cmd, "@id", id);
                cnx.Open();

                list = Get(cmd);

            }

            return list[0];
        }
        public void Update(Serie serie)
        {
            SqlConnection cnx = new(Cnx);

            string query = repo.Update(table, champs, values).Build();
            SqlCommand cmd = new(query, cnx);

            
            cmd = AddParam(cmd, "@id", serie.Id);

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

        private static List<Serie> Get(SqlCommand cmd)
        {
            List<Serie> list = new List<Serie>();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Serie serie = new()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        DateDiff = reader.GetDateTime(2),
                        Resume = reader.GetString(3),
                        Affiche = reader.GetString(4),
                        UrlBa = reader.GetString(5)

                    };

                    list.Add(serie);
                }
            }
            return list;
        }

        private static SqlCommand AddParam(SqlCommand command, string champ, object value)
        {
            command.Parameters.AddWithValue(champ, value);
            return command;
        }

        private SqlCommand Bind(SqlCommand cmd, Serie serie)
        {
            cmd = AddParam(cmd, "@nom", serie.Name);
            cmd = AddParam(cmd, "@date_diff", serie.DateDiff);
            cmd = AddParam(cmd, "@url_ba", serie.UrlBa);
            cmd = AddParam(cmd, "@resume", serie.Resume);
            cmd = AddParam(cmd, "@affiche", serie.Affiche);

            return cmd;
        }
    }




}
