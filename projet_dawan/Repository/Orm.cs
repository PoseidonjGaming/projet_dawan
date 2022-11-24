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
        public abstract Orm From();
        

        //retourne la query
        public string Build()
        {
            query += ";";
            return query;
        }

        public  Orm WhereById(string champ)
        {
            Query += " Where " + champ + "=@id";
            return this;
        }

        public  Orm WhereByDate(string champ)
        {
            Query += " Where " + champ + "=@date";
            return this;
        }


        public  Orm WhereByLike(string champ)
        {
            Query += " Where " + champ + " Like @text";
            return this;
        }

        public Orm And()
        {
            query+= " And";
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

    }
}
