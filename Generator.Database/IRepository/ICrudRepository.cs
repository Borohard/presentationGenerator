using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generator.Database.Models;
using System.Linq.Expressions;

namespace Generator.Database
{
    public interface ICrudRepository<TEntity,T>
        where TEntity:EntityBase<T>
    {
        /// <summary>
        /// Создаёт запись в БД
        /// </summary>
        /// <param name="entity"></param>
        void Create(TEntity entity);

        /// <summary>
        /// Выбирает из БД все записи, соответствующие
        /// условию
        /// </summary>
        /// <param name="condition">Условие</param>
        /// <returns></returns>
        IReadOnlyCollection<TEntity> Read(Expression<Func<TEntity, bool>> condition);

        /// <summary>
        /// Обновляет сущность в БД
        /// </summary>
        /// <param name="entity"></param>
        void Update(TEntity entity);

        /// <summary>
        /// Удалаяет сущность из БД
        /// </summary>
        /// <param name="entity"></param>
        void Delete(TEntity entity);
    }
}
