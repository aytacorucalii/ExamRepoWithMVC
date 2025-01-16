using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pr.Core.Models.Base;

namespace Pr.DAL.Repositories.Abstractions
{
    public interface IGenericRepository<T> where T : BaseEntity, new()
    {
        DbSet<T> Table {  get; }
        Task<ICollection<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> CreateAsync(T entity);
        Task Update(T entity);
        Task DeleteAsync(T entity);
        Task<int> SaveChangesAsync();
    }
}
