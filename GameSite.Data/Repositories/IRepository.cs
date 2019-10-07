using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace GameSite.Data.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
    

        TEntity Insert(TEntity entity);
        TEntity Update(TEntity entity);
        TEntity Delete(TEntity entity);

        IEnumerable<TEntity> GetAll();
        IQueryable<TEntity> QueryAble();
        IQueryable<TEntity> QueryAble(Func<TEntity, bool> predicate);
        TEntity GetBy(Func<TEntity, bool> predicate);
        IList<TEntity> GetAllBy(Func<TEntity, bool> predicate);
        IQueryable<TEntity> GetAllByQ(Func<TEntity, bool> predicate);

        bool Exists(Expression<Func<TEntity, bool>> predicate);
        
    }
}