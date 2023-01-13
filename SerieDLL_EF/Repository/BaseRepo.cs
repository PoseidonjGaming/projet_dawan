using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SerieDLL_EF.Repository
{
    internal class BaseRepo<TClass> where TClass : class
    {
        public DbSet<TClass> DbSet;
        public BddprojetContext Context;

        public BaseRepo()
        {
            Context= new BddprojetContext();
        }

        internal void Add(TClass item)
        {
            DbSet.Add(item);
            Context.SaveChanges();
        }

        internal void Update(TClass item)
        {
            DbSet.Update(item);
            Context.SaveChanges();
        }

        internal void Delete(TClass item)
        {
            DbSet.Remove(item);
            Context.SaveChanges();
        }

        internal List<TClass> GetAll()
        {
            return DbSet.ToList();
        }

        internal TClass GetById(Expression<Func<TClass, bool>> predicate)
        {
            return DbSet.Where(predicate).ToList()[0];
        }

        internal List<TClass> GetByTxt(Expression<Func<TClass, bool>> predicate)
        {
            return DbSet.Where(predicate).ToList();
        }

        internal bool CompareTo(Expression<Func<TClass, bool>> predicate)
        {
            TClass? acteur = DbSet.Where(predicate).FirstOrDefault();
            return acteur != null;
        }

        internal TClass? GetCompareTo(Expression<Func<TClass, bool>> predicate)
        {
            return DbSet.Where(predicate).FirstOrDefault();
        }

        
    }
}
