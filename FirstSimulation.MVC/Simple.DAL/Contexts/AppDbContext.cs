using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Simple.Core.Models;

namespace Simple.DAL.Contexts;

public class AppDbContext : IdentityDbContext<AppUser>
{
    public AppDbContext(DbContextOptions<AppDbContext>contextOpt): base(contextOpt) { }
    public DbSet<CartItem> CartItems { get; set; }


    
}

