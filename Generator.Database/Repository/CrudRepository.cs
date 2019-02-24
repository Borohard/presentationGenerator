using Generator.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Generator.Database
{
    public abstract class CrudRepository<TEntity, T> : ICrudRepository<TEntity, T>
        where TEntity:EntityBase<T>
    {
        private readonly IContextFactory _contextFactory;
        protected CrudRepository(IContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public void Create(TEntity entity)
        {
            using(var db = _contextFactory.GetDbContext<TEntity,T>())
            {
                db.Entities.Add(entity);
                db.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (var db = _contextFactory.GetDbContext<TEntity,T>())
            {
                db.Entities.Remove(entity);
                db.SaveChanges();
            }
        }

        public IReadOnlyCollection<TEntity> Read(Expression<Func<TEntity, bool>> condition)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
