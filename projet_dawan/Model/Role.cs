using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_dawan.Model
{
    public class Role
    {
		private int id;
		private string titre;

		public string Titre
		{
			get { return titre; }
			set { titre = value; }
		}


		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		public Role() { }

		public Role(string titre)
		{
			Titre= titre;
		}

	}
}
