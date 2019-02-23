using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generator.Database.Models;
using System.Data.Entity;

namespace Generator.Database
{
    interface IContext<TEntity,T>
        where TEntity:EntityBase<T>
    {
        DbSet<TEntity> Entities { get; set; }
    }
}
