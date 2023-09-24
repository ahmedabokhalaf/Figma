namespace Figma.Core.Models
{
    public class StageConfig : IEntityTypeConfiguration<Stage>
    {
        public void Configure(EntityTypeBuilder<Stage> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(i => i.Name).IsRequired().HasMaxLength(256);
            builder.Property(i => i.Type).IsRequired().HasMaxLength(2500);
        }
    }
}
