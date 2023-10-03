using learnEcommerce.DataAccess.Data;
using learnEcommerce.Models;
using learnEcommerce.Repositories.GenericRepository;
using learnEcommerce.Repositories.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnEcommerce.Repositories.UnitOfWork
{
    public interface IUnitOfWork
    {
        //public IRepository<Category> GetCategories();
        ICategoryRepository _categoryRepository { get; }
        Task<int> SaveAsync();
    }
}
