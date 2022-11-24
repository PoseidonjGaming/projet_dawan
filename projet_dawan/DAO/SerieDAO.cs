using projet_dawan.Interface;
using projet_dawan.Model;
using projet_dawan.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_dawan.DAO
{
    public class SerieDAO : ISerieDAO
    {
        private string cnx;
        private SerieRepository repo = new();
        private string table;

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

            string sql = "INSERT INTO Serie(nom, prenom, email, telephone) VALUES (@nom, @prenom, @email, @telephone)";
           
        }

        public void Delete(Serie serie)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public void Execute(string query, SqlConnection cnx,Serie serie)
        {
            try
            {

                SqlCommand cmd = new(query, cnx);


                cmd = AddParam(cmd, "@nom",serie.Name);
                cmd = AddParam(cmd, "@dateDiff",serie.DateDiff);
                cmd = AddParam(cmd, "@urlBa",serie.UrlBa);
                cmd = AddParam(cmd, "@resume",serie.Resume);
                cmd = AddParam(cmd, "@affiche",serie.Affiche);

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

        private List<Serie> Get(SqlCommand cmd)
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

        private SqlCommand AddParam(SqlCommand command, string champ, object value)
        {
            command.Parameters.AddWithValue(champ, value);
            return command;
        }
    }




}
