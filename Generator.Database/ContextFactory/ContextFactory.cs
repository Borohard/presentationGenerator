using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generator.Database.Models;

namespace Generator.Database
{
    public class ContextFactory<TEntity, T> : IContextFactory<TEntity, T>
        where TEntity : EntityBase<T>
    {
        public Context<TEntity,T> GetDbContext()
        {
            return new Context<TEntity, T>();
        }
    }
}
