using SerieDLL_EF.Interface;

namespace SerieDLL_EF.Service
{
    /*Class Service Parent qui contient les méthodes classiques du CRUD:
     * -Create: Add
     * -Read: GetAll, GetById
     * -Update: update
     * -Delete: Delete* 
     */
    public abstract class Service<TClass, TRepo> where TClass : class where TRepo : IRepoCRUD<TClass>
    {

        /*TClass: Représente la classe Model qui est manipulée
         *TRepo: Représente la classe répository qui est appelé pour gérer la bdd
         */

        protected TRepo repo;

        public Service(TRepo repo)
        {
            this.repo = repo;
        }

        //Récupère la liste de tous objets de type TClass depuis la bdd
        public List<TClass> GetAll()
        {
            return repo.GetAll();
        }

        //Récupère l'objet de type TClass dont l'id correspond à l'id passé en paramètre

        public TClass GetById(int id)
        {
            return repo.GetById(id);
        }




        //Ajoute l'objet de type TClass dans la bdd
        public virtual void Add(TClass item)
        {
            repo.Add(item);
        }

        //Modifie l'objet de type TClass dans la bdd
        public virtual void Update(TClass item)
        {
            repo.Update(item);
        }

        //Supprime l'objet de type TClass dans la bdd
        public void Delete(TClass item)
        {
            repo.Delete(item);
        }

    }
}
