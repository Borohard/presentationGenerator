using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Generator.Database.Models;

namespace Generator.Database
{
    public interface IContextFactory<TEntity,T>
        where TEntity:EntityBase<T>
    {
        Context<TEntity,T> GetDbContext();
    }
}
