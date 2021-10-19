using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using PracticalTest.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PractialTest.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly ApplicationDbContext _context;
        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            var res = _context.SaveChanges();
            return res;
        }

        public void AddRange(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange(entities);
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> expression, params Expression<Func<T, Object>>[] includes)
        {
            if (includes.Length > 0)
            {
                IQueryable<T> query = _context.Set<T>().Where(expression).Include(includes[0]);
                foreach (var include in includes.Skip(1))
                {
                    query = query.Include(include);
                }
                return query;
            }

            var queryAll = _context.Set<T>().Where(expression);

            return queryAll;            
        }
               

        public virtual IQueryable<T> GetAllAsync(params Expression<Func<T, Object>>[] includes)
        {
            if (includes.Length > 0)
            {
                IQueryable<T> query = _context.Set<T>().Include(includes[0]);
                foreach (var include in includes.Skip(1))
                {
                    query = query.Include(include);
                }
                return query;
            }

            var queryAll = _context.Set<T>();         
                
            return queryAll;
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }
    }
}
