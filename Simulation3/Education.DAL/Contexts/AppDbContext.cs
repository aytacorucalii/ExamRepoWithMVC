using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Education.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Education.DAL.Contexts
{
    public class AppDbContext: DbContext
    {
        DbSet<Category> Categories { get; set; }
        DbSet<News> News { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext>contextOptions): base(contextOptions) { }
       
    }
}
