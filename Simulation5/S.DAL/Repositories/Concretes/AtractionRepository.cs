using S.Core.Models;
using S.DAL.Contexts;
using S.DAL.Repositories.Abstractions;

namespace S.DAL.Repositories.Concretes
{
    public class AtractionRepository : GenericRepository<Atraction>, IAtractionRepository
    {
        public AtractionRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }


}
