using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace projet_dawan.Model
{
    public class Acteur
    {
        public int Id { get; set; }

        [Required]
        public string Nom { get; set; }
        [Required]
        public string Prenom { get; set; }

        public Acteur(int id, string nom, string prenom)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
        }
    }
}
