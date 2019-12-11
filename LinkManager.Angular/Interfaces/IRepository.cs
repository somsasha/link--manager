using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace LinkManager.Angular.Interfaces
{
    public interface IRepository<T>
    {
        T Get(Expression<Func<T, bool>> firstOrDefaultExpression = null, params string[] includeProperties);

        IEnumerable<T> GetAll(Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
             Expression<Func<T, bool>> filter = null, params string[] includeProperties);

        IEnumerable<T> GetPageData(int page, int pageSize, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
             Expression<Func<T, bool>> filter = null, params string[] includeProperties);
        T Create(T obj);
        void CreateRange(IEnumerable<T> objCollection);
        bool Update(T obj);
        bool UpdateRange(IEnumerable<T> objCollection);
        bool Delete(string id);
        bool Delete(T obj);
        bool DeleteRange(IEnumerable<T> objCollection);
    }
}
