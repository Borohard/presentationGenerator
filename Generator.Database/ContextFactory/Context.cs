using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generator.Database.Models;
using System.Data.Entity;

namespace Generator.Database
{
    public partial class Context<TEntity, T> : DbContext, IContext<TEntity, T>
        where TEntity : EntityBase<T>
    {
        public Context() : base()
        {
        }

        public virtual DbSet<TEntity> Entities { get; set; }
    }
}
