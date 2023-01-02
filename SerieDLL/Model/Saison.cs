using System.Runtime.Serialization;

namespace SerieDLL.Model
{
    [Serializable]
    [DataContract]
    public class Saison
    {
        [DataMember]
        private int id;
        [DataMember]
        private short num;
        [DataMember]
        private int nb_episode;
        [DataMember]
        private Serie serie_Id;

        public Serie SerieId
        {
            get { return serie_Id; }
            set { serie_Id = value; }
        }


        public int NbEpisode
        {
            get { return nb_episode; }
            set { nb_episode = value; }
        }


        public short Num
        {
            get { return num; }
            set { num = value; }
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Saison()
        {
            serie_Id = new Serie();
        }
        public Saison(short num_in, int nb_episode_in,
            Serie serie_Id_in
           )
        {

            Num = num_in;
            NbEpisode = nb_episode_in;
            SerieId = serie_Id_in;

        }
    }
}
