
namespace Figma.Core.Models
{
    public class FigmaProgramConfig : IEntityTypeConfiguration<FigmaProgram>
    {
        public void Configure(EntityTypeBuilder<FigmaProgram> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.Title).IsRequired().HasMaxLength(256);
            builder.Property(x => x.Summary).IsRequired().HasMaxLength(2500);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(2500);
            builder.Property(x => x.Skills).IsRequired().HasMaxLength(2500);
            builder.Property(x => x.Benefits).IsRequired().HasMaxLength(5000);
            builder.Property(x => x.Criteria).IsRequired().HasMaxLength(5000);
            builder.Property(x => x.ProgramType).IsRequired().HasMaxLength(256);
            builder.Property(x => x.Duration).IsRequired().HasMaxLength(256);
            builder.Property(x => x.Location).IsRequired().HasMaxLength(2500);
            builder.Property(x => x.MaxNumber).IsRequired();
            builder.Property(x => x.ApplicationOpen).IsRequired();
            builder.Property(x => x.ApplicationClose).IsRequired();
            builder.Property(x => x.ProgramStart).IsRequired();
        }
    }
}
