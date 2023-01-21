using SerieDLL_EF.BDD;
using SerieDLL_EF.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieDLL_EF.Repository
{
    public class BaseRepo<TClass> where TClass : class
    {
        protected BddprojetContext context;
        protected Func<TClass, bool> predicate;

        public BaseRepo()
        {
            context = new();
        }

        public void Add(TClass item)
        {
            context.Add(item);
            context.SaveChanges();
        }

        public void Update(TClass item)
        {
            context.Update(item);
            context.SaveChanges();
        }

        public void Delete(TClass item)
        {
            context.Remove(item);
            context.SaveChanges();
        }

    }
}
