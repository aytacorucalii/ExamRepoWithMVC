using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Plumberz.Core.Models;

namespace Plumberz.DAL.Configurations;

public class ServiceConfig : IEntityTypeConfiguration<Service>
{
    public void Configure(EntityTypeBuilder<Service> builder)
    {
        builder.HasKey(s => s.Id);
        builder
            .HasMany(e => e.Technicians)
            .WithOne(e => e.Service)
            .HasForeignKey(e => e.ServiceId)
            .IsRequired();
    }
}
