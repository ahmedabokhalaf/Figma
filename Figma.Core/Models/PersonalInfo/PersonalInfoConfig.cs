
namespace Figma.Core.Models
{
    public class PersonalInfoConfig : IEntityTypeConfiguration<PersonalInfo>
    {
        public void Configure(EntityTypeBuilder<PersonalInfo> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(i => i.FirstName).IsRequired().HasMaxLength(100);
            builder.Property(i => i.LastName).IsRequired().HasMaxLength(100);
            builder.Property(i => i.Nationality).IsRequired().HasMaxLength(100);
            builder.Property(i => i.CurrentResidence).IsRequired().HasMaxLength(100);
            builder.Property(i => i.Email).IsRequired().HasMaxLength(100);
            builder.Property(i => i.Gender).IsRequired().HasMaxLength(100);
            builder.Property(i => i.DateOfBirth).IsRequired();
            builder.Property(i => i.Phone).IsRequired().HasMaxLength(11);
            builder.Property(i => i.IdNumber).IsRequired().HasMaxLength(14);
        }
    }
}
