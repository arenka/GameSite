using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using GameSite.Data.Entity;

namespace GameSite.Data.Repositories.Impl
{
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : class
    {
        public readonly DbContext Context;
        private readonly DbSet<TEntity> _entities;

  
        public Repository()
        {
            Context = new GameDbEntities();
            _entities = Context.Set<TEntity>();
        }
     

 

        private async Task<int> SaveChangesAsync()
        {
            return await Context.SaveChangesAsync();
        }

        private int SaveChanges()
        {
            return Context.SaveChanges();
        }
      

           
        public TEntity Insert(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _entities.Add(entity);
            SaveChanges();
            return entity;
        }

        public TEntity Update(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _entities.Attach(entity);
            Context.Entry(entity).State = EntityState.Modified;
            SaveChanges();

            return entity;
        }

        public TEntity Delete(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _entities.Attach(entity);
            Context.Entry(entity).State = EntityState.Deleted;
            SaveChanges();
            return entity;
        }

        public IEnumerable<TEntity> GetAll() =>
            _entities.AsNoTracking().AsEnumerable();

        public IQueryable<TEntity> QueryAble()
        {
            return _entities.AsQueryable();
        }

        public IQueryable<TEntity> QueryAble(Func<TEntity, bool> predicate)
        {
            return _entities.Where(predicate).AsQueryable();
        }

        public TEntity GetBy(Func<TEntity, bool> predicate)
        {
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));

            var result = _entities.FirstOrDefault(predicate);
            return result;
        }

        public IList<TEntity> GetAllBy(Func<TEntity, bool> predicate)
        {
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));

            return _entities.Where(predicate).ToList();
        }

        public IQueryable<TEntity> GetAllByQ(Func<TEntity, bool> predicate)
        {
            return _entities.Where(predicate).AsQueryable();
        }


        public bool Exists(Expression<Func<TEntity, bool>> predicate)
        {
            return _entities.AsQueryable().Any(predicate);
        }

        
    }

}