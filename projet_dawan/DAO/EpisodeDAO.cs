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
    public class EpisodeDAO : IEpisodeDAO
    {
        private string cnx = string.Empty;
        private ActeurRepository repo = new();
        private string table;
        private List<string> champs = new List<string>() { "saison_id", "nom", "resume", "date_prem_diff" };
        private List<string> values = new List<string>() { "@saison_id", "@nom","@resume", "@date_prem_diff" };

        public string Cnx
        {
            get { return cnx; }
            set { cnx = value; }
        }

        public EpisodeDAO(string cnx)
        {
            Cnx = cnx;
            table = "episode";
        }
        public void Add(Episode episode)
        {
            SqlConnection cnx = new(Cnx);

            string sql = repo.Insert(table, champs.ToArray())
                .Values(values.ToArray()).Build();
            SqlCommand cmd = new(sql, cnx);


            cmd = Bind(cmd, episode);


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

        public List<Episode> GetAll()
        {
            List<Episode> list = new List<Episode>();
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

        public Episode GetById(int id)
        {
            List<Episode> list = new List<Episode>();
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
        public void Update(Episode episode)
        {
            SqlConnection cnx = new(Cnx);

            string query = repo.Update(table, champs, values).Build();
            SqlCommand cmd = new(query, cnx);

            cmd = Bind(cmd, episode);

            cmd = AddParam(cmd, "@id", episode.Id);

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

        private static List<Episode> Get(SqlCommand cmd)
        {
            List<Episode> list = new List<Episode>();
            SaisonDAO repoSaison = new(Properties.Settings.Default.Connection);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Episode episode = new()
                    {
                        Id = reader.GetInt32(0),
                        Nom = reader.GetString(2),
                        SaisonId=repoSaison.GetById(reader.GetInt32(1)),
                        Resume=reader.GetString(3),
                        DatePremDiff=reader.GetDateTime(4)
                    };

                    list.Add(episode);
                }
            }
            return list;
        }

        private static SqlCommand AddParam(SqlCommand command, string champ, object value)
        {
            command.Parameters.AddWithValue(champ, value);
            return command;
        }

        private SqlCommand Bind(SqlCommand cmd, Episode episode)
        {
            cmd = AddParam(cmd, "@saison_id", episode.SaisonId.Id);
            cmd = AddParam(cmd, "@nom", episode.Nom);
            cmd = AddParam(cmd, "@date_prem_dif", episode.DatePremDiff);
            cmd = AddParam(cmd, "@resume", episode.Resume);

            return cmd;
        }
    }




}
