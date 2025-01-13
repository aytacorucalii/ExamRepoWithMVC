using Microsoft.EntityFrameworkCore;
using Test.Core.Entities;

namespace Test.DAL.Contexts;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> contextOptions) : base(contextOptions) { }
    DbSet<SliderItem> SliderItems { get; set; }
}
