using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator.Database.Models.IAuditEntity
{
    public interface IAuditChangingEntity
    {
        /// <summary>
        /// Время последнего изменения записи в БД
        /// </summary>
        DateTime LastChangeTime { get; set; }
    }
}
