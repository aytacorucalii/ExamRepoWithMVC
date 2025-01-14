using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Plumberz.Core.Models.Base;
using Plumberz.DAL.Migrations;

namespace Plumberz.DAL.Repositories.Abstractions;

public interface IGenericRepository<T> where T : BaseEntity, new()
{
    DbSet<T> Table { get; }

    IQueryable<T> GetAll();
    Task<T> GetByIdAsync(int id);
    Task<T> CreateAsync(T entity);
    void Update(T entity);
    void SoftDelete(T entity);
    Task<bool> IsExistsAsync(int id);
    Task<int> SaveChangesAsync();
}
