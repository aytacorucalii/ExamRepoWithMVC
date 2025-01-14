using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Plumberz.Core.Models;

namespace Plumberz.DAL.Contexts;

public class AppDbContext :IdentityDbContext<AppUser>
{
    public DbSet<Service> Services { get; set; }
    public DbSet<Technician> Technicians { get; set; }
    public AppDbContext(DbContextOptions<AppDbContext>contextOpt): base(contextOpt) { }
   
}
