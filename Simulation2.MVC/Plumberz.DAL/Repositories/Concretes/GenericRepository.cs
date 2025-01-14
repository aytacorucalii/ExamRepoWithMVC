using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Plumberz.Core.Models.Base;
using Plumberz.DAL.Contexts;
using Plumberz.DAL.Repositories.Abstractions;

namespace Plumberz.DAL.Repositories.Concretes;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity, new()
{
    private readonly AppDbContext _appDbContext;

    public GenericRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public DbSet<T> Table => _appDbContext.Set<T>();

    public async Task<T> CreateAsync(T entity)
    {
        await Table.AddAsync(entity);
        return entity;
    }

    public IQueryable<T> GetAll()
    {
        return Table.Where(X => !X.IsDeleted);
    }

    public async Task<T> GetByIdAsync(int id)
    {
        T? entity = await Table.FirstOrDefaultAsync(X => X.Id == id && !X.IsDeleted);
        if(entity is null)
        {
            throw new Exception("");
        }
        //_appDbContext.Entry(entity).State = EntityState.Unchanged;
        return entity;
    }

    public async Task<bool> IsExistsAsync(int id)
    {
        return await Table.AnyAsync(X => X.Id == id && !X.IsDeleted);
    }

    public async Task<int> SaveChangesAsync()
    {
        return await _appDbContext.SaveChangesAsync();
    }

    public void SoftDelete(T entity)
    {
        entity.IsDeleted = true;
    }

    public void Update(T entity)
    {
        _appDbContext.Entry(entity).State = EntityState.Modified;
    }
}
