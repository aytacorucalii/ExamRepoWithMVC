using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using S.Core.Models;

namespace S.DAL.Configrations
{
    public class AtractionConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(e => e.Atractions)
                   .WithOne(e => e.Category)
                   .HasForeignKey(e => e.CategoryId)
                   .IsRequired();
        }
    }
}
