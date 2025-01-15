using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Education.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Education.DAL.Contigirations;

public class NewsConfig : IEntityTypeConfiguration<News>
{
    public void Configure(EntityTypeBuilder<News> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasOne(e => e.Category)
        .WithMany(e => e.News)
        .HasForeignKey(e => e.CategoryId)
        .IsRequired();
    }
}
