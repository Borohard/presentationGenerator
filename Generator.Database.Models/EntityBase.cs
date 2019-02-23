using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator.Database.Models
{
    /// <summary>
    /// Базовый класс для всех моделей
    /// </summary>
    /// <typeparam name="T">Тип данных для Id</typeparam>
    public class EntityBase<T>
    {
        public T Id { get; set; }
    }
}
