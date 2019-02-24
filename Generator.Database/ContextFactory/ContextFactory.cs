using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generator.Database.Models;

namespace Generator.Database
{
    public class ContextFactory : IContextFactory
    {
        public Context<TEntity, T> GetDbContext<TEntity, T>()
            where TEntity : EntityBase<T>
        {
            return new Context<TEntity, T>();
        }
    }
}
