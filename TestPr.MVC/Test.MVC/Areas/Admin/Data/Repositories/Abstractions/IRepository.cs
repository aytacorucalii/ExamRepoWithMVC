using Microsoft.EntityFrameworkCore;
using Test.Core.Entities.Base;

namespace Test.DAL.Repositories.Abstractions;

public interface IRepository<T> where T : BaseEntity , new()
{
    DbSet<T> Table { get; }
}
