using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_dawan.Repository
{
    public abstract class Orm
    {
        private string query;

        public string Query
        {
            get { return query; }
            set { query = value; }
        }

        public Orm()
        {

        }

        //Ajoute à l'attibut query la liste de champs et renvoie l'objet 
        //appelant la méthode pour chainer les méthode
        public Orm Select(params string[] champs)
        {
            query = "Select ";

            foreach (string champ in champs)
            {
                if (champ == champs.LastOrDefault())
                {
                    query += champ;
                }
                else
                {
                    query += champ + ", ";
                }
            }

            return this;
        }

        //Ajoute form table à la query
        public Orm From(string table)
        {
            query += " From " + table;
            return this;
        }


        //retourne la query
        public string Build()
        {
            query += ";";
            return query;
        }

        public Orm WhereById(string champ)
        {
            Query += " Where " + champ + "=@id";
            return this;
        }

        public Orm WhereByDate(string champ)
        {
            Query += " Where " + champ + "=@date";
            return this;
        }


        public Orm WhereByLike(string champ)
        {
            Query += " Where " + champ + " Like @text";
            return this;
        }

        public Orm And()
        {
            query += " And";
            return this;
        }
        public Orm Or()
        {
            query += " Or";
            return this;
        }

        public Orm Join(string tableStart, string champStart, string tabletarget, string champTarget)
        {
            Query += $" Join {tableStart} On {tableStart}.{champStart}={tabletarget}.{champTarget}";
            return this;
        }

        public Orm OrderBy(string champ, string direction)
        {
            Query += " Order by " + champ + " " + direction;
            return this;
        }

        public Orm Insert(string table, params string[] values)
        {
            query = $"Insert into {table} (";
            foreach (string value in values)
            {
                if (value == values.Last())
                {
                    query += value + ") ";
                }
                else
                {
                    query += value + ", ";
                }
            }
            return this;
        }

        public Orm Values(params string[] values)
        {
            query += $"Values (";
            foreach (string value in values)
            {
                if (value == values.Last())
                {
                    query += value + ")";
                }
                else
                {
                    query += value + ", ";
                }
            }
            return this;
        }

        public Orm Delete(string table)
        {
            query = "Delete";
            From(table);
            WhereById("id").Build();
            MessageBox.Show(query);
            return this;
        }

        public Orm Update(string table, List<string> champs, List<string> values)
        {
            Query = "Update " + table + " Set ";
            foreach (string value in values)
            {
                int index = values.IndexOf(value);
                if (value == values.Last())
                {
                    query += value + "=" + champs[index];
                }
                else
                {
                    query += value + "=" + champs[index] + ",";
                }
            }
            return this;
        }

    }
}
