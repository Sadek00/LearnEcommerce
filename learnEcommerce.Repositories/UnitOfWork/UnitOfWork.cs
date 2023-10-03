using learnEcommerce.DataAccess.Data;
using learnEcommerce.Models;
using learnEcommerce.Repositories.GenericRepository;
using learnEcommerce.Repositories.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnEcommerce.Repositories.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public ICategoryRepository _categoryRepository { get; private set; }
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            _categoryRepository = new CategoryRepository(_context);
        }

 

        public async Task<int> SaveAsync()
        {
          return await _context.SaveChangesAsync();
        }
        /* public IRepository<Category> GetCategories()
{
    var categoryRepository = new Repository<Category>(_context);
    return categoryRepository;
}*/

    }
}
