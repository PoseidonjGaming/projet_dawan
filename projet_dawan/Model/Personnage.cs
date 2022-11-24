namespace projet_dawan.Model
{
    public class Personnage
    {
		private int id;
		private string nom;
		private Acteur acteur_id;
		private Serie serie_id;

		public Serie SerieId
		{
			get { return serie_id; }
			set { serie_id = value; }
		}


		public Acteur ActeurId
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
			serie_id= new Serie();
			acteur_id= new Acteur();
		}

	}
}