using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using S.Core.Models;

namespace S.DAL.Contexts
{
    public class AppDbContext: DbContext
    {
        public DbSet<Atraction> Atractions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> contextOptions): base(contextOptions) { }
        
    }
}
