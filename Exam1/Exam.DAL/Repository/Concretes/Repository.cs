using Exam.Core.Models;
using Exam.DAL.Contexts;
using Exam.DAL.Repository.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Exam.DAL.Repository.Concretes;

public class Repository<T> : IRepository<T> where T : BaseEntity, new()
{
    readonly AppDbContext _appDbContext;

    public Repository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public DbSet<T> Table =>_appDbContext.Set<T>();

    public async Task Createasync(T entity)
    {
        entity.CreatedAt = DateTime.UtcNow.AddHours(4);
        await Table.AddAsync(entity);
    }

    public void Delete(T entity)=>Table.Remove(entity);
   

    public async Task<T> GeByIdAsync(int id, params string[] includes)
    {
        IQueryable<T> query = Table;
        if (includes.Length > 0)
        {
            foreach (string include in includes)
            {
                query = query.Include(include);
            }
        }
        return await Table.SingleOrDefaultAsync(x=>x.Id== id);
    }

    public async Task<ICollection<T>> GetAllAsync(params string[] includes)
    {
        IQueryable<T> query = Table;
        if (includes.Length > 0)
        {
            foreach(string include in includes)
            {
                query = query.Include(include);
            }
        }
        return await Table.ToListAsync();
    }

    public async Task<int> SaveChangesAsync()=>await _appDbContext.SaveChangesAsync();


    public void Update(T entity)
    {
        entity.UpdatedAt = DateTime.UtcNow.AddHours(4);
        Table.Update(entity);
    }
}