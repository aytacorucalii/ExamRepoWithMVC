using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pr.Core.Models;

namespace Pr.DAL.Contexts
{
    public class AppDbContext: DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext>contextOptions): base(contextOptions) { }
        
    }
}
