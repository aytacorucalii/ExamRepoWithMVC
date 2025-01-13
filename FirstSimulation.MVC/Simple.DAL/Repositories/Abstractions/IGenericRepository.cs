using Microsoft.EntityFrameworkCore;
using Simple.Core.Models.Base;

namespace Simple.DAL.Repositories.Abstractions;

public interface IGenericRepository<T>where T : BaseEntity, new()
{
    DbSet<T> Table { get; }
}
