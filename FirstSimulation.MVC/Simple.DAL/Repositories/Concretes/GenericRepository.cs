using Microsoft.EntityFrameworkCore;
using Simple.Core.Models.Base;
using Simple.DAL.Repositories.Abstractions;

namespace Simple.DAL.Repositories.Concretes;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity, new()
{
    public DbSet<T> Table => throw new NotImplementedException();
}
