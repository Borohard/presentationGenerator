using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator.Database.Models
{
    public interface IAuditCreationEntity
    {
        /// <summary>
        /// Время помещения записи в БД
        /// </summary>
        DateTime CreationTime { get; set; }
    }
}
