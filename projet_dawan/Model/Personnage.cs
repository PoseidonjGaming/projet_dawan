namespace projet_dawan.Model
{
    public class Personnage
    {
		private int id;
		private string nom;
		private int acteur_id;
		private int serie_id;

		public int SerieId
		{
			get { return serie_id; }
			set { serie_id = value; }
		}


		public int ActeurId
		{
			get { return acteur_id; }
			set { acteur_id = value; }
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

		public Personnage()
		{

		}

	}
}