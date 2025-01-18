using Microsoft.EntityFrameworkCore;
using S.Core.Models;
using S.DAL.Contexts;
using S.DAL.Repositories.Abstractions;

namespace S.DAL.Repositories.Concretes
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
           return await Table.FirstOrDefaultAsync(x=> x.Id == id && !x.IsDeleted);
        }

        public async Task<T> CreateAsync(T entity)
        {
            await Table.AddAsync(entity);
            return entity;
        }

        public  Task Delete(T entity)
        {
             Table.Remove(entity);
             return Task.CompletedTask;
        }


        public async Task<int> SaveChangesAsync()
        {
           return await _appDbContext.SaveChangesAsync();
           
            
        }

        public async Task Update(T entity)
        {
             Table.Update(entity);
        }
    }


}
