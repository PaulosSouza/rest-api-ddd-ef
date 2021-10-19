using System;
using System.Collections.Generic;

namespace RestAPIDDD.Domain.Core
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        void Add(TEntity entity);

        void Update(TEntity entity);

        void Remove(TEntity entity);

        IEnumerable<TEntity> GetAll();

        TEntity GetById(Guid id);
    }
}