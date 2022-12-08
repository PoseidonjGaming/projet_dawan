using SerieDLL_EF.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieDLL_EF.Service
{
    public class Service <T> where T: class 
    {
        protected IRepo<T> repo;

        public Service(IRepo<T> repo)
        {
            this.repo = repo;
        }

        public List<T> GetAll()
        {
            return repo.GetAll();
        }

        public T GetById(int id)
        {
            return repo.GetById(id);
        }

        //public T Export(int id)
        //{
        //    return repo.Export(id);
        //}

        public void Add(T item)
        {
            repo.Add(item);
        }

        public void Update(T item)
        {
            repo.Update(item);
        }

        public void Delete(T item)
        {
            repo.Delete(item);
        }

    }
}
