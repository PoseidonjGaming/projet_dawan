using SerieDLL_EF.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieDLL_EF.Service
{
    public class Service <TClass, TRepo> where TClass: class where TRepo : IRepo<TClass>
    {
        protected TRepo repo;

        public Service(TRepo repo)
        {
            this.repo=repo;
        }

        public List<TClass> GetAll()
        {
            return repo.GetAll();
        }

        public TClass GetById(int id)
        {
            return repo.GetById(id);
        }

        //public T Export(int id)
        //{
        //    return repo.Export(id);
        //}

        public void Add(TClass item)
        {
            repo.Add(item);
        }

        public void Update(TClass item)
        {
            repo.Update(item);
        }

        public void Delete(TClass item)
        {
            repo.Delete(item);
        }

    }
}
