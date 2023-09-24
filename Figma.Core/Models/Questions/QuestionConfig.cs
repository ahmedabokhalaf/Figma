namespace Figma.Core.Models
{
    public class QuestionConfig : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.Type).IsRequired().HasMaxLength(256);
            builder.Property(x => x.QuestionFormula).IsRequired().HasMaxLength(5000);
        }
    }
}
