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
    public class PersonnageDAO : IPersonnageDAO
    {
        private string cnx=string.Empty;
        private PersonnageRepository repo = new();
        private string table;
        private List<string> champs= new List<string>() { "nom","serie_id", "acteur_id" };
        private List<string> values= new List<string>() { "@nom", "@serie_id", "@acteur_id" };

        public string Cnx
        {
            get { return cnx; }
            set { cnx = value; }
        }

        public PersonnageDAO(string cnx)
        {
            Cnx = cnx;
            table = "personnage";
        }
        public void Add(Personnage perso)
        {
            SqlConnection cnx = new(Cnx);

            string sql = repo.Insert(table, champs.ToArray())
                .Values(values.ToArray()).Build();
            SqlCommand cmd = new(sql, cnx);


            cmd = AddParam(cmd, "@nom", perso.Nom);
            cmd = AddParam(cmd, "@serie_id", perso.SerieId.Id);
            cmd = AddParam(cmd, "@acteur_id", perso.ActeurId.Id);


            Execute(sql, cnx, cmd);
            //MessageBox.Show(sql);
        }

        public void Delete(int id)
        {
            string query = repo.Delete(table).Build();

            using (SqlConnection cnx = new(Cnx))
            {
                SqlCommand cmd = new(query, cnx);
                cmd.Parameters.AddWithValue("@id", id);
                //Execute(query, cnx, cmd);
            }

        }

        public List<Personnage> GetAll()
        {
            List<Personnage> list = new List<Personnage>();
            string query = repo.Select("*").From(table).Build();
            using (SqlConnection cnx = new(Cnx))
            {
                SqlCommand cmd = new(query, cnx);
                cnx.Open();

                list = Get(cmd);

            }
            return list;
        }

        public Personnage GetById(int id)
        {
            List<Personnage> list = new List<Personnage>();
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
        public void Update(Personnage perso)
        {
            SqlConnection cnx = new(Cnx);

            string query = repo.Update(table, champs, values).Build();
            SqlCommand cmd = new(query, cnx);

            cmd = Bind(cmd, perso);
            
            cmd = AddParam(cmd, "@id", perso.Id);

            Execute(query, cnx, cmd);

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

        private static List<Personnage> Get(SqlCommand cmd)
        {
            List<Personnage> list = new List<Personnage>();
            SerieDAO repoSerie = new(Properties.Settings.Default.Connection);
            ActeurDAO repoActeur = new(Properties.Settings.Default.Connection);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Personnage perso = new()
                    {
                        Id = reader.GetInt32(0),
                        Nom = reader.GetString(3),
                        SerieId = repoSerie.GetById(reader.GetInt32(2)),
                        ActeurId= repoActeur.GetById(reader.GetInt32(1))

                    };

                    list.Add(perso);
                }
            }
            return list;
        }

        private static SqlCommand AddParam(SqlCommand command, string champ, object value)
        {
            command.Parameters.AddWithValue(champ, value);
            return command;
        }

        private SqlCommand Bind(SqlCommand cmd, Personnage perso)
        {
            cmd = AddParam(cmd, "@nom", perso.Nom);
            cmd = AddParam(cmd, "@serie_id", perso.SerieId.Id);
            cmd = AddParam(cmd, "@acteur_id", perso.ActeurId.Id);

            return cmd;
        }
    }




}
