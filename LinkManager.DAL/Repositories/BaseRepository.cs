using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using LinkManager.DAL.Context;
using LinkManager.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LinkManager.DAL.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbSet;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public virtual T Get(Expression<Func<T, bool>> firstOrDefaultExpression = null, params string[] includeProperties)
        {
            IQueryable<T> query = _dbSet;

            foreach (var property in includeProperties)
            {
                query = query.Include(property);
            }

            return query.FirstOrDefault(firstOrDefaultExpression);
        }

        public virtual IEnumerable<T> GetAll(Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,  Expression<Func<T, bool>> filter = null, params string[] includeProperties)
        {
            IQueryable<T> query = _dbSet;

            foreach (var property in includeProperties)
            {
                query = query.Include(property);
            }

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }

            return query.ToList();
        }

        public virtual IEnumerable<T> GetPageData(int page, int pageSize,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,  Expression<Func<T, bool>> filter = null, params string[] includeProperties)
        {
            IQueryable<T> query = _dbSet;

            foreach (var property in includeProperties)
            {
                query = query.Include(property);
            }

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (orderBy != null)
            {
                query = orderBy(query);
            }

            return query.Skip(page * pageSize).Take(pageSize > 0 ? pageSize : 1).ToList();
        }

        public virtual T Create(T obj)
        {
            return _dbSet.Add(obj).Entity;
        }

        public virtual void CreateRange(IEnumerable<T> objCollection)
        {
            _dbSet.AddRange(objCollection);
        }

        public virtual bool Update(T obj)
        {
            _dbSet.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
            return true;
        }

        public virtual bool UpdateRange(IEnumerable<T> objCollection)
        {
            _dbSet.UpdateRange(objCollection);
            return true;
        }

        public virtual bool Delete(string id)
        {
            T entityToDelete = _dbSet.Find(id);
            return Delete(entityToDelete);
        }

        public virtual bool Delete(T obj)
        {
            if (_context.Entry(obj).State == EntityState.Detached)
            {
                _dbSet.Attach(obj);
            }
            return _dbSet.Remove(obj) != null;
        }

        public virtual bool DeleteRange(IEnumerable<T> objCollection)
        {
            _dbSet.RemoveRange(objCollection);
            return true;
        }
    }
}
