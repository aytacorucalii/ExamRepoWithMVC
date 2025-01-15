using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Education.Core.Models.Base;
using Microsoft.EntityFrameworkCore;

namespace Education.DAL.Repositories.Abstractions
{
    public interface IGenericRepository<T> where T : BaseEntity , new()
    {
        DbSet<T> Table {  get; }

        Task<ICollection<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> CreateAsync(T entity);
        void Update(T entity);
        void DeleteAsync(T entity);
        Task<bool> IsExists(int id);
        Task<int> SaveChangesAsync();

    }
}
