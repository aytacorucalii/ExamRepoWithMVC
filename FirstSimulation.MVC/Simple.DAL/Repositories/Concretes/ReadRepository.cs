using Microsoft.EntityFrameworkCore;
using Simple.Core.Models.Base;
using Simple.DAL.Contexts;
using Simple.DAL.Repositories.Abstractions;

namespace Simple.DAL.Repositories.Concretes;

public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity, new()
{
    private readonly AppDbContext _appDbContext;

    public ReadRepository(AppDbContext appDbContext)
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
        var entity = await Table.FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);
        _appDbContext.Entry(entity).State = EntityState.Detached;
        return entity;

    }

    public async Task<bool> IsExistsAsync(int id)
    {
       return await Table.AnyAsync(x => x.Id == id && !x.IsDeleted);
    }
}
