using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MOD.DATA.Repository
{
   public interface IRepository<TEntity> where TEntity : class
    {
        
        IEnumerable<TEntity> GetAll();
        TEntity Get(Int64 Id);
        IEnumerable<TEntity> Find(Func<TEntity, bool> Predicate);
        IQueryable<TEntity> Search(System.Linq.Expressions.Expression<Func<TEntity, bool>> Predicate, params Expression<Func<TEntity, object>>[] includeExpressions);
        IQueryable<TEntity> CreateQueryWithInclude(params Expression<Func<TEntity, object>>[] includeExpressions);
        void Add(TEntity Entity);
        void AddRange(IEnumerable<TEntity> Entity);
        void Update(TEntity Entity);
        void Remove(TEntity Entity);
        void RemoveRange(IEnumerable<TEntity> Entity);

        void Detach(TEntity Entity);
    }
}
