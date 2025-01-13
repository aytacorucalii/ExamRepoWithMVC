using Microsoft.EntityFrameworkCore;
using Test.Core.Entities.Base;
using Test.DAL.Repositories.Abstractions;

namespace Test.DAL.Repositories.Concretes;

public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity, new()
{
    public DbSet<T> Table => throw new NotImplementedException();
}
