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

        public string Cnx
        {
            get { return cnx; }
            set { cnx = value; }
        }

        public SerieDAO(string cnx)
        {
            Cnx = cnx;
        }
        public void Add(Serie serie)
        {
            throw new NotImplementedException();
        }

        public void Delete(Serie serie)
        {
            throw new NotImplementedException();
        }

        public List<Serie> GetAll()
        {
            List<Serie> list = new List<Serie>();
            string query = repo.Select("*").From().Build();
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
            throw new NotImplementedException();
        }

        public void Update(Serie serie)
        {
            throw new NotImplementedException();
        }

        public void Execute()
        {

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
                        Affiche=reader.GetString(4),
                        UrlBa=reader.GetString(5)

                    };

                    list.Add(serie);
                }
            }
            return list;
        }
    }
}
