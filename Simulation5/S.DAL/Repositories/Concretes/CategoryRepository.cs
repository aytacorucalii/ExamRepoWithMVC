using S.Core.Models;
using S.DAL.Contexts;
using S.DAL.Repositories.Abstractions;

namespace S.DAL.Repositories.Concretes
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }


}
