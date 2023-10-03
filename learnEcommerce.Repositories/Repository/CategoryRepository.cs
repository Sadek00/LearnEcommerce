using learnEcommerce.DataAccess.Data;
using learnEcommerce.Models;
using learnEcommerce.Repositories.GenericRepository;

namespace learnEcommerce.Repositories.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
