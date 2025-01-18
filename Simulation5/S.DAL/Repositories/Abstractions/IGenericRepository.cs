using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using S.Core.Models;
using S.DAL.Migrations;

namespace S.DAL.Repositories.Abstractions
{
    public interface IGenericRepository<T> where T : BaseEntity, new()
    {
        DbSet<T> Table { get; }
        Task<ICollection<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> CreateAsync(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        Task<int>SaveChangesAsync();
    }
}
