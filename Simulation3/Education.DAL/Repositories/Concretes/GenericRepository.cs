using Education.Core.Models.Base;
using Education.DAL.Contexts;
using Education.DAL.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Education.DAL.Repositories.Concretes
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity, new()
    {
        private readonly AppDbContext _appDbContext;

        public GenericRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public DbSet<T> Table => _appDbContext.Set<T>();
        public async Task<ICollection<T>> GetAllAsync()
        {
          return await Table.Where(x=>!x.IsDeleted).ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
           var entity = await Table.FirstOrDefaultAsync(x=>!x.IsDeleted && x.Id == id);
            _appDbContext.Entry(entity).State = EntityState.Detached;
            if (entity == null)
            {
                throw new Exception("something went wrong");
            }
            return entity;
        }

        public async Task<T> CreateAsync(T entity)
        {
            await Table.AddAsync(entity);
            return entity;
        }

        public void DeleteAsync(T entity)
        {
            Table.Remove(entity);
            entity.IsDeleted = true;
        }


        public async Task<bool> IsExists(int id)
        {
            return await Table.AnyAsync(x => x.Id == id && !x.IsDeleted);
        }

        public async Task<int> SaveChangesAsync()
        {
          return await _appDbContext.SaveChangesAsync();

        }

        public void Update(T entity)
        {
            _appDbContext.Entry(entity).State = EntityState.Modified;
        }
    }
}
