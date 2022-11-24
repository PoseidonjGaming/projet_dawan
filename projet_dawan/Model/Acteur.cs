using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_dawan.Model
{
    public class Acteur
    {
		private int id;
		private string nom;
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

		public Acteur() { }
    }
}
