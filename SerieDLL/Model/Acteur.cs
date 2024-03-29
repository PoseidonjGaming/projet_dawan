﻿using System.Runtime.Serialization;

namespace SerieDLL.Model
{
    [Serializable]
    [DataContract]
    public class Acteur
    {
        [DataMember]
        private int id;
        [DataMember]
        private string nom;
        [DataMember]
        private string prenom;

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }


        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Acteur()
        {
            id = 0;
            nom = string.Empty;
            prenom = string.Empty;
        }
        public Acteur(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }
    }
}
