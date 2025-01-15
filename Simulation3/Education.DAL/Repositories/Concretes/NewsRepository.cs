using Education.Core.Models;
using Education.DAL.Contexts;
using Education.DAL.Repositories.Abstractions;

namespace Education.DAL.Repositories.Concretes
{
    public class NewsRepository : GenericRepository<News>, INewsRepository
    {
        public NewsRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
