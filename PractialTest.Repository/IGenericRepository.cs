using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PractialTest.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        T GetById(int id);
        IQueryable<T> GetAllAsync(params Expression<Func<T, Object>>[] includes);
        IQueryable<T> Find(Expression<Func<T, bool>> expression, params Expression<Func<T, Object>>[] includes);
        Task<int> AddAsync(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
