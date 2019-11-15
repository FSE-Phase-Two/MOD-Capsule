using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MOD.DATA.Repository
{
   public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext _Context;

        public Repository(DbContext Context)
        {
            _Context = Context;
        }


        public TEntity Get(long Id)
        {
            return _Context.Set<TEntity>().Find(Id);
        }
                     
        public IEnumerable<TEntity> GetAll()
        {
            return _Context.Set<TEntity>().ToList();
        }

        public IEnumerable<TEntity> Find(Func<TEntity, bool> Predicate)
        {
            // return _Context.Set<TEntity>().Where(Predicate).ToList();
            IQueryable<TEntity> query = _Context.Set<TEntity>();
            return query.Where(Predicate).ToList();

        }

        public IQueryable<TEntity> Search(System.Linq.Expressions.Expression<Func<TEntity, bool>> Predicate, params Expression<Func<TEntity, object>>[] includeExpressions)
        {
            IQueryable<TEntity> query = _Context.Set<TEntity>();
            foreach (var includeExpression in includeExpressions)
            {
                query = query.Include(includeExpression);
            }
            return query.Where(Predicate);
        }


       

        public IQueryable<TEntity> CreateQueryWithInclude(params Expression<Func<TEntity, object>>[] includeExpressions)
        {
            IQueryable<TEntity> query = _Context.Set<TEntity>();
            if (includeExpressions != null)
            {
                foreach (var includeExpression in includeExpressions)
                {
                    query = query.Include(includeExpression);
                }
            }

            return query;
        }
        public void Add(TEntity Entity)
        {
            _Context.Set<TEntity>().Add(Entity);
        }

        public void AddRange(IEnumerable<TEntity> Entity)
        {
            _Context.Set<TEntity>().AddRange(Entity);
        }

        public void Remove(TEntity Entity)
        {
           _Context.Entry(Entity).State = EntityState.Deleted;
        }

        public void RemoveRange(IEnumerable<TEntity> Entity)
        {
            _Context.Set<TEntity>().RemoveRange(Entity);
        }

        public void Update(TEntity Entity)
        {
            _Context.Entry(Entity).State = EntityState.Modified;

        }

        public void Detach(TEntity Entity)
        {
            //  _Context.Entry(Entity).de

            _Context.Entry(Entity).State = EntityState.Detached;

        }
    }
}
