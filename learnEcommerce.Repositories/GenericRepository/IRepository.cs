using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace learnEcommerce.Repositories.GenericRepository
{
    public interface IRepository<T> where T : class
    {
       Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int? id);
        Task<IEnumerable<T>> Get(Expression<Func<T,bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
