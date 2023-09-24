using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figma.Core.Models
{
    public class EducationConfig : IEntityTypeConfiguration<Education>
    {
        public void Configure(EntityTypeBuilder<Education> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(i => i.School).IsRequired().HasMaxLength(256);
            builder.Property(i => i.Degree).IsRequired().HasMaxLength(256);
            builder.Property(i => i.Location).IsRequired().HasMaxLength(256);
            builder.Property(i => i.CourseName).IsRequired().HasMaxLength(256);
            builder.Property(i => i.StartDate).IsRequired();
            builder.Property(i => i.EndDate).IsRequired();
        }
    }
}
