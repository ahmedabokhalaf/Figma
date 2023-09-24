
namespace Figma.Core.Models
{
    public class ApplicationFormConfig : IEntityTypeConfiguration<ApplicationForm>
    {
        public void Configure(EntityTypeBuilder<ApplicationForm> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(i => i.Cover).IsRequired();
        }
    }
}
