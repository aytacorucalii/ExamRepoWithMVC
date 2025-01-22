using Exam.Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Exam.DAL.Contexts
{
    public class AppDbContext : IdentityDbContext<IdentityUser,IdentityRole, string>
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Person> Persons { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> contextOptions): base(contextOptions) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            #region Roles
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id="", Name="Admin",NormalizedName="ADMIN" },
                 new IdentityRole { Id = "", Name = "User", NormalizedName = "USER" }
                );

            #endregion

            #region User

            IdentityUser admin = new IdentityUser()
            {
                Id = "",
                UserName = "Admin",
                NormalizedUserName = "ADMIN"
            };
            PasswordHasher<IdentityUser> hasher = new();
            admin.PasswordHash = hasher.HashPassword(admin,"admin123");

            modelBuilder.Entity<IdentityUser>().HasData( admin );
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
               new IdentityUserRole<string> { RoleId="", UserId= ""}
                );
            #endregion
        }
    }
}
