namespace SerieDLL.Model
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
            Titre = titre;
        }

    }
}
