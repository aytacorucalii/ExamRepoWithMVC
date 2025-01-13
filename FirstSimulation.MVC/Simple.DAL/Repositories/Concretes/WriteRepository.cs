using Microsoft.EntityFrameworkCore;
using Simple.Core.Models.Base;
using Simple.DAL.Contexts;
using Simple.DAL.Repositories.Abstractions;

namespace Simple.DAL.Repositories.Concretes;

public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity, new()
{
    private readonly AppDbContext _appDbContext;

    public WriteRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public DbSet<T> Table => _appDbContext.Set<T>();

    public async Task<T> CreateAsync(T entity)
    {
       
        await Table.AddAsync(entity);
        return entity;

    }

    public void Update(T entity)
    {
        _appDbContext.Entry(entity).State = EntityState.Modified;
    }

    public void SoftDelete(T entity)
    {
        entity.IsDeleted = true;
    }
    public async Task<int> SaveChangesAsync()
    {
       return await _appDbContext.SaveChangesAsync();

    }

}