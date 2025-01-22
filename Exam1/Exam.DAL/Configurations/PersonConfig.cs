using Exam.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Exam.DAL.Configurations
{
    public class PersonConfig : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasKey(x => x.Id);
            builder
                .HasMany(e => e.Cars)
                .WithOne(e => e.Person)
                .HasForeignKey(e => e.Personİd)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();
            builder.Property(x => x.Name)
                .HasMaxLength(25);
                
        }
    }
    public class CarConfig : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name)
                .HasMaxLength(25)
                .IsRequired();
            builder.Property(x=>x.Price)
                .HasPrecision(15,2);        

        }
    }
}
