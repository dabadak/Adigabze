using Adigabze.Data.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Adigabze.Data.Concrete.EFCore
{
    public class EFGenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly DbContext _ctx;

        public EFGenericRepository(DbContext ctx)
        {
            _ctx = ctx;
        }

        public void Add(T entity)
        {
            _ctx.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _ctx.Set<T>().Remove(entity);
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _ctx.Set<T>().Where(predicate);
        }

        public T Get(int id)
        {
            return _ctx.Set<T>().Find(id);
        }

        public IQueryable<T> GetAll()
        {
            return _ctx.Set<T>();
        }

        public void Save()
        {
            _ctx.SaveChanges();
        }

        public void Update(T entity)
        {
            _ctx.Entry(entity).State = EntityState.Modified;
        }
    }
}
