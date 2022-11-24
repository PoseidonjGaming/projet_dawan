using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_dawan
{
    public class Orm
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

        public Orm From(string table)
        {
            query += " From " + table;
            return this;
        }
        public Orm Where(string champ, int value)
        {

            return this;
        }
        public string Build()
        {
            query += ";";
            return query;
        }


    }
}
