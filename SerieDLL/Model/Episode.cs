using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SerieDLL.Model
{
    [Serializable]
    [DataContract]
    public class Episode
    {
        [DataMember]
        private int id;
        [DataMember]
        private Saison saison_id;
        [DataMember]
        private string nom;
        [DataMember]
        private string resume;
        [DataMember]
        private DateTime date_prem_diff;

        public DateTime DatePremDiff
        {
            get { return date_prem_diff; }
            set { date_prem_diff = value; }
        }


        public string Resume
        {
            get { return resume; }
            set { resume = value; }
        }


        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }


        public Saison SaisonId
        {
            get { return saison_id; }
            set { saison_id = value; }
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Episode()
        {
            saison_id = new Saison();
            resume = string.Empty;
            Id = 0;
            nom = string.Empty;
        }

    }
}
