using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pr.Core.Models;

namespace Pr.DAL.Configurations
{
    public class DoctorConfig : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(e => e.Department)
                   .WithMany(e => e.Doctors)
                   .HasForeignKey(e => e.DepartmentId)
                   .IsRequired();

        }
    }
}
