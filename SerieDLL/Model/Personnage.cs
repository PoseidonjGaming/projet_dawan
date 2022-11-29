using System.Runtime.Serialization;

namespace projet_dawan.Model
{
	[Serializable]
	[DataContract]
    public class Personnage
    {
		[DataMember]
		private int id;
		[DataMember]
		private string nom;
		[DataMember]
		private Acteur acteur_id;
		[DataMember]
		private Serie? serie_id;

		public Serie? SerieId
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

		public Personnage(string nom, Acteur acteur, Serie serie)
		{
			Nom = nom;
			ActeurId= acteur;
			SerieId= serie;
		}
	}
}