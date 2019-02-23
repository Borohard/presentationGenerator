using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Generator.Database.Models;

namespace Generator.Database
{
    public class CrudRepository<TEntity, T> : ICrudRepository<TEntity, T>
        where TEntity:EntityBase<T>
    {
        private IContextFactory<TEntity,T> _contextFactory;
        public CrudRepository(IContextFactory<TEntity,T> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public void Create(TEntity entity)
        {
            using(var db = _contextFactory.GetDbContext())
            {
                db.Entities.Add(entity);
                db.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (var db = _contextFactory.GetDbContext())
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
