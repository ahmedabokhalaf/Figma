namespace Figma.Core.Models
{
    public class ProfileConfig : IEntityTypeConfiguration<Profile>
    {
        public void Configure(EntityTypeBuilder<Profile> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(i => i.Resume).IsRequired();
        }
    }
}
