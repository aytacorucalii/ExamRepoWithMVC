using Microsoft.EntityFrameworkCore;
using Pr.Core.Models.Base;
using Pr.DAL.Contexts;
using Pr.DAL.Repositories.Abstractions;

namespace Pr.DAL.Repositories.Concretes
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
           return await Table.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<T> CreateAsync(T entity)
        {
            await Table.AddAsync(entity);
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
             Table.Remove(entity);
        }


        public async Task<int> SaveChangesAsync()
        {
           return await _appDbContext.SaveChangesAsync();

        }

        public Task Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
