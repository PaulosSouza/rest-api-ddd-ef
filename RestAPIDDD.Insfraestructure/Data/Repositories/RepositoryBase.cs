using Microsoft.EntityFrameworkCore;
using RestAPIDDD.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestAPIDDD.Infrastructure
{
    public class RepositoryBase<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly SqlContext _sqlContext;

        public RepositoryBase(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
        }

        public void Add(TEntity entity)
        {
            _sqlContext.Add(entity);
            _sqlContext.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _sqlContext.Set<TEntity>().ToList();
        }

        public TEntity GetById(Guid id)
        {
            return _sqlContext.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity entity)
        {
            _sqlContext.Set<TEntity>().Remove(entity);
            _sqlContext.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _sqlContext.Entry(entity).State = EntityState.Modified;
            _sqlContext.SaveChanges();
        }
    }
}