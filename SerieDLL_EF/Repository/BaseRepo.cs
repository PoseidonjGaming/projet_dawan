using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SerieDLL_EF.Repository
{
    public class BaseRepo<TClass> where TClass : class
    {
        protected DbSet<TClass> DbSet;
        protected BddprojetContext Context;

        public BaseRepo()
        {
            Context= new BddprojetContext();
        }

        public void Add(TClass item)
        {
            DbSet.Add(item);
            Context.SaveChanges();
        }

        public void Update(TClass item)
        {
            DbSet.Update(item);
            Context.SaveChanges();
        }

        public void Delete(TClass item)
        {
            DbSet.Remove(item);
            Context.SaveChanges();
        }

        public List<TClass> GetAll()
        {
            return DbSet.ToList();
        }

        protected TClass GetById(Expression<Func<TClass, bool>> predicate)
        {
            return DbSet.Where(predicate).ToList()[0];
        }

        protected List<TClass> GetByTxt(Expression<Func<TClass, bool>> predicate)
        {
            return DbSet.Where(predicate).ToList();
        }

        protected bool CompareTo(Expression<Func<TClass, bool>> predicate)
        {
            TClass? acteur = DbSet.Where(predicate).FirstOrDefault();
            return acteur != null;
        }

        public TClass? GetCompareTo(Expression<Func<TClass, bool>> predicate)
        {
            return DbSet.Where(predicate).FirstOrDefault();
        }

    }
}
