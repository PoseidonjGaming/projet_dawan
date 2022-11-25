using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_dawan.Model
{
    public class Saison
    {
        private int id;
        private Int16 num;
        private int nb_episode;
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


        public Int16 Num
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
