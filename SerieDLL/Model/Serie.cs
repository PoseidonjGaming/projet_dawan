using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace projet_dawan.Model
{
    [Serializable]
    [DataContract]
    public class Serie
    {
        [DataMember]
        private int id;
        [DataMember]
        private string name;
        [DataMember]
        private string resume;
        [DataMember]
        private string affiche;
        [DataMember]
        private DateTime date_diff;
        [DataMember]
        private string url_ba;
        [DataMember]
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

        public Serie(string name, string resume, string affiche, DateTime date_diff, string url_ba, List<Personnage> personnages, string urlBa)
        {
            Personnages = personnages;
            UrlBa = urlBa;
            DateDiff = date_diff;
            Affiche = affiche;
            Resume = resume;
            Name = name;
        }
    }
}
