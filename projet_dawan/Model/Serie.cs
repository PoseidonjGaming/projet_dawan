using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_dawan.Model
{
    public class Serie
    {
        private int id;
        private string name;
        private string resume;
        private string affiche;
        private DateTime date_diff;
        private string url_ba;
        private List<Personnage> personnages;

        public List<Personnage> Personnages
        {
            get { return personnages; }
            set { personnages = value; }
        }


        public string UrlBa
        {
            get { return url_ba; }
            set { url_ba = value; }
        }


        public DateTime DateDiff
        {
            get { return date_diff; }
            set { date_diff = value; }
        }


        public string Affiche
        {
            get { return affiche; }
            set { affiche = value; }
        }


        public string Resume
        {
            get { return resume; }
            set { resume = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Serie(int id, string nom, string resume,
            string affiche, DateTime date_diff, string url_ba,
            List<Personnage> personnages)
        {
            this.id = id;
            Name = nom;
            Resume = resume;
            Affiche = affiche;
            DateDiff = date_diff;
            UrlBa = url_ba;
            Personnages = personnages;
        }

        public Serie()
        {
        }
    }
}
